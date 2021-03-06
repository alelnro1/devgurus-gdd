﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using PagoElectronico.BaseDeDatos.Conexion;
using PagoElectronico.Conexion;
using System.Data.SqlClient;
using PagoElectronico.Excepciones;
using System.Security.Cryptography;

namespace PagoElectronico
{
    public partial class NewUser : Form
    {
        private Usuario_Bean usuario;
        private UsuarioDAO usuarioDAO; 
        private Cliente_Bean cliente;
        private ClienteDAO clienteDAO;
        private RolDAO rolDAO;
        
        public NewUser(Usuario_Bean usuarioHeredado)
        {
            InitializeComponent();
            usuario = usuarioHeredado;
            usuarioDAO = new UsuarioDAO();
            cliente = new Cliente_Bean();
            clienteDAO = new ClienteDAO();
            rolDAO = new RolDAO();
            setearRolesEnComboBox();

        }

        private ComboBox combo_Rol;
        private TextBox text_Pass;
        private TextBox text_User;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button boton_Cancelar;
        private Button button_Enviar;
        private Label label1;

        private void setearRolesEnComboBox()
        {
            SqlDataReader lector = rolDAO.dameLosNombresDeLosRoles();
            while (lector.Read())
            { combo_Rol.Items.Add(lector["Rol_Desc"]); }
            lector.Close();
        }

        private void boton_Salir_Click(object sender, EventArgs e)
        {
            DialogResult cancelar = MessageBox.Show("Desea cancelar la creacion de nuevo Usuario?", "PC Banking", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cancelar == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button_Enviar_Click(object sender, EventArgs e)
        {
            if (formulario_Incompleto())
            { DialogResult alerta = MessageBox.Show("Debe completar los campos antes de continuar", "PC Banking", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                if (text_Pass.Text != text_Pass_Conf.Text)
                { DialogResult alerta = MessageBox.Show("Las contraseñas ingresadas no coinciden", "PC Banking", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                    {
                        if (usuarioDAO.existeNombreDeUsuario(text_User.Text.ToLower()))
                        { DialogResult alerta = MessageBox.Show("Ya existe un usuario con ese nombre", "PC Banking", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                        else { ejecutarSolicitud(sender, e); }
                    }
                }
        }

        private void ejecutarSolicitud(object sender, EventArgs e)
        {   
            usuario.setUser_Name(text_User.Text);
            usuario.setUser_Pass(text_Pass.Text);
            usuario.setUser_Rol(combo_Rol.Text);
            usuario.setUser_PreguntaSecreta(comboPreSec.Text);
            usuario.serUser_RespuestaSecreta(textRtaSec.Text);
            
            if (!(usuarioDAO.primerArranque()))
            {
                usuario.setUser_Pass(usuarioDAO.encriptar(usuario.getUser_Pass()));
                usuario.serUser_RespuestaSecreta(usuarioDAO.encriptar(usuario.getUser_RespuestaSecreta()));
            }

            if (usuarioDAO.cargarUsuario(usuario))
            {
                DialogResult alerta = MessageBox.Show("La solicitud se ha enviado correctamente", "PC Banking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                DialogResult alerta = MessageBox.Show("Ha ocurrido un problema durante la creación", "PC Banking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool formulario_Incompleto()
        {
            if  ((String.IsNullOrEmpty(text_User.Text)) || (String.IsNullOrEmpty(text_Pass.Text)) || 
                (String.IsNullOrEmpty(text_Pass_Conf.Text)) || (String.IsNullOrEmpty(combo_Rol.Text)) || (String.IsNullOrEmpty(comboPreSec.Text)) ||
                (String.IsNullOrEmpty(textRtaSec.Text)))
            { return true; }
            else return false;
        }

        private void text_User_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(text_User.Text))
            {
                validation.ReadOnly = false;
                if (usuarioDAO.existeNombreDeUsuario(text_User.Text))
                {
                    validation.ForeColor = System.Drawing.Color.Red;
                    validation.Text = "EL USUARIO YA EXISTE";
                }
                else
                {
                    validation.ForeColor = System.Drawing.Color.Green;
                    validation.Text = "USUARIO VALIDO";
                }
                validation.ReadOnly = true;
            }
            else
            { validation.Text = ""; }
        }

    }
}

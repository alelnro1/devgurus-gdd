using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using PagoElectronico.BaseDeDatos.Conexion;

namespace PagoElectronico
{
    public partial class Login : Form
    {
        private Usuario_Bean usuario = new Usuario_Bean();
        private UsuarioDAO usuarioDAO;
        
        public Login()
        {
            leerArchivoConfiguracion(); 
            InitializeComponent();
            usuarioDAO = new UsuarioDAO();
        }

        private void leerArchivoConfiguracion()
        {
            try
            {
                using (StreamReader sr = new StreamReader("ArchivoDeConfiguracion.txt"))
                {
                    string line, textoArchivo = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        textoArchivo = textoArchivo + line + "\n";
                    }
                    obtenerFechayParametrosConexion(textoArchivo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bad Boys 3.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void obtenerFechayParametrosConexion(String archivoConfig)
        {
            char[] delimitadores = { ' ', ',', '.', '\t', '\n' };

            string[] palabras = archivoConfig.Split(delimitadores);

            ConstantesBD.fechaSistema = palabras[2];
            ConstantesBD.Param_Conexion_urlServidor = palabras[9];
            ConstantesBD.Param_Conexion_usuario = palabras[14];
            ConstantesBD.Param_Conexion_contraseña = palabras[17];
            ConstantesBD.Param_Conexion_nombreBD = palabras[24];
        }

        private void text_Pass_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void boton_Salir_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("Desea salir del programa?", "PC Banking", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (salir == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button_Ingreso_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(text_User.Text)) ||
               (String.IsNullOrEmpty(text_Pass.Text)) ||
               (String.IsNullOrEmpty(combo_Roles.Text)))
            {
                DialogResult alerta = MessageBox.Show("Debe completar los campos antes de continuar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (String.IsNullOrEmpty(text_User.Text)) { text_User.Focus(); };
                if (String.IsNullOrEmpty(text_Pass.Text)) { text_Pass.Focus(); };
                if (String.IsNullOrEmpty(combo_Roles.Text)) { combo_Roles.Focus(); };
            }
            else
            {
                usuario.setUser_Name(text_User.Text);
                usuario.setUser_Pass(text_Pass.Text);
                usuario.setUser_Rol(combo_Roles.Text);
                usuarioDAO.validarUsuario(usuario);
            }
         }
   }
}
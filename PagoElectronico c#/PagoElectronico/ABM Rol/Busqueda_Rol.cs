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
    public partial class Busqueda_Rol : Form
    {
        private AbmRolDAO abmRolDAO;

        public Busqueda_Rol()
        {
            InitializeComponent();
            abmRolDAO = new AbmRolDAO();
        }

        private void boton_Volver_Click(object sender, EventArgs e)
        {
            MenuPrincipal nuevoMenu = new MenuPrincipal();
            nuevoMenu.Show();
            this.Hide();
        }

        private void boton_Buscar_Click(object sender, EventArgs e)
        {
            List<String> filtros = new List<String>();
            lista_Roles.Rows.Clear();

            if (rol_Name.Text != "") filtros.Add("[ROL_DESC] like '%" + rol_Name.Text + "%'");
            if ((check_Activo.Checked == true) && (check_No_Activo.Checked == true))
            { }
            else
            {
                if (check_Activo.Checked == true) filtros.Add("[ROL_ESTADO] = 'Activo'");
                if (check_No_Activo.Checked == true) filtros.Add("[ROL_ESTADO] = 'No Activo'");
            }
            if (check_Extraer.Checked == true) filtros.Add("[Func_Extraer] = 'Activo'");
            if (check_Transf.Checked == true) filtros.Add("[Func_Transferir] = 'Activo'");
            if (check_Depos.Checked == true) filtros.Add("[Func_Depositar] = 'Activo'");
            if (check_ABM_Roles.Checked == true) filtros.Add("[Func_ABM_Roles] = 'Activo'");
            if (check_ABM_User.Checked == true) filtros.Add("[Func_ABM_Cuentas] = 'Activo'");
            if (check_ABM_Client.Checked == true) filtros.Add("[Func_ABM_Clientes] = 'Activo'");
            if (check_ABM_Cuentas.Checked == true) filtros.Add("[Func_ABM_Usuarios] = 'Activo'");
            SqlDataReader lector = abmRolDAO.buscarRoles(filtros);
            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[10];

            while (lector.Read())
            {
                columnas[0] = lector["ROL_ID"];
                columnas[1] = lector["ROL_DESC"];
                columnas[2] = lector["ROL_ESTADO"];
                columnas[3] = lector["Func_Extraer"];
                columnas[4] = lector["Func_Transferir"];
                columnas[5] = lector["Func_Depositar"];
                columnas[6] = lector["Func_ABM_Roles"];
                columnas[7] = lector["Func_ABM_Cuentas"];
                columnas[8] = lector["Func_ABM_Clientes"];
                columnas[9] = lector["Func_ABM_Usuarios"];
                               
                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(lista_Roles, columnas);
            }
            lector.Close();
            lista_Roles.Rows.AddRange(filas.ToArray());
        }

        private void boton_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow fila = lista_Roles.SelectedRows[0];
                String id_Rol;

                id_Rol = (fila.Cells[0].Value.ToString());
                EditarRol editarRol = new EditarRol(id_Rol, this);
                editarRol.Show();
                this.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Debe seleccionar un rol primero", "Devgurus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void boton_Reestablecer_Click(object sender, EventArgs e)
        {
            rol_Name.Clear();
            check_Activo.Checked = false;
            check_No_Activo.Checked = false;
            check_Extraer.Checked = false;
            check_Transf.Checked = false;
            check_Depos.Checked = false;
            check_ABM_Roles.Checked = false;
            check_ABM_User.Checked = false;
            check_ABM_Client.Checked = false;
            check_ABM_Cuentas.Checked = false;
        }

        private void boton_Limpiar_Click(object sender, EventArgs e)
        {
            lista_Roles.Rows.Clear();
        }
    }
}
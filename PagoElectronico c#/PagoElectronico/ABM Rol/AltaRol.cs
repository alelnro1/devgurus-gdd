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

namespace PagoElectronico
{
    public partial class EditRol : Form
    {
        private Rol_Bean rol;
        private RolDAO rolDAO;

        public EditRol()
        {
            InitializeComponent();
            rol = new Rol_Bean();
            rolDAO = new RolDAO();
        }

        private void boton_Crear_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(rol_Name.Text))
            { DialogResult alerta = MessageBox.Show("Debe asignar un nombre de rol", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            if (String.IsNullOrEmpty(combo_Estado.Text))
            { DialogResult alerta = MessageBox.Show("Debe asignar un estado al rol", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            if (!(String.IsNullOrEmpty(rol_Name.Text)) && (!(String.IsNullOrEmpty(combo_Estado.Text))))
            {
                rol.setRol_Desc(rol_Name.Text);
                rol.setRol_Estado(combo_Estado.Text);
                if (check_Extraer.Checked == true) {rol.setRol_Func_Extraer("Habilitado");};
                if (check_Transf.Checked == true) {rol.setRol_Func_Transferir("Habilitado");};
                if (check_Depos.Checked == true) {rol.setRol_Func_Depositar("Habilitado");};
                if (check_ABM_Roles.Checked == true) {rol.setRol_Func_ABM_Roles("Habilitado");};
                if (check_ABM_User.Checked == true) {rol.setRol_Func_ABM_Usuarios("Habilitado");};
                if (check_ABM_Client.Checked == true) {rol.setRol_Func_ABM_Clientes("Habilitado");};
                if (check_ABM_Cuentas.Checked == true) {rol.setRol_Func_ABM_Cuentas("Habilitado");};

                rolDAO.insertaUnRol(rol);
            }   
        }

        private void boton_Cancelar_Click(object sender, EventArgs e)
        {
            MenuPrincipal nuevoMenu = new MenuPrincipal();
            nuevoMenu.Show();
            this.Hide();
        }
    }
}

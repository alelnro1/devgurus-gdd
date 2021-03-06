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
                if (check_Extraer.Checked == true) rol.setRol_Func_Extraer("Habilitado");
                else { rol.setRol_Func_Extraer("Inhabilitado"); }

                if (check_Transf.Checked == true) rol.setRol_Func_Transferir("Habilitado");
                else { rol.setRol_Func_Transferir("Inhabilitado"); }

                if (check_Depos.Checked == true) rol.setRol_Func_Depositar("Habilitado");
                else { rol.setRol_Func_Depositar("Inhabilitado"); }

                if (check_ABM_Roles.Checked == true) rol.setRol_Func_ABM_Roles("Habilitado");
                else { rol.setRol_Func_ABM_Roles("Inhabilitado"); }

                if (check_ABM_User.Checked == true) rol.setRol_Func_ABM_Usuarios("Habilitado");
                else { rol.setRol_Func_ABM_Usuarios("Inhabilitado"); }

                if (check_ABM_Client.Checked == true) rol.setRol_Func_ABM_Clientes("Habilitado");
                else { rol.setRol_Func_ABM_Clientes("Inhabilitado"); }

                if (check_ABM_Cuentas.Checked == true) rol.setRol_Func_ABM_Cuentas("Habilitado");
                else { rol.setRol_Func_ABM_Cuentas("Inhabilitado"); }

                if (check_asociar_tarjeta.Checked == true) rol.setRol_Func_Asoc_Tarjeta("Habilitado");
                else { rol.setRol_Func_Asoc_Tarjeta("Inhabilitado"); }

                if (check_Func_Saldo.Checked == true) rol.setRol_Func_Saldo ("Habilitado");
                else { rol.setRol_Func_Saldo("Inhabilitado"); }

                if (check_Func_Estadisticas.Checked == true) rol.setRol_Func_Estadisticas("Habilitado");
                else { rol.setRol_Func_Estadisticas("Inhabilitado"); }

                rolDAO.insertarUnRol(rol);
                DialogResult alerta = MessageBox.Show("El Rol se ha creado exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.Close();
            }
        }

        private void boton_Cancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void group_Func_Enter(object sender, EventArgs e)
        {

        }
    }
}

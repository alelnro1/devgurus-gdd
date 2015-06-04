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

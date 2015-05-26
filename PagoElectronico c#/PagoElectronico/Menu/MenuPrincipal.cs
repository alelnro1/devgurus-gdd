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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void boton_Salir_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("Desea cerrar la sesion actual?", "PC Banking", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (salir == DialogResult.Yes)
            {
                this.Close();
                Login nuevoLogin = new Login();
                nuevoLogin.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditRol nuevaAltaRol = new EditRol();
            nuevaAltaRol.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Busqueda_Rol nuevaEditarRol = new Busqueda_Rol();
            nuevaEditarRol.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABM_Cliente
{
    public partial class Modificar_Tarjeta : Form
    {
        private Form menuBusqueda;

        public Modificar_Tarjeta(Form busqueda)
        {
            InitializeComponent();
            menuBusqueda = busqueda;
        }

        private void Modificar_Tarjeta_Load(object sender, EventArgs e)
        {

        }

        private void boton_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.menuBusqueda.Enabled = true;
            this.menuBusqueda.BringToFront();
        }
    }
}

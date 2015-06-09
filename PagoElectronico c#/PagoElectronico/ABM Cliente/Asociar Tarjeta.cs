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
    public partial class Asociar_Tarjeta : Form
    {
        private Form menuBusqueda;
        public Asociar_Tarjeta(Form busqueda)
        {
            InitializeComponent();
            menuBusqueda = busqueda;
        }

        private void boton_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.menuBusqueda.Enabled = true;
            this.menuBusqueda.BringToFront();
        }
    }
}

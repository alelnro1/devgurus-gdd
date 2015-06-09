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
    public partial class EditarCliente : Form
    {
        private Form menuBusqueda;
        public EditarCliente(String id_Cliente, Form busqueda)
        {
            InitializeComponent();
            menuBusqueda = busqueda;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Asociar_Tarjeta asociarTarjeta = new Asociar_Tarjeta(this);
            asociarTarjeta.Show();
            this.Enabled = false;
        }

        private void boton_desasociar_tarjeta_Click(object sender, EventArgs e)
        {
            Desasociar_Tarjeta desasociarTarjeta = new Desasociar_Tarjeta(this);

            desasociarTarjeta.Show();
            this.Enabled = false;
        }

        private void boton_modificar_tarjeta_Click(object sender, EventArgs e)
        {
            Modificar_Tarjeta modificarTarjeta = new Modificar_Tarjeta(this);
            modificarTarjeta.Show();
            this.Enabled = false;
        }
    }
}

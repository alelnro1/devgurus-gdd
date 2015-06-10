using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PagoElectronico.Excepciones;
using System.Security.Cryptography;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using PagoElectronico.Conexion;
using PagoElectronico.BaseDeDatos.Conexion;


namespace PagoElectronico.ABM_Cliente
{
    public partial class EditarCliente : Form
    {
        Cliente_Bean cliente_Bean;
        private Form menuBusqueda;
        public EditarCliente(String id_Cliente, Form busqueda)
        {   
            cliente_Bean = new Cliente_Bean();
            cliente_Bean.setCliente_Id(id_Cliente);
            InitializeComponent();
            menuBusqueda = busqueda;
        }

        private void button2_Click(object sender, EventArgs e) //ASOCIAR_Tarjeta
        {

            Asociar_Tarjeta asociarTarjeta = new Asociar_Tarjeta(cliente_Bean.getCliente_Id(),this);
            asociarTarjeta.Show();
            this.Enabled = false;
        }

        private void boton_desasociar_tarjeta_Click(object sender, EventArgs e)
        {
            Desasociar_Tarjeta desasociarTarjeta = new Desasociar_Tarjeta(cliente_Bean.getCliente_Id(), this);

            desasociarTarjeta.Show();
            this.Enabled = false;
        }

        private void boton_modificar_tarjeta_Click(object sender, EventArgs e)
        {
            Modificar_Tarjeta modificarTarjeta = new Modificar_Tarjeta(cliente_Bean.getCliente_Id(), this);
            modificarTarjeta.Show();
            this.Enabled = false;
        }
    }
}

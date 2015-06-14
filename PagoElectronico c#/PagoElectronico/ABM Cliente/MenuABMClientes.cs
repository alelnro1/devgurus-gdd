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

    
    public partial class MenuABMClientes : Form
    {
        ClienteDAO clienteDAO;
        BusquedaClientes busqueda;
        
        public MenuABMClientes()
        { 
            clienteDAO = new ClienteDAO();
            busqueda = new BusquedaClientes();
            InitializeComponent();


        }


      

        private void button3_Click(object sender, EventArgs e)
        {
          
            BusquedaClientes buscador = new BusquedaClientes();
            buscador.ShowDialog();
            string hola = Program.Cliente_id_seleccionado;
            if (MessageBox.Show("Estas seguro que desas eliminar el Cliente?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clienteDAO.eliminarCliente( Program.Cliente_id_seleccionado);
            }
        }

        private void button_alta_Click(object sender, EventArgs e)
        {

        }

        private void button_modificar_cliente_Click(object sender, EventArgs e)
        {

        }

    }
}

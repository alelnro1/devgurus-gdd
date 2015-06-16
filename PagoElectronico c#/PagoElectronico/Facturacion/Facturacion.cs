using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.BaseDeDatos.Conexion;
using PagoElectronico.Conexion;
using System.Data.SqlClient;
using PagoElectronico.Excepciones;
using System.Security.Cryptography;

namespace PagoElectronico.Facturacion
{
    public partial class Facturacion : Form
    {
        private Cliente_Bean cliente;
        private FacturacionDAO facturacion_DAO;

        public Facturacion(String cliente_id)
        {
            cliente = new Cliente_Bean();
            cliente.setCliente_Id(cliente_id);
            InitializeComponent();
        }

        private void rendirButton_Click(object sender, EventArgs e)
        {

        }
    }
}

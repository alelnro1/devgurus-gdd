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
namespace PagoElectronico.ABM_Cliente
{
    public partial class AltaCliente : Form
    {
        private CuentaDAO cuenta_DAO;

        public AltaCliente()
        {
            cuenta_DAO = new CuentaDAO();
            InitializeComponent();
            cuenta_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(combo_pais, "Pais_Nombre", "Pais_Nombre", "dbo.Paises");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {

        }

        private void Domicilio_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

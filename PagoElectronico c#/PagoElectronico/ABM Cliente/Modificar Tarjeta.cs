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
    public partial class Modificar_Tarjeta : Form
    {

        private ClienteDAO tarjetaDAO;
        private Form menuBusqueda;

        public Modificar_Tarjeta(String id_Cliente,Form busqueda)
        {
            tarjetaDAO = new ClienteDAO();
            InitializeComponent();
            tarjetaDAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(combo_desasociar_tarjeta, "cuenta_Tarjeta", "cuenta_Tarjeta", "dbo.Cuentas where Cuenta_Cliente = " + id_Cliente);
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

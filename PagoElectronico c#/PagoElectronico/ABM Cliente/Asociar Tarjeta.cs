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
    public partial class Asociar_Tarjeta : Form
    {
        private Cliente_Bean cliente_Bean;
        private ClienteDAO tarjetaDAO;
        private Form menuBusqueda;


        public Asociar_Tarjeta(String id_Cliente,Form busqueda)
        {
            cliente_Bean = new Cliente_Bean();
            cliente_Bean.setCliente_Id(id_Cliente);
            tarjetaDAO = new ClienteDAO();
            InitializeComponent();
            menuBusqueda = busqueda;
            tarjetaDAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(combo_cuenta_de_tarjeta, "Cuenta_Nro", "Cuenta_Nro", "dbo.Cuentas where Cuenta_Cliente = " + cliente_Bean.getCliente_Id());
        }

        private void boton_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.menuBusqueda.Enabled = true;
            this.menuBusqueda.BringToFront();
        }

        private void combo_cuenta_de_tarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {           
        }
    }
}

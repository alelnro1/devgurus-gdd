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

namespace PagoElectronico.ABM_Cuenta
{

    public partial class AltaCuentas : Form
    {

        private Cuenta_Bean cuenta;
        private CuentaDAO cuenta_DAO;



        public AltaCuentas()
        {

            cuenta = new Cuenta_Bean();
            cuenta_DAO = new CuentaDAO();
            InitializeComponent();
            setearPaisesEnComboBox();
            setearTiposDeCuentasEnComboBox();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cuentas_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button_dar_alta_Click(object sender, EventArgs e)
        {
            if (
               (String.IsNullOrEmpty(combo_pais_origen.Text)) ||
               (String.IsNullOrEmpty(combo_moneda.Text)) ||
               (String.IsNullOrEmpty(combo_tipo_cuenta.Text)))
            {
                DialogResult alerta = MessageBox.Show("Debe completar los campos antes de continuar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (String.IsNullOrEmpty(combo_pais_origen.Text)) { combo_pais_origen.Focus(); };
                if (String.IsNullOrEmpty(combo_moneda.Text)) { combo_moneda.Focus(); };

                if (String.IsNullOrEmpty(combo_tipo_cuenta.Text)) { combo_tipo_cuenta.Focus(); };
            }
            else
            {
                cuenta.set_estado("0");//SE MANDA EN 0 POR QUE EN 0 ES DESABILITADO Y POR DEFAULT ESTAN DESABILITADAS
                cuenta.get_tipo_moneda(combo_moneda.Text);
                cuenta.set_tipo_cuenta(combo_tipo_cuenta.Text);
                cuenta.set_pais_origen(combo_pais_origen.Text);
                cuenta.set_tipo_cuenta(combo_tipo_cuenta.Text);
                cuenta.set_paisAsignado("null");
                cuenta.set_fec_Creacion("null");
                cuenta.set_fec_Cierre("null");
                cuenta.set_Cliente("null");
                cuenta_DAO.altaCuenta(cuenta);

            }

        }


        private void setearPaisesEnComboBox()
        {
            SqlDataReader lector = cuenta_DAO.dameLosPaises();
            while (lector.Read())
            { combo_pais_origen.Items.Add(lector["Pais_Nombre"]); }
            lector.Close();
        }


        private void setearTiposDeCuentasEnComboBox()
        {
            SqlDataReader lector = cuenta_DAO.dameLosTiposDeCuenta();
            while (lector.Read())
            { combo_tipo_cuenta.Items.Add(lector["Tipo_De_Cuentas_Nombre"]); }
            lector.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void combo_pais_origen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}

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
            cuenta_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(combo_pais_origen, "Pais_Nombre", "Pais_Nombre", "dbo.Paises");
            cuenta_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(combo_tipo_cuenta, "Tipo_De_Cuentas_Nombre", "Tipo_De_Cuentas_Nombre", ConstantesBD.t_tipos_cuentas);
             cuenta_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(combo_tipo_moneda,"Tipo_De_Moneda_Nombre","Tipo_De_Moneda_Nombre",ConstantesBD.t_tipo_de_moneda);
            
        

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
                    (String.IsNullOrEmpty(combo_tipo_moneda.Text)) ||
                    (String.IsNullOrEmpty(combo_tipo_cuenta.Text)))
                 {
                     DialogResult alerta = MessageBox.Show("Debe completar los campos antes de continuar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                     if (String.IsNullOrEmpty(combo_pais_origen.Text)) { combo_pais_origen.Focus(); };
                     if (String.IsNullOrEmpty(combo_tipo_moneda.Text)) { combo_tipo_moneda.Focus(); };

                     if (String.IsNullOrEmpty(combo_tipo_cuenta.Text)) { combo_tipo_cuenta.Focus(); };
                 }
                 else 
            { //seteamos los campos de cuenta en string
              cuenta.set_estado("'Pendiente'");
                cuenta.set_tipo_cuenta(combo_tipo_cuenta.Text);
                cuenta.set_tipo_moneda(combo_tipo_moneda.Text);
                cuenta.set_paisAsignado("null");
                cuenta.set_pais_origen(combo_pais_origen.Text);                
                cuenta.set_fec_Cierre("null");
                cuenta.set_Cliente("null");//ACA HAY QUE MANDAR EL ID DEL CLIENTE QUE SUPUESTAMENTE VA A SER GLOBAL
              
                
                cuenta_DAO.altaCuenta(cuenta);

            }

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

        private void combo_tipo_moneda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}

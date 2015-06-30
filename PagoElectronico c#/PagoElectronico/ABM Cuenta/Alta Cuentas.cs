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

namespace PagoElectronico
{
    public partial class AltaCuentas : Form
    {

        private Cuenta_Bean cuenta;
        private CuentaDAO cuenta_DAO;

        public AltaCuentas(String cliente_Id)
        {
            cuenta = new Cuenta_Bean();
            cuenta_DAO = new CuentaDAO();
            InitializeComponent();
            setearInformacion();
             cuenta.set_Cliente(cliente_Id);

        }

        private void setearInformacion()
        {
            cuenta_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(combo_pais_Asignado, "Pais_Nombre", "Pais_Nombre", "DEVGURUS.Paises");
            cuenta_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(combo_tipo_cuenta, "Tipo_De_Cuentas_Nombre", "Tipo_De_Cuentas_Nombre", ConstantesBD.t_tipos_cuentas);
            cuenta_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(combo_tipo_moneda, "Tipo_De_Moneda_Nombre", "Tipo_De_Moneda_Nombre", ConstantesBD.t_tipo_de_moneda);
          

        }

        private void button_dar_alta_Click(object sender, EventArgs e)
        {
                if (
                    (String.IsNullOrEmpty(combo_pais_Asignado.Text)) ||
                    (String.IsNullOrEmpty(combo_tipo_moneda.Text)) ||
                    (String.IsNullOrEmpty(combo_tipo_cuenta.Text)))
                 {
                     DialogResult alerta = MessageBox.Show("Debe completar los campos antes de continuar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                     if (String.IsNullOrEmpty(combo_pais_Asignado.Text)) { combo_pais_Asignado.Focus(); };
                     if (String.IsNullOrEmpty(combo_tipo_moneda.Text)) { combo_tipo_moneda.Focus(); };

                     if (String.IsNullOrEmpty(combo_tipo_cuenta.Text)) { combo_tipo_cuenta.Focus(); };
                 }
                 else 
            { //seteamos los campos de cuenta en string
                 cuenta.set_estado("'Pendiente'");
                cuenta.set_tipo_cuenta(combo_tipo_cuenta.Text);
                cuenta.set_tipo_moneda(combo_tipo_moneda.Text);
                cuenta.set_paisAsignado(combo_pais_Asignado.Text.Trim());
                //cuenta.set_pais_origen("null");
                
                cuenta.set_fec_Cierre("null");
                //ACA HAY QUE MANDAR EL ID DEL CLIENTE QUE SUPUESTAMENTE VA A SER 
                
                cuenta_DAO.altaCuenta(cuenta);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*menu_save.Show();
            menu_save.BringToFront();*/
            this.Close();
        }

        private void AltaCuentas_Load(object sender, EventArgs e)
        {

        }
    }
}

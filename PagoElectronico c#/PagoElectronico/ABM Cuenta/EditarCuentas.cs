using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using PagoElectronico.BaseDeDatos.Conexion;
using PagoElectronico.Conexion;
using System.Data.SqlClient;
using PagoElectronico.Excepciones;
using System.Security.Cryptography;

namespace PagoElectronico
{
    public partial class EditarCuentas : Form
    {
        private Cuenta_Bean cuenta_Bean;
        private CuentaDAO cuenta_DAO;
        private Form menuBusquedaCuentas;

        public EditarCuentas(String id_Cuenta, Form busqueda)
        {
            InitializeComponent();
            cuenta_Bean = new Cuenta_Bean();
            cuenta_DAO = new CuentaDAO();
            cuenta_Bean.set_nro_cuenta(id_Cuenta);

            //cargaLosDatosDeLaCuenta(id_Cuenta);
            menuBusquedaCuentas = busqueda;
            cuenta_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(combo_tipo_cuenta, "Tipo_De_Cuentas_Nombre", "Tipo_De_Cuentas_Nombre", ConstantesBD.t_tipos_cuentas);
        }



        /*public void cargaLosDatosDeLaCuenta(String id_Cuenta)
        {
            SqlDataReader lector = cuenta_DAO.dameLaCuenta(id_Cuenta);
            lector.Read();
           // rol_Name.Text = lector["Cuenta_Nro"].ToString();
            //combo_Estado.Text = lector["ROL_ESTADO"].ToString();
            cuenta_Bean.set_nro_cuenta(id_Cuenta);
           
            lector.Close();
        }*/
       
        private void boton_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.menuBusquedaCuentas.Enabled = true;
            this.menuBusquedaCuentas.BringToFront();
        }

        private void boton_Crear_Click(object sender, EventArgs e)
        {
            cuenta_Bean.set_tipo_cuenta(combo_tipo_cuenta.Text);
            this.Close();
            this.menuBusquedaCuentas.Enabled = true;
            this.menuBusquedaCuentas.BringToFront();
                      
            cuenta_DAO.modificarUnaCuenta(cuenta_Bean);
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

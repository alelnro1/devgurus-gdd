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


        public EditarCuentas(String id_Cuenta)
        {
            InitializeComponent();
            cuenta_Bean = new Cuenta_Bean();
            cuenta_DAO = new CuentaDAO();
            cuenta_Bean.set_nro_cuenta(id_Cuenta);


            cuenta_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(combo_tipo_cuenta, "Tipo_De_Cuentas_Nombre", "Tipo_De_Cuentas_Nombre", ConstantesBD.t_tipos_cuentas);
        }



        private void boton_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void boton_Crear_Click(object sender, EventArgs e)
        {
            cuenta_Bean.set_tipo_cuenta(combo_tipo_cuenta.Text);

            cuenta_DAO.modificarUnaCuenta(cuenta_Bean);
            MessageBox.Show("Se editó correctamente la cuenta Nro° "+ cuenta_Bean.get_nro_cuenta(), "Devgurus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditarCuentas_Load(object sender, EventArgs e)
        {

        }

        private void combo_tipo_cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.BaseDeDatos.Conexion;

namespace PagoElectronico.ABM_Cuenta
{

    public partial class AltaCuentas : Form
    {   

        private Cuenta_Bean cuenta = new Cuenta_Bean();
        private CuentaDAO cuenta_DAO = new CuentaDAO();

        public AltaCuentas()
        {

            InitializeComponent();
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
               (String.IsNullOrEmpty(pais_origen_seleccionador.Text)) ||
               (String.IsNullOrEmpty(combo_moneda.Text))||
               (String.IsNullOrEmpty(text_tipo.Text)))

            {
                DialogResult alerta = MessageBox.Show("Debe completar los campos antes de continuar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (String.IsNullOrEmpty(pais_origen_seleccionador.Text)) { pais_origen_seleccionador.Focus(); };
                if (String.IsNullOrEmpty(combo_moneda.Text)) { combo_moneda.Focus(); };
                
                if (String.IsNullOrEmpty(text_tipo.Text)) { text_tipo.Focus(); };
            }
            else
            { 
                cuenta.set_estado("0");//SE MANDA EN 0 POR QUE EN 0 ES DESABILITADO Y POR DEFAULT ESTAN DESABILITADAS
                cuenta.get_tipo_moneda(combo_moneda.Text);
                cuenta.set_tipo_cuenta(text_tipo.Text);
                cuenta.set_pais_origen(pais_origen_seleccionador.Text);
                cuenta.set_paisAsignado("null");
                cuenta.set_fec_Creacion("null");
                cuenta.set_fec_Cierre("null");
                cuenta.set_Cliente("null");
                cuenta_DAO.altaCuenta(cuenta);
                
            }

        }

        private void text_Pais_origen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



    }
}

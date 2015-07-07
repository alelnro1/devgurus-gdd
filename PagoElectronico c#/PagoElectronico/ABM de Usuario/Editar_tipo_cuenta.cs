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
    public partial class Editar_tipo_cuenta : Form
    {
        private UsuarioDAO usuario_DAO;
        public Editar_tipo_cuenta()
        {
            usuario_DAO = new UsuarioDAO();
            InitializeComponent();
            usuario_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(combo_tipo_cuenta, "Tipo_De_Cuentas_Nombre", "Tipo_De_Cuentas_Nombre", ConstantesBD.t_tipos_cuentas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                usuario_DAO.actualizar_monto_tipo_de_cuenta(textBox1.Text, combo_tipo_cuenta.Text);
                MessageBox.Show("Se cambio el costo del tipo de cuenta: " + combo_tipo_cuenta.Text + " a: " + textBox1.Text, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Debe seleccionar un tipo de cuenta y escribir un importe NUMERICO", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico
{
    public partial class MDI : Form
    {
        ABM_Cuenta.AltaCuentas Form_AltaCuentas;
        ABM_Cliente.AltaCliente Form_AltaCliente;

        public MDI()
        {
            InitializeComponent();
        }

        private void cuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        void Form_AltaCuentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_AltaCuentas = null;
        }

        void Form_AltaCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_AltaCliente = null;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir del programa?", "Cerrar Programa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void nuevoClienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Form_AltaCliente == null) // si el form esta cerrado
            {
                Form_AltaCliente = new ABM_Cliente.AltaCliente(); // inicializo el form
                Form_AltaCliente.MdiParent = this;
                Form_AltaCliente.FormClosed += new FormClosedEventHandler(Form_AltaCliente_FormClosed);
                Form_AltaCliente.Show();
            }
            else
            {
                Form_AltaCuentas.Activate();
            }
        }

        private void nuevaCuentaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Form_AltaCuentas == null) // si el form esta cerrado
            {
                Form_AltaCuentas = new ABM_Cuenta.AltaCuentas(); // inicializo el form
                Form_AltaCuentas.MdiParent = this;
                Form_AltaCuentas.FormClosed += new FormClosedEventHandler(Form_AltaCuentas_FormClosed);
                Form_AltaCuentas.Show();
            }
            else
            {
                Form_AltaCuentas.Activate();
            }
        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }
    }
}

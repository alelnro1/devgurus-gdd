﻿using System;
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
        ABM_Cuenta.BusquedaCuentas Form_BuscarCuentas;
        Depositos.Depositos Form_Depositos;
        Retiros.Retiros Form_Retiros;
        Consulta_Saldos.ConsultarSaldo Form_Consultar_Saldo;
        Transferencias.Transferencias Form_Transferencias;
        ABM_Cliente.BusquedaClientes Form_BuscarClientes;
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

        void Form_BuscarClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_BuscarClientes = null;
        }

        void Form_BuscarCuentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_BuscarCuentas = null;
        }

        void Form_Depositos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Depositos = null;
        }

        void Form_Transferencias_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Transferencias = null;
        }

        void Form_Retiros_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Retiros = null;
        }

        void Form_Consultar_Saldo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Consultar_Saldo = null;
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

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form_BuscarClientes == null) // si el form esta cerrado
            {
                Form_BuscarClientes = new ABM_Cliente.BusquedaClientes(); // inicializo el form
                Form_BuscarClientes.MdiParent = this;
                Form_BuscarClientes.FormClosed += new FormClosedEventHandler(Form_BuscarClientes_FormClosed);
                Form_BuscarClientes.Show();
            }
            else
            {
                Form_AltaCuentas.Activate();
            }
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Form_BuscarCuentas == null) // si el form esta cerrado
            {
                Form_BuscarCuentas = new ABM_Cuenta.BusquedaCuentas(); // inicializo el form
                Form_BuscarCuentas.MdiParent = this;
                Form_BuscarCuentas.FormClosed += new FormClosedEventHandler(Form_BuscarCuentas_FormClosed);
                Form_BuscarCuentas.Show();
            }
            else
            {
                Form_BuscarCuentas.Activate();
            }
        }

        private void depositosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form_Depositos == null) // si el form esta cerrado
            {
                Form_Depositos = new Depositos.Depositos("18"); // inicializo el form
                Form_Depositos.MdiParent = this;
                Form_Depositos.FormClosed += new FormClosedEventHandler(Form_Depositos_FormClosed);
                Form_Depositos.Show();
            }
            else
            {
                Form_BuscarCuentas.Activate();
            }
        }

        private void transferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form_Transferencias == null) // si el form esta cerrado
            {
                Form_Transferencias = new Transferencias.Transferencias("18"); // inicializo el form
                Form_Transferencias.MdiParent = this;
                Form_Transferencias.FormClosed += new FormClosedEventHandler(Form_Transferencias_FormClosed);
                Form_Transferencias.Show();
            }
            else
            {
                Form_Transferencias.Activate();
            }
        }

        private void retirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form_Retiros == null) // si el form esta cerrado
            {
                Form_Retiros = new Retiros.Retiros("18"); // inicializo el form
                Form_Retiros.MdiParent = this;
                Form_Retiros.FormClosed += new FormClosedEventHandler(Form_Retiros_FormClosed);
                Form_Retiros.Show();
            }
            else
            {
                Form_Retiros.Activate();
            }
        }

        private void consultarSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form_Consultar_Saldo == null) // si el form esta cerrado
            {
                Form_Consultar_Saldo = new Consulta_Saldos.ConsultarSaldo("18"); // inicializo el form
                Form_Consultar_Saldo.MdiParent = this;
                Form_Consultar_Saldo.FormClosed += new FormClosedEventHandler(Form_Consultar_Saldo_FormClosed);
                Form_Consultar_Saldo.Show();
            }
            else
            {
                Form_Consultar_Saldo.Activate();
            }
        }
    }
}

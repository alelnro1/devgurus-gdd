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

namespace PagoElectronico.Depositos
{
    public partial class Depositos : Form
    {
        private DepositosDAO depositos_DAO;
        private Cliente_Bean cliente;

        public Depositos(string id_cliente)
        {
            cliente = new Cliente_Bean();
            depositos_DAO = new DepositosDAO();
            cliente.setCliente_Id(id_cliente);
            InitializeComponent();
            depositos_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(cuenta_combobox, "Cuenta_Nro", "Cuenta_Nro", "dbo.Cuentas where Cuenta_Cliente = " + cliente.getCliente_Id());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tarjeta = tarjeta_combobox.Text;
            String moneda  = moneda_combobox.Text;
            String cuenta  = cuenta_combobox.Text;

            if (depositos_DAO.importeEsNumerico(importe_textbox.Text))
            {
                int importe = int.Parse(importe_textbox.Text);

                if (depositos_DAO.importeEsMayorAUno(importe))
                {
                    if (depositos_DAO.tarjetaNoEstaVencida(tarjeta))
                    {
                        if (depositos_DAO.cuentaEsTitularDeTarjeta(cuenta, tarjeta))
                        {
                            depositos_DAO.realizarDeposito(cuenta, tarjeta, importe, moneda);
                            MessageBox.Show("El deposito fue realizado", "Atención", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("La cuenta no es titular de la tarjeta", "Atención", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La tarjeta esta vencida", "Atención", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("El importe debe ser mayor a 1", "Atención", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("El importe debe ser numerico", "Atención", MessageBoxButtons.OK);
            }
                    
        }

        private void Depositos_Load(object sender, EventArgs e)
        {

        }
    }
}

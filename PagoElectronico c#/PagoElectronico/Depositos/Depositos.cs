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
            depositos_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(moneda_combobox, "Tipo_De_Moneda_Nombre", "Tipo_De_Moneda_Nombre", ConstantesBD.t_tipo_de_moneda);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tarjeta_digitos_visibles = tarjeta_combobox.Text;
            String moneda  = moneda_combobox.Text;
            String cuenta  = cuenta_combobox.Text;
            String importe = importe_textbox.Text;

            if (!String.IsNullOrEmpty(tarjeta_digitos_visibles) && !String.IsNullOrEmpty(moneda) && !String.IsNullOrEmpty(cuenta) && !String.IsNullOrEmpty(importe))
            {
                if (depositos_DAO.numeroEsFloat(importe))
                {
                    if (depositos_DAO.importeEsMayorANumero(importe, "1"))
                    {
                        if (depositos_DAO.tarjetaNoEstaVencida(tarjeta_digitos_visibles, cliente.getCliente_Id()))
                        {
                            if (depositos_DAO.clienteEsTitularDeTarjeta(cliente.getCliente_Id(), tarjeta_digitos_visibles))
                            {
                                depositos_DAO.realizarDeposito(cuenta, tarjeta_digitos_visibles, importe, moneda);
                                MessageBox.Show("El deposito fue realizado", "Atención", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("El cliente no es titular de la tarjeta", "Atención", MessageBoxButtons.OK);
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
            else
            {
                MessageBox.Show("Faltan datos", "Atención", MessageBoxButtons.OK);
            }
                    
        }

        private void Depositos_Load(object sender, EventArgs e)
        {

        }

        private void cuenta_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tarjeta_combobox.Items.Clear();
            depositos_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(tarjeta_combobox, "Tarjeta_Digitos_Visibles", "Tarjeta_Digitos_Visibles", "dbo.Tarjetas where Tarjeta_Cliente = "
                                                                          + cliente.getCliente_Id() + "and Tarjeta_Asociada = 'Asociada'");
        }

        private void importe_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tarjeta_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void boton_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

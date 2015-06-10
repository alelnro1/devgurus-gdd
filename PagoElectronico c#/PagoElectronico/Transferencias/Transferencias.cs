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

namespace PagoElectronico.Transferencias
{
    public partial class Transferencias : Form
    {

        private TransferenciasDAO transferencias_DAO;
        private Cliente_Bean cliente;

        public Transferencias()
        {
            cliente = new Cliente_Bean();
            transferencias_DAO = new TransferenciasDAO();
            InitializeComponent();
        }

    
        private void Transferir_Click(object sender, EventArgs e)
        {
            String cuenta_origen  = cuenta_origen_combobox.Text;
            String cuenta_destino = cuenta_destino_text.Text;

            if (transferencias_DAO.importeEsNumerico(importe_textbox.Text))
            {
                int importe = int.Parse(importe_textbox.Text);

                if (transferencias_DAO.importeEsMayorANumero(importe, 0))
                {
                    if(!transferencias_DAO.cuentaDestinoCerradaOPendiente(cuenta_destino))
                    {
                        if(transferencias_DAO.tieneSuficienteSaldo(cuenta_origen, importe))
                        {
                            transferencias_DAO.realizarTransferencia(cuenta_origen, cuenta_destino, importe);
                            MessageBox.Show("La transferencia se realizó con exito", "Atención", MessageBoxButtons.OK);
                        }
                        else 
                        {
                            MessageBox.Show("El saldo de la cuenta origen es insuficiente", "Atención", MessageBoxButtons.OK);
                        }
                    }
                    else 
                    {
                        MessageBox.Show("La cuenta destino no puede recibir fondos", "Atención", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("El importe debe ser mayor a 0", "Atención", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("El importe debe ser numerico", "Atención", MessageBoxButtons.OK);
            }

        }
    }
}

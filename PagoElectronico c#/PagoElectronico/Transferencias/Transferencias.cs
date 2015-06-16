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
    public partial class Transferencias : Form
    {

        private TransferenciasDAO transferencias_DAO;
        private Cliente_Bean cliente;

        public Transferencias(String cliente_id)
        {
            cliente = new Cliente_Bean();
            transferencias_DAO = new TransferenciasDAO();
            cliente.setCliente_Id(cliente_id);
            InitializeComponent();
            transferencias_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(cuenta_origen_combobox, "Cuenta_Nro", "Cuenta_Nro", "dbo.Cuentas where Cuenta_Cliente = " + cliente.getCliente_Id());
        }

    
        private void Transferir_Click(object sender, EventArgs e)
        {
            String cuenta_origen  = cuenta_origen_combobox.Text;
            String cuenta_destino = cuenta_destino_text.Text;
            String importe = importe_textbox.Text;

            if (!String.IsNullOrEmpty(cuenta_origen) && !String.IsNullOrEmpty(cuenta_destino) && !String.IsNullOrEmpty(importe))
            {
                if (transferencias_DAO.numeroEsFloat(importe_textbox.Text) && transferencias_DAO.numeroEsInt(cuenta_origen) && transferencias_DAO.numeroEsInt(cuenta_destino))
                {
                    if (transferencias_DAO.importeEsMayorANumero(importe, "0"))
                    {
                        if (!transferencias_DAO.cuentaDestinoCerradaOPendienteONoExiste(cuenta_destino))
                        {
                            if (transferencias_DAO.tieneSuficienteSaldo(cuenta_origen, importe))
                            {
                                if (cuenta_destino != cuenta_origen)
                                {
                                    if (!transferencias_DAO.cuentaOrigenYDestinoPertenecenAlMismoUsuario(cuenta_origen, cuenta_destino))
                                    {
                                        transferencias_DAO.realizarTransferencia(cuenta_origen, cuenta_destino, importe, "0");
                                    }
                                    else
                                    {
                                        transferencias_DAO.realizarTransferencia(cuenta_origen, cuenta_destino, importe, "1");
                                    }

                                    MessageBox.Show("La transferencia se realizó con exito", "Atención", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    MessageBox.Show("No se puede transferir dinero a una misma cuenta", "Atención", MessageBoxButtons.OK);
                                }

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
                    MessageBox.Show("El importe y las cuentas deben ser numericos", "Atención", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Faltan datos", "Atención", MessageBoxButtons.OK);
            }
        }

        private void boton_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

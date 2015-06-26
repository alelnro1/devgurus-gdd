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
    public partial class Retiros : Form
    {
        private RetirosDAO retiros_DAO;
        private Cliente_Bean cliente;

        public Retiros(string id_cliente)
        {
            cliente = new Cliente_Bean();
            retiros_DAO = new RetirosDAO();
            cliente.setCliente_Id(id_cliente);
            InitializeComponent();
            retiros_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(cuenta_combobox, "Cuenta_Nro", "Cuenta_Nro", "DEVGURUS.Cuentas where Cuenta_Cliente = " + cliente.getCliente_Id());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cuenta  = cuenta_combobox.Text;
            String nro_doc = nro_doc_textbox.Text;
            String importe = importe_textbox.Text;

            if (!String.IsNullOrEmpty(importe) && !String.IsNullOrEmpty(nro_doc) && !String.IsNullOrEmpty(importe))
            {
                if (retiros_DAO.numeroEsFloat(importe))
                {
                    if (retiros_DAO.cuentaHabilitada(cuenta))
                    {
                        if (retiros_DAO.tieneSaldo(cuenta) && retiros_DAO.tieneSuficienteSaldo(cuenta, importe))
                        {
                            if (retiros_DAO.documentoValidoParaCuenta(cuenta, nro_doc))
                            {
                                retiros_DAO.realizarRetiro(cuenta, importe);
                                MessageBox.Show("El retiro se realizó y se registro el cheque", "Atención", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("El documento es invalido para dicha cuenta", "Atención", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("La cuenta no tiene saldo suficiente", "Atención", MessageBoxButtons.OK);
                        }

                    }
                    else
                    {
                        MessageBox.Show("La cuenta debe estar habilitada para operar", "Atención", MessageBoxButtons.OK);
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

        private void boton_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

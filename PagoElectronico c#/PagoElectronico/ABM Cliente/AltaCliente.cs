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

namespace PagoElectronico.ABM_Cliente
{
    public partial class AltaCliente : Form
    {
        private Cliente_Bean cliente;
        private ClienteDAO cliente_DAO;

        public AltaCliente()
        {
            cliente = new Cliente_Bean();
            cliente_DAO = new ClienteDAO();
            InitializeComponent();
            cliente_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(combo_pais, "Pais_Nombre", "Pais_Nombre", "dbo.Paises");
        }

        private bool validar_campos_duplicados(Cliente_Bean cliente)
        {
            return cliente_DAO.docTipoEmailSinDuplicar(cliente);
        }

        private void Generar_Click(object sender, EventArgs e)
        {
            cliente.setCliente_Name(nombre_textbox.Text);
            cliente.setCliente_Apell(apellido_textbox.Text);
            cliente.setCliente_TipoDoc(tipo_doc_textbox.Text);
            cliente.setCliente_NroDoc(num_doc_textbox.Text);
            cliente.setCliente_Mail(mail_textbox.Text);
            cliente.setCliente_Pais(combo_pais.Text);
            cliente.setCliente_FecNac(fecha_nac_textbox.Text);
            cliente.setCliente_Calle(calle_textbox.Text);
            cliente.setCliente_Piso(piso_textbox.Text);
            cliente.setCliente_Dpto(depto_textbox.Text);

            if (!campos_vacios(cliente))
            {
                if (campos_numericos(cliente))
                {
                    if (validar_campos_duplicados(cliente))
                    {
                        cliente_DAO.altaCliente(cliente);
                    }
                    else
                    {
                        MessageBox.Show("Los datos ya existen", "Atención", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show("Hay campos que deben ser numericos", "Atención", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Faltan datos", "Atención", MessageBoxButtons.OK);
            }
        }

        private bool campos_numericos(Cliente_Bean cliente)
        {
            int n;
            bool isNumeric_NroDoc  = int.TryParse(cliente.getCliente_NroDoc(), out n);
            bool isNumeric_TipoDoc = int.TryParse(cliente.getCliente_TipoDoc(), out n);

            return isNumeric_NroDoc && isNumeric_TipoDoc;
        }

        private bool campos_vacios(Cliente_Bean cliente)
        {
            return String.IsNullOrEmpty(cliente.getCliente_Apell()) || String.IsNullOrEmpty(cliente.getCliente_Calle()) ||
                String.IsNullOrEmpty(cliente.getCliente_Dpto()) || String.IsNullOrEmpty(cliente.getCliente_FecNac()) ||
                String.IsNullOrEmpty(cliente.getCliente_Mail()) || String.IsNullOrEmpty(cliente.getCliente_Name()) ||
                String.IsNullOrEmpty(cliente.getCliente_NroDoc()) || String.IsNullOrEmpty(cliente.getCliente_Pais()) ||
                String.IsNullOrEmpty(cliente.getCliente_Piso()) || String.IsNullOrEmpty(cliente.getCliente_TipoDoc());
        }

        }
}

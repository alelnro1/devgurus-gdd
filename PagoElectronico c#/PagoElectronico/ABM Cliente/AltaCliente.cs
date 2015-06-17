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
            cliente_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(comboBox_nacionalidad, "Pais_Nombre", "Pais_Nombre", "dbo.Paises");
            cliente_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(comboBox_tipoDoc, "Tipo_Doc_Desc", "Tipo_Doc_Desc", ConstantesBD.t_tipo_doc);

        }

        private void Generar_Click_1(object sender, EventArgs e)
        {
            String usuario = usuario_textbox.Text;

            cliente.setCliente_Name(nombre_textbox.Text);
            cliente.setCliente_Apell(apellido_textbox.Text);
            cliente.setCliente_TipoDoc(comboBox_tipoDoc.Text);
            cliente.setCliente_NroDoc(num_doc_textbox.Text);
            cliente.setCliente_Mail(mail_textbox.Text);
            cliente.setCliente_Pais(combo_pais.Text);
            cliente.setCliente_FecNac(dateTimePicker_nacimiento.Text);
            cliente.setCliente_Nro(textBox_nroCalle.Text);
            cliente.setCliente_Calle(calle_textbox.Text);
            
            cliente.setCliente_Piso(comboBox_piso.Text);
            cliente.setCliente_Dpto(comboBox_depto.Text);
            cliente.setCliente_Nacionalidad(comboBox_nacionalidad.Text);
            cliente.setCliente_localidad(localidad_textbox.Text);
            

            if (!cliente_DAO.camposVacios(cliente) && !String.IsNullOrEmpty(usuario))
            {
                if (cliente_DAO.camposNumericos(cliente))
                {
                    if (!cliente_DAO.hayCamposDuplicados(cliente))
                    {
                        if (cliente_DAO.usuarioExiste(cliente, usuario))
                        {
                            if (!cliente_DAO.clienteAsociadoAUser(cliente))
                            {
                                cliente_DAO.altaCliente(cliente);
                                MessageBox.Show("El cliente ha sido dado de alta", "Atención", MessageBoxButtons.OK,MessageBoxIcon.Information);
                                this.Close();
                            } 
                            else 
                            {
                                MessageBox.Show("Ya existe un cliente con ese usuario", "Atención", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El usuario no existe", "Atención", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Los datos ya existen", "Atención", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show("El N° de identificacion y el Nro de calle deben ser numericos", "Atención", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Complete todos los datos para continuar", "Atención", MessageBoxButtons.OK);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }


        private void AltaCliente_Load(object sender, EventArgs e)
        {

        }

        private void localidad_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_nacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        }
}

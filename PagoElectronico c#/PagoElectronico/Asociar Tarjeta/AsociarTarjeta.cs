using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PagoElectronico.Excepciones;
using System.Security.Cryptography;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using PagoElectronico.Conexion;
using PagoElectronico.BaseDeDatos.Conexion;


namespace PagoElectronico
{
    public partial class AsociarTarjeta : Form
    {
        private TarjetaDAO tarjetaDAO;
        Cliente_Bean cliente_id_para_tarjetas; 
        public AsociarTarjeta(string id_cliente)
        {
            cliente_id_para_tarjetas = new Cliente_Bean();
            cliente_id_para_tarjetas.setCliente_Id(id_cliente);
            tarjetaDAO = new TarjetaDAO();
            InitializeComponent();
            ejecutarBusquedaTarjetas();
            dateTimePicker_vencimiento.MinDate = tarjetaDAO.dame_fecha_sql();
        }

       private void  ejecutarBusquedaTarjetas(){
         
             //   List<String> filtros = new List<String>();
           lista_Tarjetas.Rows.Clear();

                SqlDataReader lector = tarjetaDAO.buscarTarjetas(cliente_id_para_tarjetas.getCliente_Id());
                List<DataGridViewRow> filas = new List<DataGridViewRow>();
                Object[] columnas = new Object[5];
                while (lector.Read()) {

                    
                    columnas[0] = lector["Tarjeta_Digitos_Visibles"];
                    columnas[1] = lector["Tarjeta_Emisor_Desc"];
                    columnas[2] = lector["Tarjeta_Fecha_Emision"]; 
                    columnas[3] = lector["Tarjeta_Fecha_Vencimiento"];
                    columnas[4] = lector["Tarjeta_Asociada"];

                    filas.Add(new DataGridViewRow());
                    filas[filas.Count - 1].CreateCells(lista_Tarjetas, columnas);
                }

                lector.Close();
                lista_Tarjetas.Rows.AddRange(filas.ToArray());
        }

        private void boton_Volver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AsociarTarjeta_Load(object sender, EventArgs e)
        {

        }

        private void cambiar_asociamiento_tarjeta(object sender, EventArgs e,string valor_asociacion)
        {
             try { DataGridViewRow fila = lista_Tarjetas.SelectedRows[0];


             String tarjeta_nro;
                tarjeta_nro = (fila.Cells[0].Value.ToString());

                tarjetaDAO.update_asociada_tarjeta(tarjeta_nro, valor_asociacion);
                this.ejecutarBusquedaTarjetas();
                MessageBox.Show("Ahora su tarjeta N° " + tarjeta_nro + " está " + valor_asociacion + " para realizar Depositos" , "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information); 
             }
            
            
            catch { MessageBox.Show("Debe seleccionar el Usuario antes de aceptar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }

        private void buttom_Asociar_Click_1(object sender, EventArgs e)
        {
            cambiar_asociamiento_tarjeta(sender, e, "Asociada");
        }

        private void boton_Desasociar_Click_1(object sender, EventArgs e)
        {
            cambiar_asociamiento_tarjeta(sender, e, "Desasociada");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // BOTON PARA GENERAR NUEVA TARJETA
        {
            if (!String.IsNullOrEmpty(textBox_nroTarjeta.Text) && !String.IsNullOrEmpty(comboBox_Emisor.Text) && !String.IsNullOrEmpty(dateTimePicker_vencimiento.Text) && !String.IsNullOrEmpty(textBox_codigoSeguridad.Text))
            {
                if (tarjetaDAO.numeroEsInt(textBox_nroTarjeta.Text) && tarjetaDAO.numeroEsInt(textBox_codigoSeguridad.Text) )
                {


                    if (textBox_nroTarjeta.Text.Length == 16)
                    {
                        if (textBox_codigoSeguridad.Text.Length == 3)
                        {
                            tarjetaDAO.agregarTarjetaACliente(cliente_id_para_tarjetas.getCliente_Id(), textBox_nroTarjeta.Text, comboBox_Emisor.Text, ConstantesBD.fechaSistema, dateTimePicker_vencimiento.Text);
                            MessageBox.Show("Se creo la Tarjeta Nro: " + textBox_nroTarjeta.Text + " \n Emisor: " + comboBox_Emisor.Text + " \n Fecha Creacion: " + ConstantesBD.fechaSistema + " \n Fecha Vencimiento: " + dateTimePicker_vencimiento.Text, "Atención", MessageBoxButtons.OK);
                            this.ejecutarBusquedaTarjetas();
                        }
                        else
                        {
                            MessageBox.Show("El codigo de seguridad debe tener 3 digitos ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                     }
                    else
                    {
                        MessageBox.Show("El numero de tarjeta debe ser de 16 digitos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("El nro de tarjeta y codigo de seguridad deben ser numerico", "Atención", MessageBoxButtons.OK , MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos para crear una Nueva Tarjeta ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            }
        }

        
    }
}

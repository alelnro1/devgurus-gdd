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
    public partial class EditarCliente : Form
    {
        ClienteDAO clienteDAO;
        Cliente_Bean cliente_Bean;
        private Form menuBusqueda;
        public EditarCliente(String id_Cliente, Form busqueda)
        {
           
            clienteDAO = new ClienteDAO();
            cliente_Bean = new Cliente_Bean();
            cliente_Bean.setCliente_Id(id_Cliente);
            InitializeComponent();
            menuBusqueda = busqueda;
        
            setearDatosDeCliente();
          //  clienteDAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(combo_nacionalidad, "Pais_Nombre", "Pais_Nombre", "dbo.Paises");
        }

        private void setearDatosDeCliente()
        {

            List<String> filtros = new List<String>();
            filtros.Add("Cliente_Id = " + cliente_Bean.getCliente_Id() );
            SqlDataReader lector = clienteDAO.buscarClientes(filtros);
            Object[] columnas = new Object[15];
            while (lector.Read())
            {

                textBox_nombre.Text = lector["Cliente_Nombre"].ToString();
                textBox_apellido.Text = lector["Cliente_Apellido"].ToString();
                combo_tipoDoc.Text = lector["Tipo_Doc_Desc"].ToString();
                textBox_nroDoc.Text = lector["Cliente_Nro_Doc"].ToString();
                nacionalidad_info.Text = lector["Pais_Nombre"].ToString();
                textBox_pais.Text = lector["Pais_Nombre"].ToString();
                textBox_localidad.Text = lector["Cliente_Localidad"].ToString();
                textBox_calle.Text = lector["Cliente_Dom_Calle"].ToString();
                textBox_nroCalle.Text = lector["Cliente_Dom_Nro"].ToString();
                textBox_piso.Text = lector["Cliente_Dom_Piso"].ToString();
                textBox_depto.Text = lector["Cliente_Dom_Depto"].ToString();
                nacionalidad_info.Text = lector["Cliente_Nacionalidad"].ToString();
                dateTimePicker_nacimiento.Text = lector["Cliente_Fecha_Nac"].ToString();
                textBox_email.Text = lector["Cliente_Mail"].ToString();
                //textBox_fecha_nac.Text = monthCalendar_nacimiento.SelectionRange.Start;
               // textBox_fecha_nac.co Convert.ToDateTime(mnthCalendar1.SelectionEnd.ToShortDateString());
                
               
                // textBox_clienteUser = lector["Cliente_User"].ToString();

            }

            
        }

        private void button2_Click(object sender, EventArgs e) //ASOCIAR_Tarjeta
        {

        }

        private void boton_desasociar_tarjeta_Click(object sender, EventArgs e)
        {
          /*  Desasociar_Tarjeta desasociarTarjeta = new Desasociar_Tarjeta(cliente_Bean.getCliente_Id(), this);

            desasociarTarjeta.Show();
            this.Enabled = false;*/
        }

        private void boton_modificar_tarjeta_Click(object sender, EventArgs e)
        {
         
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {

        }

        private void boton_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            menuBusqueda = new BusquedaClientes(new MenuPrincipal());
            this.menuBusqueda.BringToFront();
        }

        private void cliente_Info_TextChanged(object sender, EventArgs e)
        {

        }

        private void boton_Crear_Click(object sender, EventArgs e)
        {   
            if( textBox_nombre.Text == "" || textBox_apellido.Text == "" ||  combo_tipoDoc.Text == ""   || textBox_nroDoc.Text == "" || 
            textBox_localidad.Text == ""||   textBox_calle.Text == "" || textBox_nroCalle.Text == ""  ||  textBox_piso.Text == "" ||
            textBox_depto.Text == "" || dateTimePicker_nacimiento.Text == "" || textBox_email.Text == "" || combo_nacionalidad.Text == "")
            {
                MessageBox.Show("Complete todos los campos antes de continuar", "Atención!", MessageBoxButtons.OK); 
            }
            
            
            else{
                String cliente = cliente_Bean.getCliente_Id() + "," +
                            textBox_nombre.Text + "," +
                            textBox_apellido.Text + "," +
                            combo_tipoDoc.Text + "," +
                            textBox_nroDoc.Text + "," +
                            textBox_localidad.Text + "," +
                            textBox_calle.Text + "," +
                            textBox_nroCalle.Text + "," +
                            textBox_piso.Text + "," +
                            textBox_depto.Text + "," +
                            nacionalidad_info.Text + "," +
                            dateTimePicker_nacimiento.Text + "," +
                            textBox_email.Text;
            
            clienteDAO.editarCliente(cliente);
            }
            menuBusqueda = new BusquedaClientes(new MenuPrincipal());

        }
    }
}

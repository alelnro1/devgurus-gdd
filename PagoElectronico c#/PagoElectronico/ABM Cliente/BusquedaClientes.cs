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
    public partial class BusquedaClientes : Form
    {
        private ClienteDAO clienteDAO;
        private Form menu_save;

        public BusquedaClientes(Form menu)
        {
            menu_save = menu;
            clienteDAO = new ClienteDAO();
            InitializeComponent();
            clienteDAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(combo_nombre, "Cliente_Nombre", "Cliente_Nombre", ConstantesBD.t_clientes);
            clienteDAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(combo_apellido, "Cliente_Apellido", "Cliente_Apellido", ConstantesBD.t_clientes);
            clienteDAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(combo_tipo_doc, "Tipo_Doc_Desc", "Tipo_Doc_Desc", ConstantesBD.t_tipo_doc);
            clienteDAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(combo_nro_doc, "Cliente_Nro_Doc", "Cliente_Nro_Doc", ConstantesBD.t_clientes);
            clienteDAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(combo_email, "Cliente_Mail", "Cliente_Mail", ConstantesBD.t_clientes);

        }

        private void boton_Buscar_Click(object sender, EventArgs e)
        {
            List<String> filtros = new List<String>();
            lista_clientes.Rows.Clear();

            if (combo_nombre.Text != "") { filtros.Add("Cliente_Nombre like  '%" + combo_nombre.Text + "%'"); }
            if (combo_apellido.Text != "") { filtros.Add("Cliente_Apellido like  '%" + combo_apellido.Text + "%'"); }
            if (combo_tipo_doc.Text != "") { filtros.Add("TD.Tipo_Doc_Desc ='" + combo_tipo_doc.Text + "'"); }
            if (combo_nro_doc.Text != "") { filtros.Add("Cliente_Nro_Doc ='" + combo_nro_doc.Text + "'"); }
            if (combo_email.Text != "") { filtros.Add("Cliente_Mail ='" + combo_email.Text + "'"); }

            SqlDataReader lector = clienteDAO.buscarClientes(filtros);
            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[15];
            while (lector.Read()) {

                columnas[0] = lector["Cliente_Id"];
                columnas[1] = lector["Cliente_Nombre"];
                columnas[2] = lector["Cliente_Apellido"];
                columnas[3] = lector["Tipo_Doc_Desc"]; 
                columnas[4] = lector["Cliente_Nro_Doc"];
                columnas[5] = lector["Pais_Nombre"];
                columnas[6] = lector["Cliente_Localidad"]; 
                columnas[7] = lector["Cliente_Dom_Calle"];
                columnas[8] = lector["Cliente_Dom_Nro"];
                columnas[9] = lector["Cliente_Dom_Piso"];
                columnas[10] = lector["Cliente_Dom_Depto"];
                columnas[11] = lector["Cliente_Nacionalidad"];
                columnas[12] = lector["Cliente_Fecha_Nac"];
                columnas[13] = lector["Cliente_Mail"];
                columnas[14] = lector["Cliente_User"];

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(lista_clientes, columnas);
            }

            lector.Close(); 
            lista_clientes.Rows.AddRange(filas.ToArray());
        }

        private void boton_Reestablecer_Click(object sender, EventArgs e)
        {
            combo_nombre.SelectedIndex = -1;
            combo_apellido.SelectedIndex = -1;
            combo_email.SelectedIndex = -1;
            combo_nro_doc.SelectedIndex = -1;
            combo_tipo_doc.SelectedIndex = -1;

        }

        private void boton_Limpiar_Click(object sender, EventArgs e)
        {
            lista_clientes.Rows.Clear();
        }

        private void boton_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow fila = lista_clientes.SelectedRows[0];
                String id_Cliente;

                id_Cliente = (fila.Cells[0].Value.ToString());
                EditarCliente editarCliente = new EditarCliente(id_Cliente, this);
                editarCliente.Show();
                this.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Debe seleccionar un Cliente primero ", "Devgurus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void boton_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow fila = lista_clientes.SelectedRows[0];
                String id_Cliente;
                id_Cliente = (fila.Cells[0].Value.ToString());
                if (MessageBox.Show("Estas seguro que desas eliminar el Cliente?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                 clienteDAO.eliminarCliente(id_Cliente);
                }
            }
            catch
            {
                MessageBox.Show("Debe seleccionar un primero", "Devgurus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void boton_Volver_Click(object sender, EventArgs e)
        {
       //   seleccionar_cliente_Click
           
             this.Close();
            //menu_save.Show();
            //menu_save.BringToFront();
            
        }

        private void seleccionar_cliente_Click(object sender, EventArgs e)
        {

            try
            {
            DataGridViewRow fila = lista_clientes.SelectedRows[0];
            String id_Cliente;
            id_Cliente = (fila.Cells[0].Value.ToString());
            Program.Cliente_id_seleccionado = id_Cliente;
            this.Close();
            }

            catch
            {
                MessageBox.Show("Debe seleccionar un cliente primero", "Devgurus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

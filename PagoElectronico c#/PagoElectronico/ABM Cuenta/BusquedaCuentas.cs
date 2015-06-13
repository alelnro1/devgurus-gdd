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


namespace PagoElectronico.ABM_Cuenta
{
    public partial class BusquedaCuentas : Form
                
    {
        private CuentaDAO cuenta_DAO;
        
        public BusquedaCuentas()
        {
            cuenta_DAO = new CuentaDAO();
          
            InitializeComponent();
            cuenta_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(combo_pais_origen2, "Pais_Nombre", "Pais_Nombre", "dbo.Paises");
            cuenta_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(combo_tipo, "Tipo_De_Cuentas_Nombre", "Tipo_De_Cuentas_Nombre", ConstantesBD.t_tipos_cuentas);
            cuenta_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(combo_moneda, "Tipo_De_Moneda_Nombre", "Tipo_De_Moneda_Nombre", ConstantesBD.t_tipo_de_moneda);
            cuenta_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(pais_asignado_combo, "Pais_Nombre", "Pais_Nombre", "dbo.Paises");
            cuenta_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(combo_Nro_Cuenta, "Cuenta_Nro", "Cuenta_Nro", ConstantesBD.t_cuentas);
        }

        private void combo_Nro_Cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        /*     if ((check_Pendiente.Checked == true) && (check_Habilitado.Checked == true))
        { }
        else
        {
            if (check_Pendiente.Checked == true) filtros.Add("[ROL_ESTADO] = 'Pendiente'");
            if (check_Habilitado.Checked == true) filtros.Add("[ROL_ESTADO] = 'Habiliado'");
        }
     */   



        private void boton_Buscar_Click(object sender, EventArgs e)
        {
            List<String> filtros = new List<String>(); //asigno los filtros a una lista
            dataGridView1.Rows.Clear(); // borro las filas que ya se cargaron antes en la vista


            //////agrego las condiciones de "where" que se van a meter en SQL*///////


               if (combo_moneda.Text != "")
               {
                   filtros.Add("TM.Tipo_De_Moneda_Nombre = '" + combo_moneda.Text+"'");
               }

             if (combo_tipo.Text != "")
            { filtros.Add("TC.Tipo_De_Cuentas_Nombre = '" + combo_tipo.Text + "'");  }
             if (combo_Nro_Cuenta.Text != "")
             { filtros.Add("CU.Cuenta_Nro = '" + combo_Nro_Cuenta.Text + "'"); }
            
            if (combo_pais_origen2.Text != "") { filtros.Add("PO.Pais_Nombre ='" + combo_pais_origen2.Text + "'"); }
            if (pais_asignado_combo.Text != "") { filtros.Add("PA.Pais_Nombre ='" + pais_asignado_combo.Text + "'"); }
            if (combo_estado.Text != "") { filtros.Add("CU.Cuenta_Estado ='" + combo_estado.Text + "'"); }
            
            
            /*
            if (check_Habilitado.Checked == true) { filtros.Add("[Cuenta_Estado] = 'Habilitado'"); }
            if (check_Deshabilitado.Checked == true) { filtros.Add("[Cuenta_Estado] = 'Inhabilitado'"); }
            if (check_Pendiente.Checked == true) { filtros.Add("[Cuenta_Estado] = 'Pendiente'"); }
            if (check_Cerrada.Checked == true) { filtros.Add("[Cuenta_Estado] = 'Cerrado'"); }*/


            SqlDataReader lector = cuenta_DAO.buscarCuentas(filtros); //le mando los filtros a la funcion buscarCuentas, para que le agregue select de la tabla y un where con criterio del filtro y un and si es mas de un filtro, y traigo el resultado de la consulta y se lo guardo a lector

            List<DataGridViewRow> filas = new List<DataGridViewRow>(); //creo lista de  filas

            Object[] columnas = new Object[10];//creo el vector con la cantidad de columnas en la vista de busqueda 
            while (lector.Read()) //mientras haya registros en la tabla que se esta leyendo que lo asigne a una columna, donde la posicion  que esta indexada en vector "columna[i]" coincide con la posicion de numero de columna (de izq a derecha), y guarda el registro encontrado en dicha columna
            {


                columnas[0] = lector["Cuenta_Nro"];
                columnas[1] = lector["Cuenta_Estado"];
                columnas[2] = lector["Tipo_De_Moneda_Nombre"];
                 columnas[3] = lector["Tipo_De_Cuentas_Nombre"];
                 columnas[4] = lector["Pais_Origen"];
                 columnas[5] = lector["Pais_Asignado"];      
                 columnas[6] = lector["Cuenta_Fec_Cre"];
                 columnas[7] = lector["Cuenta_Fec_Cierre"];
                 columnas[8] = lector["Cuenta_Cliente"];
                 columnas[9] = lector["Cuenta_Saldo"];
               

        

                filas.Add(new DataGridViewRow()); //agrega una fila por cada registro encontrado en la tabla
                filas[filas.Count - 1].CreateCells(dataGridView1, columnas); //crea tantas "Cells" en las filas como columnas tenga, con el respectivo registro
            }
            lector.Close(); //cierro el lector
            dataGridView1.Rows.AddRange(filas.ToArray()); //mando como parametro a las filas de la vista, a las filas cargadas convertidas a un array
        }


        private void check_Habilitado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void check_Deshabilitado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lista_cuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

       

        private void boton_Limpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void boton_Reestablecer_Click(object sender, EventArgs e)
        {
            combo_Nro_Cuenta.SelectedIndex = -1;
            pais_asignado_combo.SelectedIndex = -1;
            combo_tipo.SelectedIndex = -1;
            combo_moneda.SelectedIndex = -1;
            combo_pais_origen2.SelectedIndex = -1;
            combo_estado.SelectedIndex = -1;
            /*
            check_Habilitado.Checked = false;
            check_Deshabilitado.Checked = false;
            check_Cerrada.Checked = false;
            check_Pendiente.Checked = false;
            */
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BusquedaCuentas_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void boton_Eliminar_Click(object sender, EventArgs e)
        {
             try
            {
                DataGridViewRow fila = dataGridView1.SelectedRows[0];
                String id_Cuenta;
                id_Cuenta = (fila.Cells[0].Value.ToString());
                if (MessageBox.Show("Estas seguro que desas eliminar la Cuenta?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cuenta_DAO.eliminarLaCuenta(id_Cuenta);
                }
            }
            catch
            {
                MessageBox.Show("Debe seleccionar una Cuenta primero", "Devgurus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void boton_Editar_Click(object sender, EventArgs e)
        {
               try
            {
                DataGridViewRow fila = dataGridView1.SelectedRows[0];
                String id_Cuenta;

                id_Cuenta = (fila.Cells[0].Value.ToString());
                EditarCuentas editarCuenta = new EditarCuentas(id_Cuenta, this);
                editarCuenta.Show();
                this.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Debe seleccionar una Cuenta primero", "Devgurus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
        }

        private void combo_pais_origen2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }

    }



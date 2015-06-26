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
    public partial class ConsultarSaldo : Form
    {
        private ConsultarSaldoDAO consultar_saldo_DAO;
        private Cliente_Bean cliente;

        public ConsultarSaldo(String cliente_id)
        {
            cliente = new Cliente_Bean();
            consultar_saldo_DAO = new ConsultarSaldoDAO();
            cliente.setCliente_Id(cliente_id);
            InitializeComponent();
            consultar_saldo_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(cuenta_combobox, "Cuenta_Nro", "Cuenta_Nro", "DEVGURUS.Cuentas where Cuenta_Cliente = " + cliente.getCliente_Id());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewDepositos.Rows.Clear();
            String cuenta = cuenta_combobox.Text;
            
            /* DEPOSITOS */
            SqlDataReader lector_depositos = consultar_saldo_DAO.obtenerUltimosCincoDepositos(cuenta);
            List<DataGridViewRow> filas_depositos = new List<DataGridViewRow>();
            Object[] columnas_depositos = new Object[3];

            while (lector_depositos.Read())
            {
                columnas_depositos[0] = lector_depositos["Deposito_Fecha"].ToString();
                columnas_depositos[1] = lector_depositos["Deposito_Importe"].ToString();
                columnas_depositos[2] = lector_depositos["Tipo_De_Moneda_Nombre"].ToString();

                filas_depositos.Add(new DataGridViewRow()); //agrega una fila por cada registro encontrado en la tabla
                filas_depositos[filas_depositos.Count - 1].CreateCells(dataGridViewDepositos, columnas_depositos); //crea tantas "Cells" en las filas como columnas tenga, con el respectivo registro
            }

            lector_depositos.Close();
            dataGridViewDepositos.Rows.AddRange(filas_depositos.ToArray()); //mando como parametro a las filas de la vista, a las filas cargadas convertidas a un array

            /* RETIROS */

            SqlDataReader lector_retiros = consultar_saldo_DAO.obtenerUltimosCincoRetiros(cuenta);
            List<DataGridViewRow> filas_retiros = new List<DataGridViewRow>();
            Object[] columnas_retiros = new Object[2];

            while (lector_retiros.Read())
            {
                columnas_retiros[0] = lector_retiros["Retiro_Fecha"].ToString();
                columnas_retiros[1] = lector_retiros["Retiro_Importe"].ToString();

                filas_retiros.Add(new DataGridViewRow()); //agrega una fila por cada registro encontrado en la tabla
                filas_retiros[filas_retiros.Count - 1].CreateCells(dataGridViewRetiros, columnas_retiros); //crea tantas "Cells" en las filas como columnas tenga, con el respectivo registro
            }

            lector_retiros.Close();
            dataGridViewRetiros.Rows.AddRange(filas_retiros.ToArray()); //mando como parametro a las filas de la vista, a las filas cargadas convertidas a un array

            /* TRANSFERENCIAS */

            SqlDataReader lector_transferencias = consultar_saldo_DAO.obtenerUltimasDiezTransferencias(cuenta);
            List<DataGridViewRow> filas_transferencias = new List<DataGridViewRow>();
            Object[] columnas_transferencias = new Object[4];

            while (lector_transferencias.Read())
            {
                columnas_transferencias[0] = lector_transferencias["Transferencia_Fecha"].ToString();
                columnas_transferencias[1] = lector_transferencias["Transferencia_Cuenta_Destino"].ToString();
                columnas_transferencias[2] = lector_transferencias["Transferencia_Importe"].ToString();
                columnas_transferencias[3] = lector_transferencias["Transferencia_Costo_Transf"].ToString();

                filas_transferencias.Add(new DataGridViewRow()); //agrega una fila por cada registro encontrado en la tabla
                filas_transferencias[filas_transferencias.Count - 1].CreateCells(dataGridViewTransferencias, columnas_transferencias); //crea tantas "Cells" en las filas como columnas tenga, con el respectivo registro
            }

            lector_transferencias.Close();
            dataGridViewTransferencias.Rows.AddRange(filas_transferencias.ToArray()); //mando como parametro a las filas de la vista, a las filas cargadas convertidas a un array

        }

        private void cuenta_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

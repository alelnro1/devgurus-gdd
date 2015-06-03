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

        private Cuenta_Bean cuenta;
        private CheckedListBox checkedListBox1;
        private CuentaDAO cuenta_DAO;


        public BusquedaCuentas()
        {
            cuenta_DAO = new CuentaDAO();
            InitializeComponent();
            cuenta_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(combo_pais_origen, "Pais_Nombre", "Pais_Nombre", "dbo.Paises");
        }

        private void combo_Nro_Cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void boton_Buscar_Click(object sender, EventArgs e)
        
            { List<String> filtros = new List<String>();
            lista_cuentas.Rows.Clear();

            if (combo_pais_origen.Text != "") filtros.Add("[Cuenta_PaisOrigen] like '%" + combo_pais_origen.Text.Trim() + "%'");
        /*     if ((check_Pendiente.Checked == true) && (check_Habilitado.Checked == true))
             { }
             else
             {
                 if (check_Pendiente.Checked == true) filtros.Add("[ROL_ESTADO] = 'Pendiente'");
                 if (check_Habilitado.Checked == true) filtros.Add("[ROL_ESTADO] = 'Habiliado'");
             }
          */   

            SqlDataReader lector = cuenta_DAO.buscarCuentas(filtros);

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[5];

            while (lector.Read())
            {
                  columnas[0] = lector["NULL"];
                  columnas[1] = lector["Pais_Nombre"];
                  columnas[2] = lector["NULL"];
                  columnas[3] = lector["NULL"];
                  columnas[4] = lector["NULL"];
                  columnas[5] = lector["NULL"];

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(lista_cuentas, columnas);
            }
            lector.Close();
            lista_cuentas.Rows.AddRange(filas.ToArray());
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
    }
}

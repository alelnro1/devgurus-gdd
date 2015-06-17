﻿using System;
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
    public partial class Facturacion : Form
    {
        private Cliente_Bean cliente_id_para_facturacion;
        private FacturacionDAO facturacion_DAO;

        public Facturacion(String cliente_id)
        {
            cliente_id_para_facturacion = new Cliente_Bean();
            facturacion_DAO = new FacturacionDAO();
            cliente_id_para_facturacion.setCliente_Id(cliente_id);
            InitializeComponent();
            ejecutarBusquedaTransacciones();

        }
        private void ejecutarBusquedaTransacciones()
        {

            //   List<String> filtros = new List<String>();
            tansacciones_pendientes_data_grid.Rows.Clear();

            SqlDataReader lector = facturacion_DAO.obtenerTransaccionesPendientes(cliente_id_para_facturacion.getCliente_Id());
            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[5];
            while (lector.Read())
            {

                columnas[0] = lector["Transaccion_Pendiente_Id"];
                columnas[1] = lector["Transaccion_Pendiente_Importe"];
                columnas[2] = lector["Transaccion_Pendiente_Descr"];
                columnas[3] = lector["Transaccion_Pendiente_Fecha"];
                columnas[4] = lector["Transaccion_Pendiente_Cuenta_Nro"];


                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(tansacciones_pendientes_data_grid, columnas);
            }

            lector.Close();
            tansacciones_pendientes_data_grid.Rows.AddRange(filas.ToArray());
        }
        private void rendirButton_Click(object sender, EventArgs e)
        {

        }

        private void Facturacion_Load(object sender, EventArgs e)
        {

        }

        private void dgvOperaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
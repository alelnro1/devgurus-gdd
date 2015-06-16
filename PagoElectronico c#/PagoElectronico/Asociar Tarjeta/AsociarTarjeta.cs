﻿using System;
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
        }

       private void  ejecutarBusquedaTarjetas(){
         
             //   List<String> filtros = new List<String>();
           lista_Tarjetas.Rows.Clear();

                SqlDataReader lector = tarjetaDAO.buscarTarjetas(cliente_id_para_tarjetas.getCliente_Id());
                List<DataGridViewRow> filas = new List<DataGridViewRow>();
                Object[] columnas = new Object[5];
                while (lector.Read()) {

                    columnas[0] = lector["Tarjeta_Id"];
                    columnas[1] = lector["Tarjeta_Digitos_Visibles"];
                    columnas[2] = lector["Tarjeta_Emisor_Desc"];
                    columnas[3] = lector["Tarjeta_Fecha_Emision"]; 
                    columnas[4] = lector["Tarjeta_Fecha_Vencimiento"];
        

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
    }
}

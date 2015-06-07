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


            /*   if (combo_moneda.Text != "")
               {
                   filtros.Add("[Tipo_De_Moneda_Nombre] = '" + combo_moneda.Text+"'");
               }*/

             if (combo_tipo.Text != "")
            { filtros.Add("TC.Tipo_De_Cuentas_Nombre = '" + combo_tipo.Text + "' and CU.Cuenta_Tipo = TC.Tipo_De_Cuentas_Id");  }
            
            if (combo_pais_origen2.Text != "") { filtros.Add("PA.Pais_Nombre ='" + combo_pais_origen2.Text + "' and CU.Cuenta_PaisOrigen = PA.Pais_Id"); }

            if (check_Habilitado.Checked == true) { filtros.Add("[Cuenta_Estado] = 'Habilitado'"); }
            if (check_Deshabilitado.Checked == true) { filtros.Add("[Cuenta_Estado] = 'Inhabilitado'"); }
            if (check_Pendiente.Checked == true) { filtros.Add("[Cuenta_Estado] = 'Pendiente'"); }
            if (check_Cerrada.Checked == true) { filtros.Add("[Cuenta_Estado] = 'Cerrado'"); }


            SqlDataReader lector = cuenta_DAO.buscarCuentas(filtros); //le mando los filtros a la funcion buscarCuentas, para que le agregue select de la tabla y un where con criterio del filtro y un and si es mas de un filtro, y traigo el resultado de la consulta y se lo guardo a lector

            List<DataGridViewRow> filas = new List<DataGridViewRow>(); //creo lista de  filas

            Object[] columnas = new Object[3];//creo el vector con la cantidad de columnas en la vista de busqueda 
            while (lector.Read()) //mientras haya registros en la tabla que se esta leyendo que lo asigne a una columna, donde la posicion  que esta indexada en vector "columna[i]" coincide con la posicion de numero de columna (de izq a derecha), y guarda el registro encontrado en dicha columna
            {


                columnas[0] = lector["Cuenta_Nro"];
                 columnas[1] = lector["Tipo_De_Cuentas_Nombre"];
                 columnas[2] = lector["Pais_Nombre"];

              //  columnas[1] = "NULL";//lector["Cuenta_Estado"]; 
               // columnas[2] = "NULL";//lector["Cuenta_Moneda"];
                //columnas[3] = lector["Tipo_De_Cuentas_Nombre"];
               // columnas[4] = lector["Pais_Nombre"];
                //columnas[5] = "NULL";//lector["Cuenta_Fec_Cre"];
                //columnas[6] = "NULL";//lector["Cuenta_Cliente"];
                //columnas[7] = "NULL";//lector["cuenta_Tarjeta"];
                //columnas[8] = "NULL";//lector["Cuenta_Saldo"];
        

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
            combo_tipo.SelectedIndex = -1;
            combo_moneda.SelectedIndex = -1;
            combo_pais_origen2.SelectedIndex = -1;
            check_Habilitado.Checked = false;
            check_Deshabilitado.Checked = false;
            check_Cerrada.Checked = false;
            check_Pendiente.Checked = false;
            
        }

    }
}

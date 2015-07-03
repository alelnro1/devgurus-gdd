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
    public partial class Total_Facturado_por_Cuenta : Form
    {
        private EstadisticasDAO estadisticasDAO;

        public Total_Facturado_por_Cuenta(string anio, int trimestre)
        {
            InitializeComponent();
            estadisticasDAO = new EstadisticasDAO();
            cargar_Datos_Iniciales(anio, trimestre);
        }

        private string dameElNombreDeTrimestre(int trimestre)
        {
            if (trimestre == 1)
            { return "Ene - Mar"; }
            if (trimestre == 2)
            { return "Abr - Jun"; }
            if (trimestre == 3)
            { return "Jul - Sep"; }
            if (trimestre == 4)
            { return "Oct - Dic"; }
            else { return ""; }
        }

        private void cargar_Datos_Iniciales(string anio, int trimestre)
        {
            Info_estadistica.Text = "Totales facturados por Tipo de Cuenta en el año " +
            anio + " y periodo " + dameElNombreDeTrimestre(trimestre) + ".";
            string procedimiento = ConstantesBD.proc_total_Facturado;
            SqlDataReader lector = estadisticasDAO.ejecutar_Lista_Estadistica(procedimiento, anio, trimestre);
            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[2];

            while (lector.Read())
            {
                columnas[0] = lector["Tipo"];
                columnas[1] = lector["Total"];

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(lista_clientes, columnas);
            }
            lector.Close();
            lista_clientes.Rows.AddRange(filas.ToArray());
        }

        private void boton_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

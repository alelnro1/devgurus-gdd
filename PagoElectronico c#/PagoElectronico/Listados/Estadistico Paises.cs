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
    public partial class Estadistico_Pais : Form
    {
        private EstadisticasDAO estadisticasDAO;

        public Estadistico_Pais(string anio, int trimestre)
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
            Info_estadistica.Text = "Movimientos en el año " +
            anio + " y periodo " + dameElNombreDeTrimestre(trimestre) + ".";
            string procedimiento = ConstantesBD.proc_paises_Mayor_Mov;
            SqlDataReader lector = estadisticasDAO.ejecutar_Lista_Estadistica(procedimiento, anio, trimestre);
            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[2];

            while (lector.Read())
            {
                columnas[0] = lector["Pais"];
                columnas[1] = lector["Movimientos"];

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

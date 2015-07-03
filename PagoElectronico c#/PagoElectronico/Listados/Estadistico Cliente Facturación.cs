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
    public partial class Estadistico_Cliente_Facturación : Form
    {
        private EstadisticasDAO estadisticasDAO;

        public Estadistico_Cliente_Facturación(string anio, int trimestre)
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
            Info_estadistica.Text = "Clientes con mayor facturación en el año " +
            anio + " y periodo " + dameElNombreDeTrimestre(trimestre) + ".";
            string procedimiento = ConstantesBD.proc_listar_Mayor_Fact;
            SqlDataReader lector = estadisticasDAO.ejecutar_Lista_Estadistica(procedimiento, anio, trimestre);
            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[15];

            while (lector.Read())
            {
                columnas[0] = lector["Cliente_Id"];
                columnas[1] = lector["Cliente_Nombre"];
                columnas[2] = lector["Cliente_Apellido"];
                columnas[3] = lector["Cantidad_Facturas"];
                columnas[4] = lector["Documento"];
                columnas[5] = lector["Cliente_Nro_Doc"];
                columnas[6] = lector["Pais"];
                columnas[7] = lector["Cliente_Nacionalidad"];
                columnas[8] = lector["Cliente_Localidad"];
                columnas[9] = lector["Cliente_Dom_Calle"];
                columnas[10] = lector["Cliente_Dom_Nro"];
                columnas[11] = lector["Cliente_Dom_Piso"];
                columnas[12] = lector["Cliente_Dom_Depto"];
                columnas[13] = lector["Cliente_Fecha_Nac"];
                columnas[14] = lector["Cliente_Mail"];

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

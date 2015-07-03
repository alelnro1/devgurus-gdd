using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Conexion;
using System.Data.SqlClient;
using PagoElectronico.Excepciones;
using System.Security.Cryptography;
using System.Collections;

namespace PagoElectronico.BaseDeDatos.Conexion
{
    class EstadisticasDAO : DevgurusDAO
    {
        public EstadisticasDAO()
        {
            this.iniciar();
        }

        public SqlDataReader ejecutar_Lista_Estadistica(string procedimiento, string anio, int trimestre)
        {
            String sql = "Execute " + procedimiento + " @anio = " + anio + ", @trimestre = " + trimestre;
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno(sql);
            return lector;
        }
    }
}

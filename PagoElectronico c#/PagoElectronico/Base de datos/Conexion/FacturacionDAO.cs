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
    class FacturacionDAO : DevgurusDAO
    {
        public FacturacionDAO()
        {
            this.iniciar();
        }

        public SqlDataReader obtenerTransaccionesPendientes(String cliente_id)
        {
            String sql = "SELECT * FROM Transaccion_Pendiente WHERE Transaccion_Pendiente_Cliente = '" + cliente_id + "'";
            return this.GD1C2015.ejecutarSentenciaConRetorno(sql);
        }
    }
}

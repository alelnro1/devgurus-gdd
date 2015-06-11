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
    class TransferenciasDAO : DevgurusDAO
    {
        public TransferenciasDAO()
        {
            this.iniciar();
        }

        public bool tieneSuficienteSaldo(String cuenta_origen, String importe)
        {
            bool tieneSaldo = false;
            String sql = "SELECT Cuenta_Saldo FROM Cuentas WHERE Cuenta_Nro = '" + cuenta_origen + "' ";
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno(sql);

            while (lector.Read())
            {
                if (float.Parse(lector["Cuenta_Saldo"].ToString()) >= float.Parse(importe))
                {
                    tieneSaldo = true;
                }
            }

            lector.Close();

            return tieneSaldo;
        }

        public bool cuentaDestinoCerradaOPendiente(string cuenta_destino)
        {
            String sql = "SELECT Cuenta_Estado FROM Cuentas WHERE Cuenta_Nro = '" + cuenta_destino + "' ";
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno(sql);
            String estado;
            bool resultado = false;

            while (lector.Read())
            {
                estado = lector["Cuenta_Estado"].ToString();
                if (estado == "Cerrado" || estado == "Pendiente")
                {
                    resultado = true;
                }
            }

            lector.Close();

            return resultado;

        }

        public void realizarTransferencia(String cuenta_origen, String cuenta_destino, String importe)
        {
            throw new NotImplementedException();
        }
    }
}

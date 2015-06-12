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

        public bool cuentaOrigenYDestinoPertenecenAlMismoUsuario(String cuenta_origen, String cuenta_destino)
        {
            String user_origen = null;
            String user_destino = null;

            String sql_origen  = "SELECT Cuenta_Cliente FROM Cuentas WHERE Cuenta_Nro = '" + cuenta_origen + "' ";
            String sql_destino = "SELECT Cuenta_Cliente FROM Cuentas WHERE Cuenta_Nro = '" + cuenta_destino + "' ";

            SqlDataReader lector_origen = this.GD1C2015.ejecutarSentenciaConRetorno(sql_origen);

            while (lector_origen.Read())
            {
                user_origen = lector_origen["Cuenta_Cliente"].ToString();
            }

            lector_origen.Close();

            SqlDataReader lector_destino = this.GD1C2015.ejecutarSentenciaConRetorno(sql_destino);

            while (lector_destino.Read())
            {
                user_destino = lector_destino["Cuenta_Cliente"].ToString();
            }

            lector_destino.Close();

            if (user_origen == user_destino)
            {
                return true;
            }

            return false;

        }

        public void realizarTransferencia(String cuenta_origen, String cuenta_destino, String importe, String mismo_usuario)
        {
            String sql = "exec realizar_transferencia '" + cuenta_origen + "','" + cuenta_destino + "','" + importe + "','" + mismo_usuario + "'";
            this.GD1C2015.ejecutarSentenciaSinRetorno(sql);
        }
    }
}

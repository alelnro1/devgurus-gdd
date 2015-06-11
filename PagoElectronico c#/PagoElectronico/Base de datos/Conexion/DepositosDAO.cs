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
    class DepositosDAO : DevgurusDAO
    {
        public DepositosDAO()
        {
            this.iniciar();
        }


        public bool tarjetaNoEstaVencida(string tarjeta)
        {
            return this.tarjetaEstaVencida(tarjeta);
        }

        public bool cuentaEsTitularDeTarjeta(string cuenta, string tarjeta)
        {
            bool resultado = false;
            String sql = "SELECT Cuenta_Nro FROM Cuentas WHERE Cuenta_Nro = '" + cuenta + "' AND cuenta_Tarjeta = '" + tarjeta + "' ";
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno(sql);

            if (lector.HasRows)
            {
                resultado = true;
            }

            lector.Close();

            return resultado;
        }

        public void realizarDeposito(string cuenta, string tarjeta, string importe, string moneda)
        {
            String sql = "exec depositar '"+ cuenta + "','" + tarjeta + "','" + importe + "','" + moneda + "'";
            this.GD1C2015.ejecutarSentenciaSinRetorno(sql);
        }
    }
}

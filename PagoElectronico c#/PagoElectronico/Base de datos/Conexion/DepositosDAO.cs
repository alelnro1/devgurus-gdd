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

        public bool importeEsNumerico(String importe)
        {
            int n;
            return int.TryParse(importe, out n);
        }

        public bool importeEsMayorAUno(int importe)
        {
            return (importe > 1);
        }

        public bool tarjetaNoEstaVencida(string tarjeta)
        {
            Nullable<DateTime> fecha_vencimiento = null;
            String sql = "SELECT Tarjeta_Fecha_Vencimiento FROM Tarjetas WHERE Tarjeta_Nro = '" + tarjeta + "' ";
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno(sql);

            while (lector.Read())
            {
                fecha_vencimiento = (DateTime)lector["Tarjeta_Fecha_Vencimiento"];
            }

            lector.Close();

            if (fecha_vencimiento > DateTime.Now.Date)
            {
                return true;
            }

            return false;
        }

        public bool cuentaEsTitularDeTarjeta(string cuenta, string tarjeta)
        {
            throw new NotImplementedException();
        }

        public void realizarDeposito(string cuenta, string tarjeta, int importe, string moneda)
        {
            throw new NotImplementedException();
        }
    }
}

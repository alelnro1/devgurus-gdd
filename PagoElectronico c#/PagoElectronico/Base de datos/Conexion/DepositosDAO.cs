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
            throw new NotImplementedException();
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

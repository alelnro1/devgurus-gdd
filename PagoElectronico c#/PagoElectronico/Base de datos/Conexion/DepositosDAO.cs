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


        public bool tarjetaNoEstaVencida(string tarjeta_digitos_visibles, string cliente_id)
        {
            return this.tarjetaEstaVencida(tarjeta_digitos_visibles, cliente_id);
        }

        public bool clienteEsTitularDeTarjeta(string cliente_id, string tarjeta_digitos_visibles)
        {
            bool resultado = false;
            String sql = "SELECT Tarjeta_Id FROM " + ConstantesBD.t_tarjetas + " WHERE Tarjeta_Cliente = " + cliente_id + " AND Tarjeta_Digitos_Visibles = '" + tarjeta_digitos_visibles + "' ";
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

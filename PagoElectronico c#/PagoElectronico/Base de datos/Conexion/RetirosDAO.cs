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
    class RetirosDAO : DevgurusDAO
    {
        public RetirosDAO()
        {
            this.iniciar();
        }

        public bool tieneSaldo(String cuenta)
        {
            String sql = "SELECT Cuenta_Saldo FROM Cuentas WHERE Cuenta_Nro = '" + cuenta + "' ";
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno(sql);
            Boolean resultado = false;

            while (lector.Read())
            {
                if(int.Parse(lector["Cuenta_Saldo"].ToString()) > 0){
                    resultado = true;
                }
            }

            lector.Close();

            return resultado;
        }

        public bool cuentaHabilitada(String cuenta)
        {
            String sql = "SELECT Cuenta_Estado FROM Cuentas WHERE Cuenta_Nro = '" + cuenta + "' ";
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno(sql);
            Boolean resultado = false;

            while (lector.Read())
            {
                if (lector["Cuenta_Estado"].ToString() == "Habilitado")
                {
                    resultado = true;
                }
            }

            lector.Close();

            return resultado;
        }

        public bool documentoValidoParaCuenta(String cuenta, String nro_doc)
        {
            String sql = "SELECT Cliente_Nro_Doc FROM Clientes CL, Cuentas CU WHERE Cuenta_Nro = '" + cuenta + "' AND Cuenta_Cliente = Cliente_Id ";
     
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno(sql);
            Boolean resultado = false;

            while (lector.Read())
            {
                if (lector["Cliente_Nro_Doc"].ToString() == nro_doc)
                {
                    resultado = true;
                }
            }

            lector.Close();

            return resultado;
        }

        public void realizarRetiro(String cuenta, String importe)
        {
            String sql = "exec retirar '" + cuenta + "','" + importe + "'";
            this.GD1C2015.ejecutarSentenciaSinRetorno(sql);
        }
    }
}

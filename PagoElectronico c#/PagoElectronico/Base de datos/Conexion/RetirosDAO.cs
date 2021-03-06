﻿using System;
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
            String sql = "SELECT Cuenta_Saldo FROM " + ConstantesBD.t_cuentas + " WHERE Cuenta_Nro = '" + cuenta + "' ";
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
            String sql = "SELECT Cuenta_Estado FROM " + ConstantesBD.t_cuentas + " WHERE Cuenta_Nro = '" + cuenta + "' ";
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
            String sql = "SELECT Cliente_Nro_Doc FROM " + ConstantesBD.t_clientes + " CL, " + ConstantesBD.t_cuentas + " CU WHERE Cuenta_Nro = '" + cuenta + "' AND Cuenta_Cliente = Cliente_Id ";
     
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

        public void realizarRetiro(String cuenta, String importe, String banco)
        {
            String sql = "exec DEVGURUS.retirar '" + cuenta + "', '" + importe + "', '" + banco + "'";
            this.GD1C2015.ejecutarSentenciaSinRetorno(sql);
        }

        public void setearTodosLosBancos(ComboBox banco_Combo)
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select Banco_Nombre from " + ConstantesBD.t_bancos);
            while (lector.Read())
            { banco_Combo.Items.Add(lector["Banco_Nombre"]); }
            lector.Close();
        }
    }
}

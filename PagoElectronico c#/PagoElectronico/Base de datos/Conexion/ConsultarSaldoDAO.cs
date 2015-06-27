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
    class ConsultarSaldoDAO : DevgurusDAO
    {
        public ConsultarSaldoDAO()
        {
            this.iniciar();
        }

        public SqlDataReader obtenerUltimosCincoDepositos(String cuenta)
        {
            String sql = "SELECT TOP 5 Deposito_Fecha, Deposito_Importe, Tipo_De_Moneda_Nombre FROM " + ConstantesBD.t_depositos + " INNER JOIN " + ConstantesBD.t_tipo_de_moneda + " ON Tipo_De_Moneda_Id = Deposito_TipoMoneda WHERE Deposito_Cuenta = '" + cuenta + "' ORDER BY Deposito_Fecha DESC";
            return this.GD1C2015.ejecutarSentenciaConRetorno(sql);
        }

        public SqlDataReader obtenerUltimosCincoRetiros(String cuenta)
        {
            String sql = "SELECT TOP 5 Retiro_Fecha, Retiro_Importe FROM " + ConstantesBD.t_retiros + " WHERE Retiro_Cuenta = '" + cuenta + "' ORDER BY Retiro_Fecha DESC";
            return this.GD1C2015.ejecutarSentenciaConRetorno(sql);
        }

        public SqlDataReader obtenerUltimasDiezTransferencias(String cuenta)
        {
            String sql = "SELECT TOP 10 Transferencia_Fecha, Transferencia_Cuenta_Destino, Transferencia_Importe, Transferencia_Costo_Transf FROM " + ConstantesBD.t_transferencia + " WHERE Transferencia_Cuenta_Emisora = '" + cuenta + "' ORDER BY Transferencia_Fecha DESC";
            return this.GD1C2015.ejecutarSentenciaConRetorno(sql);
        }
    }
}

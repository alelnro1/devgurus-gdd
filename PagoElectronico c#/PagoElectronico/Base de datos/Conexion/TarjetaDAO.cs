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
    class TarjetaDAO : DevgurusDAO
    {
        public TarjetaDAO()
        {
            this.iniciar();
        }
        public SqlDataReader buscarTarjetas(string cliente_id)
        {


            String sentenciaSQL = "select Tarjeta_Id, Tarjeta_Digitos_Visibles,Tarjeta_Emisor_Desc,Tarjeta_Fecha_Emision,Tarjeta_Fecha_Vencimiento,Tarjeta_Asociada FROM " + ConstantesBD.t_tarjetas + " where Tarjeta_Cliente ='" + cliente_id + "'";

           
            return this.GD1C2015.ejecutarSentenciaConRetorno(sentenciaSQL);
        }



        public void update_asociada_tarjeta(string id_tarjeta, string estado)
        {
            string sql;
            sql = "UPDATE " + ConstantesBD.t_tarjetas + " SET Tarjeta_Asociada = '" + estado + "' WHERE Tarjeta_Id = " + id_tarjeta;


            this.GD1C2015.ejecutarSentenciaSinRetorno(sql);
        }
    }
}

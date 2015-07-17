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
            sql = "UPDATE " + ConstantesBD.t_tarjetas + " SET Tarjeta_Asociada = '" + estado + "' WHERE Tarjeta_Digitos_Visibles = " + id_tarjeta;


            this.GD1C2015.ejecutarSentenciaSinRetorno(sql);
        }

        internal void agregarTarjetaACliente(String cliente_id_para_tarjetas , String nro_tarjeta , String emisor,String fecha_apertura , String fecha_vencimiento )
        {   String ultimos_cuatro_digitos = nro_tarjeta.Substring(nro_tarjeta.Length -4);
            String sentenciaSql;
           
            sentenciaSql = "declare @fecha_A_usar datetime"
                           +" select @fecha_A_usar = Fecha_Seteada from DEVGURUS.Fecha_Sistema " +
            " insert into " + ConstantesBD.t_tarjetas +
                " (Tarjeta_Nro, Tarjeta_Cliente, Tarjeta_Digitos_Visibles, Tarjeta_Fecha_Emision, Tarjeta_Fecha_Vencimiento, Tarjeta_Cod_Seg, Tarjeta_Emisor_Desc , Tarjeta_Asociada) values (" +
                    (nro_tarjeta + "," + cliente_id_para_tarjetas + "," + ultimos_cuatro_digitos + ",@fecha_A_usar, CAST('" + fecha_vencimiento + "' AS datetime) ," + "123" + ", '" + emisor + "', 'Desasociada')");
            this.GD1C2015.ejecutarSentenciaSinRetorno(sentenciaSql);
        }


        internal void actualizar_tarjeta(string id_tarjetita_editar, string id_clientito, string fechita)
        {
            string sql;
            sql = "declare @fecha_A_usar datetime "
                + " select @fecha_A_usar = CAST('" + fechita + "' AS datetime) " +
            " UPDATE DEVGURUS.Tarjetas SET Tarjeta_Fecha_Vencimiento = @fecha_A_usar where Tarjeta_Cliente = " + id_clientito + " and Tarjeta_Digitos_Visibles = " + id_tarjetita_editar;
            this.GD1C2015.ejecutarSentenciaSinRetorno(sql);

        }

        internal bool hayTarjetaDuplicada(string tarjetaNro)
        {
            bool resultado = false;
            String sentenciaSQL;
            sentenciaSQL = "select *from "+ ConstantesBD.t_tarjetas +" where Tarjeta_Nro = HASHBYTES('MD5','" + tarjetaNro + "')";
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno(sentenciaSQL);
            
            lector.Read();

            if (lector.HasRows)
            {
                resultado = true;
            }
             
            
            lector.Close();

            return resultado;
        }
    }
}
 
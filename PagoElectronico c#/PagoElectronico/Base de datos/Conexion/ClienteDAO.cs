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
    class ClienteDAO : DevgurusDAO
    {
        public ClienteDAO()
        {
            this.iniciar();
        }

        public bool validarClienteExiste(Cliente_Bean cliente)
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select [Cliente_Id] from " + ConstantesBD.t_clientes +
            " where [Cliente_Nombre] = '" + cliente.getCliente_Name() + "' and [Cliente_Apellido] = '"
                                          + cliente.getCliente_Apell() + "' and [Cliente_Nro_Doc] = '"
                                          + cliente.getCliente_NroDoc() + "' and (convert(varchar(10),[Cliente_Fecha_Nac],103)) = '"
                                          + cliente.getCliente_FecNac() + "';");
                if (lector.HasRows)
                   {
                       cliente.setCliente_Id(lector["Cliente_Id"].ToString());
                       lector.Close(); 
                       return true;
                   }
                   else
                   {
                       lector.Close(); 
                       return false;
                   }
         }

        // Metodo que sirve para el alta de Cliente, como dice en el enunciado (pag. 9)
        public bool docTipoEmailSinDuplicar(Cliente_Bean cliente){
            String sql = "SELECT id FROM Clientes WHERE " +
                            "Cliente_Nro_Doc = '" + cliente.getCliente_NroDoc() + "'" +
                            "AND Cliente_Tipo_Doc  = '" + cliente.getCliente_TipoDoc() + "' " +
                            "AND Cliente_Mail = '" + cliente.getCliente_Mail() + "' ";
            SqlDataReader datos = this.GD1C2015.ejecutarSentenciaConRetorno(sql);

            return datos.HasRows;
        }

        public void asignaleElUsuario(Cliente_Bean cliente)
        {
 //     AQUI SE DEBE HACER UN UPDATE DEL CLIENTE QUE TOMA COMO PARAMETRO Y CARGARLE EL ID DE USUARIO
 //     BUSCAR POR NUMERO DE DOCUMENTO (INFALIBLE)
        }

        public void altaCliente(Cliente_Bean cliente)
        {
            //String proc2 = "exec insertarNuevoCliente" + "'" + pais.Trim() + "'";
            String proc = "exec insertarNuevoCliente " + "'" + cliente.getCliente_Apell() + "'," + cliente.getCliente_Calle() + "'" + cliente.getCliente_Dpto() + "," + cliente.getCliente_FecNac() + "," + cliente.getCliente_Mail() + "," + cliente.getCliente_Name() + "," + cliente.getCliente_NroDoc() + "," + cliente.getCliente_Pais() + "," + cliente.getCliente_Piso() + "," + cliente.getCliente_TipoDoc();
            this.GD1C2015.ejecutarSentenciaSinRetorno("exec insertarNuevoCliente " + cliente);
        }

        protected void lanzarExcepcion(String mensajeError, SqlDataReader lector)
        {
            lector.Close();
            throw new ValidacionErroneaUsuarioException(mensajeError);
        }


        public SqlDataReader buscarClientes(List<String> filtros)
        {

            String sentenciaSQL = " select CU.Cuenta_Nro, TC.Tipo_De_Cuentas_Nombre, PO.Pais_Nombre Pais_Origen,PA.Pais_Nombre Pais_Asignado,  CU.Cuenta_Estado, TM.Tipo_De_Moneda_Nombre, CU.Cuenta_Fec_Cre, CU.Cuenta_Fec_Cierre,CU.Cuenta_Cliente, CU.cuenta_Tarjeta, CU.Cuenta_Saldo from Cuentas CU, Paises PO ,  Tipo_De_Cuentas TC,Tipo_De_Moneda TM, Paises PA";
          
            IEnumerator enumerador = filtros.GetEnumerator();
           // sentenciaSQL = sentenciaSQL + " where CU.Cuenta_Tipo = TC.Tipo_De_Cuentas_Id and CU.Cuenta_PaisOrigen = PO.Pais_Id and CU.Cuenta_Moneda= TM.Tipo_De_Moneda_Id and CU.Cuenta_PaisAsignado =PA.Pais_Id";
            if (enumerador.MoveNext())
            {
                sentenciaSQL = sentenciaSQL + " and " + enumerador.Current;

                while (enumerador.MoveNext())
                {
                    sentenciaSQL = sentenciaSQL + " and " + enumerador.Current;
                }

            }
            return this.GD1C2015.ejecutarSentenciaConRetorno(sentenciaSQL);
        }

    }
}
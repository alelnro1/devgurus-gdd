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

        public bool clienteAsociadoAUser(Cliente_Bean cliente)
        {
            bool resultado;
            String sql = "SELECT Cliente_Id FROM " + ConstantesBD.t_clientes + " WHERE Cliente_User = '" + cliente.getCliente_IdUser() + "' ";

            SqlDataReader datos = this.GD1C2015.ejecutarSentenciaConRetorno(sql);

            resultado = datos.HasRows;

            datos.Close();

            return resultado;
        }

        private bool docTipoEmailSinDuplicar(Cliente_Bean cliente)
        {
            bool resultado;
            String sql = "SELECT Cliente_Id FROM " + ConstantesBD.t_clientes + " WHERE " +
                            "Cliente_Nro_Doc = '" + cliente.getCliente_NroDoc() + "' " +
                            "AND Cliente_Tipo_Doc  = '" + cliente.getCliente_TipoDoc() + "' " +
                            "AND Cliente_Mail = '" + cliente.getCliente_Mail() + "' ";

            SqlDataReader datos = this.GD1C2015.ejecutarSentenciaConRetorno(sql);

            resultado = datos.HasRows;

            datos.Close();

            return resultado;
        }

        public bool camposNumericos(Cliente_Bean cliente)
        {
            int n;
            bool isNumeric_NroDoc = int.TryParse(cliente.getCliente_NroDoc(), out n);
            bool isNumeric_NroCalle = int.TryParse(cliente.getCliente_Nro(), out n);

            return isNumeric_NroDoc && isNumeric_NroCalle;
        }

        public bool camposVacios(Cliente_Bean cliente)
        {
            return String.IsNullOrEmpty(cliente.getCliente_Apell()) || String.IsNullOrEmpty(cliente.getCliente_Calle()) ||
                String.IsNullOrEmpty(cliente.getCliente_Dpto()) || String.IsNullOrEmpty(cliente.getCliente_FecNac()) ||
                String.IsNullOrEmpty(cliente.getCliente_Mail()) || String.IsNullOrEmpty(cliente.getCliente_Name()) ||
                String.IsNullOrEmpty(cliente.getCliente_NroDoc()) || String.IsNullOrEmpty(cliente.getCliente_Pais()) ||
                String.IsNullOrEmpty(cliente.getCliente_Piso()) || String.IsNullOrEmpty(cliente.getCliente_TipoDoc()) ||
                String.IsNullOrEmpty(cliente.getCliente_Nro()) ||  String.IsNullOrEmpty(cliente.getCliente_Nacionalidad());
        }

        public bool hayCamposDuplicados(Cliente_Bean cliente)
        {
            return docTipoEmailSinDuplicar(cliente);
        }

        public void asignaleElUsuario(Cliente_Bean cliente)
        {
            //     AQUI SE DEBE HACER UN UPDATE DEL CLIENTE QUE TOMA COMO PARAMETRO Y CARGARLE EL ID DE USUARIO
            //     BUSCAR POR NUMERO DE DOCUMENTO (INFALIBLE)
        }

        public bool usuarioExiste(Cliente_Bean cliente, String usuario)
        {
            bool has_rows;
            String sql = "SELECT Usuarios_Id FROM " + ConstantesBD.t_usuarios + " WHERE Usuarios_Name = '" + usuario + "'";

            SqlDataReader datos = this.GD1C2015.ejecutarSentenciaConRetorno(sql);

            has_rows = datos.HasRows;

            if (has_rows)
            {
                while (datos.Read())
                {
                    cliente.setCliente_IdUser(datos["Usuarios_Id"].ToString());
                }
            }

            datos.Close();

            return has_rows;
        }

        // Metodo que sirve para el alta de Cliente, como dice en el enunciado (pag. 9)
        public void altaCliente(Cliente_Bean cliente)	
        {
            //String proc2 = "exec insertarNuevoCliente" + "'" + pais.Trim() + "'";
            String proc = "exec DEVGURUS.insertarNuevoCliente " + "'" + cliente.getCliente_Apell() + "','" + cliente.getCliente_Calle() + "','" + cliente.getCliente_Dpto() + "','" + cliente.getCliente_Mail() + "','" + cliente.getCliente_Name() + "','" + cliente.getCliente_NroDoc() + "','" + cliente.getCliente_Pais() + "','" + cliente.getCliente_Piso() + "','" + cliente.getCliente_TipoDoc() + "','" + cliente.getCliente_IdUser() + "','" + cliente.getCliente_localidad() + "','" + cliente.getCliente_FecNac() + "'," + cliente.getCliente_Nro() + ",'" + cliente.getCliente_Nacionalidad() + "'";
            this.GD1C2015.ejecutarSentenciaSinRetorno(proc);
        }

        protected void lanzarExcepcion(String mensajeError, SqlDataReader lector)
        {
            lector.Close();
            throw new ValidacionErroneaUsuarioException(mensajeError);
        }


        public SqlDataReader buscarClientes(List<String> filtros)
        {

            String sentenciaSQL = "select CLI.Cliente_Id, CLI.Cliente_Nombre, CLI.Cliente_Apellido,"+
                                  "TD.Tipo_Doc_Desc,CLI.Cliente_Nro_Doc, P.Pais_Nombre Pais,CLI.Cliente_Dom_Calle,CLI.Cliente_Dom_Nro," +
	                              "CLI.Cliente_Dom_Piso, CLI.Cliente_Dom_Depto, Cliente_Fecha_Nac,CLI.Cliente_Mail,"+
                                  "CLI.Cliente_User, N.Pais_Nombre Nacionalidad, CLI.Cliente_Localidad, CLI.Cliente_Estado " +
                                  " FROM " + ConstantesBD.t_clientes + " CLI, " + ConstantesBD.t_tipo_doc + " TD, " + ConstantesBD.t_paises + " P," + ConstantesBD.t_paises + " N";
          
            IEnumerator enumerador = filtros.GetEnumerator();
            sentenciaSQL = sentenciaSQL + " WHERE CLI.Cliente_Tipo_Doc = TD.Tipo_Doc_Id and CLI.Cliente_Pais = P.Pais_Id and  CLI.Cliente_Nacionalidad = N.Pais_Id";
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


        public void editarCliente(String cliente) {
            this.GD1C2015.ejecutarSentenciaSinRetorno("exec DEVGURUS.actualizar_cliente " + cliente);
        }

      public void eliminarCliente(String id_cliente){
          this.GD1C2015.ejecutarSentenciaSinRetorno("exec DEVGURUS.eliminar_Cliente " + id_cliente);

               
      }
        
        
        
        
        /*  public void eliminarCliente(String id_cliente)
        {
            if (id_cliente == "1")
            { MessageBox.Show("No se puede eliminar este cliente - Administrador", "Atención!", MessageBoxButtons.OK); }
            else
            {
                try
                {
                    List<SqlParameter> parametros = new List<SqlParameter>();
                    SqlParameter parametro;

                    parametro = new SqlParameter("@Id_Cliente", id_cliente);
                    parametros.Add(parametro);
                    this.GD1C2015.ejecutarProcedimiento(ConstantesBD.proc_eliminar_Cliente, parametros).Close();
                    MessageBox.Show("El cliente se ha eliminado correctamente", "Atención!", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("No ha sido posible eliminar el cliente", "Atención!", MessageBoxButtons.OK);
                }
            }

        }*/
        
        public string DameNombreApellido(string id_Cliente)
        {
            string nombreApellido = "";
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select [Cliente_Nombre], [Cliente_Apellido] from " + ConstantesBD.t_clientes + " where Cliente_Id = '" + id_Cliente + "';");
            if (lector.HasRows)
            {
                lector.Read();
                nombreApellido = lector["Cliente_Nombre"].ToString() + "  " + lector["Cliente_Apellido"].ToString();
                lector.Close();
            }
            return nombreApellido;
        }

        public string dameElIdCliente(String id_Usuario)
        {
            string id_Cliente = "";
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select [Cliente_Id] from " + ConstantesBD.t_clientes +
            " where Cliente_User = '" + id_Usuario + "';");
            lector.Read();
            if (lector.HasRows)
            {
                id_Cliente = lector["Cliente_Id"].ToString();
                lector.Close();
            }
            return id_Cliente;
        }
    }
}


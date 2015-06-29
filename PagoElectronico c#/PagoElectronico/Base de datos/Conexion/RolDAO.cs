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
    class RolDAO : DevgurusDAO
    {
        public RolDAO()
        {
            this.iniciar();
        }

        public SqlDataReader dameLosNombresDeLosRoles()
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select [ROL_DESC] from " + ConstantesBD.t_roles + ";");
            return lector;
        }

        public SqlDataReader dameElRol(String id_Rol)
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select [ROL_ID], [ROL_DESC], [ROL_ESTADO], [Func_Extraer], [Func_Transferir], [Func_Depositar], [Func_ABM_Roles], [Func_ABM_Clientes], [Func_ABM_Usuarios], [Func_ABM_Cuentas], [Func_Asociar_Tarjeta] from " +
                ConstantesBD.t_roles + " where [ROL_ID] = '" + id_Rol + "';");
            return lector;
        }

        public void insertarUnRol(Rol_Bean rol)
        {
            String sentencia = "insert into " + ConstantesBD.t_roles + " (Rol_Desc, Rol_Estado, Func_Extraer, Func_Transferir, Func_Depositar, Func_ABM_Roles, Func_ABM_Clientes, Func_ABM_Usuarios, Func_ABM_Cuentas,Func_Estadisticas, Func_Saldo, Func_Asociar_Tarjeta) values ('" +
            rol.getRol_Desc() + "', '" +
            rol.getRol_Estado() + "', '" +
            rol.getRol_Func_Extraer() + "', '" +
            rol.getRol_Func_Transferir() + "', '" +
            rol.getRol_Func_Depositar() + "', '" +
            rol.getRol_Func_ABM_Roles() + "', '" +
            rol.getRol_Func_ABM_Clientes() + "', '" +
            rol.getRol_Func_ABM_Usuarios() + "', '" +
            rol.getRol_Func_ABM_Cuentas() + "', '" +
            rol.getrol_Func_Estadisticas() + "', '" +
            rol.getrol_Func_Saldo() + "', '" +
            rol.getRol_Func_Asoc_Tarjeta() + "')";

            this.GD1C2015.ejecutarSentenciaSinRetorno(sentencia);
        }

        public void modificarUnRol(Rol_Bean rol)
        {
            String consulta = "UPDATE " + ConstantesBD.t_roles + " set " +
                            "Rol_Desc = '" + rol.getRol_Desc() + "', " +
                            "Rol_Estado = '" + rol.getRol_Estado() + "', " +
                            "Func_Extraer = '" + rol.getRol_Func_Extraer() + "', " +
                            "Func_Transferir = '" + rol.getRol_Func_Transferir() + "', " +
                            "Func_Depositar = '" + rol.getRol_Func_Depositar() + "', " +
                            "Func_ABM_Roles = '" + rol.getRol_Func_ABM_Roles() + "', " +
                            "Func_ABM_Clientes = '" + rol.getRol_Func_ABM_Clientes() + "', " +
                            "Func_ABM_Usuarios = '" + rol.getRol_Func_ABM_Usuarios() + "', " +
                            "Func_ABM_Cuentas = '" + rol.getRol_Func_ABM_Cuentas() + "', " +
                            "Func_Asociar_Tarjeta = '" + rol.getRol_Func_Asoc_Tarjeta() + "' " +
                            "where Rol_Id = '" + rol.getRol_Id() + "'";

            this.GD1C2015.ejecutarSentenciaSinRetorno(consulta);

         }
        
        public string eliminarElRol(String id_rol)
        {
            string mensaje;
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("Execute " + ConstantesBD.proc_eliminar_Rol + " @Id_Rol = '" + id_rol + "';");
            lector.Read();
            mensaje = lector["MENSAJE"].ToString();
            lector.Close();
            return mensaje;
        }

        public SqlDataReader buscarRoles(List<String> filtros)
        {
            String sentenciaSQL = "select * from " + ConstantesBD.t_roles;
            IEnumerator enumerador = filtros.GetEnumerator();
            if (enumerador.MoveNext())
            {
                sentenciaSQL = sentenciaSQL + " where " + enumerador.Current;

                while (enumerador.MoveNext())
                {
                    sentenciaSQL = sentenciaSQL + " and " + enumerador.Current;
                }
            }
            return this.GD1C2015.ejecutarSentenciaConRetorno(sentenciaSQL);
        }
    }
}
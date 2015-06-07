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
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select [ROL_ID], [ROL_DESC], [ROL_ESTADO], [Func_Extraer], [Func_Transferir], [Func_Depositar], [Func_ABM_Roles], [Func_ABM_Clientes], [Func_ABM_Usuarios], [Func_ABM_Cuentas] from " +
                ConstantesBD.t_roles + " where [ROL_ID] = '" + id_Rol + "';");
            return lector;
        }

        public void insertarUnRol(Rol_Bean rol)
        {
            String sentencia = "insert into " + ConstantesBD.t_roles + " (Rol_Desc, Rol_Estado, Func_Extraer, Func_Transferir, Func_Depositar, Func_ABM_Roles, Func_ABM_Clientes, Func_ABM_Usuarios, Func_ABM_Cuentas) values ('" +
            rol.getRol_Desc() + "', '" +
            rol.getRol_Estado() + "', '" +
            rol.getRol_Func_Extraer() + "', '" +
            rol.getRol_Func_Transferir() + "', '" +
            rol.getRol_Func_Depositar() + "', '" +
            rol.getRol_Func_ABM_Roles() + "', '" +
            rol.getRol_Func_ABM_Clientes() + "', '" +
            rol.getRol_Func_ABM_Usuarios() + "', '" +
            rol.getRol_Func_ABM_Cuentas() + "')";

            this.GD1C2015.ejecutarSentenciaSinRetorno(sentencia);
        }

        public void modificarUnRol(Rol_Bean rol)
        {
            String consulta = "update " + ConstantesBD.t_roles + " set " +
                            "Rol_Desc = '" + rol.getRol_Desc() + "', " +
                            "Rol_Estado = '" + rol.getRol_Estado() + "', " +
                            "Func_Extraer = '" + rol.getRol_Func_Extraer() + "', " +
                            "Func_Transferir = '" + rol.getRol_Func_Transferir() + "', " +
                            "Func_Depositar = '" + rol.getRol_Func_Depositar() + "', " +
                            "Func_ABM_Roles = '" + rol.getRol_Func_ABM_Roles() + "', " +
                            "Func_ABM_Clientes = '" + rol.getRol_Func_ABM_Clientes() + "', " +
                            "Func_ABM_Usuarios = '" + rol.getRol_Func_ABM_Usuarios() + "', " +
                            "Func_ABM_Cuentas = '" + rol.getRol_Func_ABM_Cuentas() + "' " +
                            "where Rol_Id = '" + rol.getRol_Id() + "'";

            this.GD1C2015.ejecutarSentenciaSinRetorno(consulta);

         }
        
        public void eliminarElRol(String id_rol)
        {
            if (id_rol == "1")
            { MessageBox.Show("No se puede eliminar este Rol - Administrador", "Atención!", MessageBoxButtons.OK); }
            else
            {
                try
                {
                    List<SqlParameter> parametros = new List<SqlParameter>();
                    SqlParameter parametro;

                    parametro = new SqlParameter("@Id_Rol", id_rol);
                    parametros.Add(parametro);
                    this.GD1C2015.ejecutarProcedimiento(ConstantesBD.proc_eliminar_Rol, parametros).Close();
                    MessageBox.Show("El Rol se ha eliminado correctamente", "Atención!", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("No ha sido posible eliminar el Rol", "Atención!", MessageBoxButtons.OK);
                }
            }
            
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
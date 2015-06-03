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

        public void insertaUnRol(Rol_Bean rol)
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("AQUI DEBE IR EL PROCEDIMIENTO QUE INSERTA ROLES");
            if (lector.HasRows)
            { MessageBox.Show("El Rol " + rol.getRol_Desc() + " fue creado correctamente", "Atención!", MessageBoxButtons.OK); }
            else
            { MessageBox.Show("Ha ocurrido un error al crearse el Rol", "Atención!", MessageBoxButtons.OK); }
        }

        public void eliminarElRol(String id_rol)
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("AQUI DEBE IR EL PROCEDIMIENTO QUE ELIMINA EL ROL");
            if (lector.HasRows)
            { MessageBox.Show("El Rol se ha eliminado correctamente", "Atención!", MessageBoxButtons.OK); }
            else
            { MessageBox.Show("Ha ocurrido un error al eliminar el Rol", "Atención!", MessageBoxButtons.OK); }
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
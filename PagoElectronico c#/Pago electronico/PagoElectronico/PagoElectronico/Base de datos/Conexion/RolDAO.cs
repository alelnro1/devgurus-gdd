using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Conexion;
using System.Data.SqlClient;
using PagoElectronico.Excepciones;
using System.Security.Cryptography;

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
    }
}
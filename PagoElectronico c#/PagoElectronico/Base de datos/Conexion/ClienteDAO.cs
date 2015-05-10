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
    class ClienteDAO : BadBoysDAO
    {
        public ClienteDAO()
        {
            this.iniciar();
        }

/*        public void validarClienteExiste(Cliente_Bean cliente)
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select [Usuarios_Pass], [Usuarios_Rol], [Usuarios_Estado] from " + ConstantesBD.t_usuarios +
            " where [Usuarios_Name] = '" + usuario.getUser_Name() + "';");
            if (!lector.HasRows)
            {
            }
            
        }*/

        protected void lanzarExcepcion(String mensajeError, SqlDataReader lector)
        {
            lector.Close();
            throw new ValidacionErroneaUsuarioException(mensajeError);
        }
        
        protected void lanzarMensaje(String mensaje, SqlDataReader lector)
        {
            lector.Close();
            MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK);
        }
    }
}
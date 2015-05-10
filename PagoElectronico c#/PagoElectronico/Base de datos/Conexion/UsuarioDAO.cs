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
    class UsuarioDAO : BadBoysDAO
    {
        public UsuarioDAO()
        {
            this.iniciar();
        }

        public String encriptar(String cadena)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(cadena);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
        
        public void validarCamposVacios(String campoARevisar, String mensajeError)
        {
            if (campoARevisar.Trim() == "")
                throw new ValidacionErroneaClienteException(mensajeError);
        }

        public void validarUsuario(Usuario_Bean usuario)
        {

            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select [Usuarios_Pass], [Usuarios_Rol], [Usuarios_Estado] from " + ConstantesBD.t_usuarios +
            " where [Usuarios_Name] = '" + usuario.getUser_Name() + "';");
            if (!lector.HasRows)
            { this.lanzarMensaje("El usuario ingresado no existe", lector); }
            else
            {   lector.Read();
            if (!lector["Usuarios_Estado"].Equals("Habilitado"))
            { this.lanzarMensaje("El usuario ingresado no se encuntra habilitado, por favor contacte al administrador", lector); }
            else
            {
                if (!((lector["Usuarios_Rol"].ToString().Equals("2")) & (usuario.getUser_Rol() == "Cliente")))
                { this.lanzarMensaje("El usuario no posee el rol especificado", lector); }
                else
                {
                    if (lector["Usuarios_Pass"].ToString() != usuario.getUser_Pass())
                    {
                        this.lanzarMensaje("La contraseña ingresada es incorrecta", lector);
                        //this.GD1C2015.ejecutarSentenciaSinRetorno("EXECUTE Almacenar_Login_Incorrecto '" + usuario.getUser_Name() +
                        //"', '" + usuario.getUser_Pass() + "' GO");
                    }
                    else
                    {
                        MessageBox.Show("Usuario " + usuario.getUser_Name() + " logeado correctamente", "Atención!", MessageBoxButtons.OK);
                    }
                }
            }
            }
        }

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
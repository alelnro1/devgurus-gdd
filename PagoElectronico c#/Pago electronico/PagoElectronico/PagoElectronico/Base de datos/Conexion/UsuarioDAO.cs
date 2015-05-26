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
    class UsuarioDAO : DevgurusDAO
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
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select [Usuario_Pass], [Usuario_Rol], [Usuario_Estado] from " + ConstantesBD.t_usuarios +
            " where [Usuario_Name] = '" + usuario.getUser_Name() + "';");
            if (!lector.HasRows)
            { this.lanzarMensaje("El usuario ingresado no existe", lector); }
            else
            {   lector.Read();
            if (!lector["Usuario_Estado"].Equals("Habilitado"))
            { this.lanzarMensaje("El usuario ingresado no se encuntra habilitado, por favor contacte al administrador", lector); }
            else
            {
                if (lector["Usuario_Rol"].ToString() != usuario.getUser_Rol())
                { this.lanzarMensaje("El usuario no posee el rol especificado", lector); }
                else
                {
                    if (lector["Usuario_Pass"].ToString() != usuario.getUser_Pass())
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

        public string cargarUsuario(Usuario_Bean usuario)
        {
 /*         ESTE METODO DEBERIA HACER UN INSERT EN LA TABLA USUARIOS CON ESTADO "PENDIENTE"
            Y NECESITO QUE ME DEVUELVA EL ID DEL USUARIO QUE SE CREO!! TRIGGER DE CABEZA   
            ADEMAS ES NECESARIOS METER ESE ID EN USUARIO_BEAN MEDIANTE SETUSER_ID*/
            return "beta";
        }

        public bool existeNombreDeUsuario(String nombreDeUsuario)
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select [Usuario_Name] from " + ConstantesBD.t_usuarios +
            " where Usuario_Name = '" + nombreDeUsuario + "';");
            if (lector.HasRows) { lector.Close(); return true; }
            else { lector.Close(); return false; };
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
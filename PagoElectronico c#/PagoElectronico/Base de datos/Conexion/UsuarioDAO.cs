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

        public bool validarUsuario(Usuario_Bean usuario, String nombre_Rol)
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("EXECUTE logearse @rol = '"+nombre_Rol+"', @usuario = '"+usuario.getUser_Name()+"', @password = '"+usuario.getUser_Pass()+"';");
            lector.Read();
            if (lector["MENSAJE"].Equals("No existe"))
            {   MessageBox.Show("El Usuario " + usuario.getUser_Name() + " no existe.", "Atención!", MessageBoxButtons.OK);
                lector.Close();
                return false;}
            if (lector["MENSAJE"].Equals("No rol valido"))
            { MessageBox.Show("El Usuario " + usuario.getUser_Name() + " no posee el rol especificado.", "Atención!", MessageBoxButtons.OK);
                lector.Close();
                return false;}
            if (lector["MENSAJE"].Equals("Bloqueado"))
            { MessageBox.Show("El Usuario " + usuario.getUser_Name() + " se encuentra bloqueado.", "Atención!", MessageBoxButtons.OK);
                lector.Close(); 
                return false;}
            if (lector["MENSAJE"].Equals("Incorrecto"))
            { MessageBox.Show("La contraseña ingresada es incorrecta.", "Atención!", MessageBoxButtons.OK);
                lector.Close();
                return false;}
            if (lector["MENSAJE"].Equals("Correcto"))
            {
                MessageBox.Show("El Usuario " + usuario.getUser_Name() + " se ha logeado correctamente.", "Atención!", MessageBoxButtons.OK);
                lector.Close();
                return true;
            }
            return false;
        }

        public bool cargarUsuario(Usuario_Bean usuario)
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("EXECUTE insertarNuevoUsuario @nombre = '" + usuario.getUser_Name() +
            "', @password = '" + usuario.getUser_Pass() + "', @rol = '" + usuario.getUser_Rol() +
            "', @pregunta = '" + usuario.getUser_PreguntaSecreta() + "', @respuesta = '" + 
            usuario.getUser_RespuestaSecreta() + "'");
            if (lector.HasRows)
            {return true;}
            else 
            {return false;}
        }

        public bool existeNombreDeUsuario(String nombreDeUsuario)
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select [Usuarios_Name] from " + ConstantesBD.t_usuarios +
            " where Usuarios_Name = '" + nombreDeUsuario + "';");
            if (lector.HasRows) { lector.Close(); return true; }
            else { lector.Close(); return false; }
        }

        public string dameElId(Usuario_Bean usuario)
        {
            string id_Usuario;
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select [Usuarios_Id] from " + ConstantesBD.t_usuarios +
            " where Usuarios_Name = '" + usuario.getUser_Name() + "';");
            lector.Read();
            id_Usuario = lector["Usuarios_Id"].ToString();
            lector.Close();
            return id_Usuario;
        }
    }
}
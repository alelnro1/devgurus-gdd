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
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("EXECUTE " + ConstantesBD.proc_logearse + " @rol = '" + nombre_Rol + "', @usuario = '" + usuario.getUser_Name() + "', @password = '" + usuario.getUser_Pass() + "';");
            lector.Read();
            if (lector["MENSAJE"].Equals("Inactivo"))
            {
                MessageBox.Show("El Rol seleccionado se encuenta Inactivo.", "Atención!", MessageBoxButtons.OK);
                lector.Close();
                return false;
            }
            if (lector["MENSAJE"].Equals("No aprobado"))
            {   MessageBox.Show("El Usuario " + usuario.getUser_Name() + " no ha sido aprobado por el administrador.", "Atención!", MessageBoxButtons.OK);
                lector.Close();
                return false;}
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
            lector.Close();
            return false;
        }

        public bool cargarUsuario(Usuario_Bean usuario)
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("EXECUTE " + ConstantesBD.proc_nuevo_Usuario + " @nombre = '" + usuario.getUser_Name() +
            "', @password = '" + usuario.getUser_Pass() + "', @rol = '" + usuario.getUser_Rol() +
            "', @pregunta = '" + usuario.getUser_PreguntaSecreta() + "', @respuesta = '" + 
            usuario.getUser_RespuestaSecreta() + "', @estado = 'Pendiente';");
            if (lector.HasRows)
            { lector.Close(); return true; }
            else
            { lector.Close(); return false; }
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

        public bool primerArranque()
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select [Login_Auditoria_Id] from " + ConstantesBD.t_login_auditoria);
            if (lector.HasRows) { lector.Close(); return false; }
            else { lector.Close(); return true; }
        }

        public int cantidadDeUsuarios()
        {
            string nro;
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select COUNT(*) TOTAL from " + ConstantesBD.t_usuarios);
            if (lector.HasRows)
            {
                lector.Read();
                nro = (lector["TOTAL"].ToString());
                lector.Close();
                return Int32.Parse(nro);
            }
            return 0;
        }

        public void encriptameLosCampos(int user_Id, string password, string rtaSecreta)
        {
            this.GD1C2015.ejecutarSentenciaSinRetorno("update " + ConstantesBD.t_usuarios +
                " set Usuarios_Pass = '" + password + "', Usuarios_RespuestaSecreta = '" +
                rtaSecreta + "' where Usuarios_Id = '" + user_Id + "'");
        }

        public SqlDataReader devolvemeElUsuario(int id_Usuario)
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select * from " + ConstantesBD.t_usuarios + " where Usuarios_Id = '" + id_Usuario + "';");
            return lector;
        }

        public SqlDataReader obtenerUsuarios()
        {
            String sql = "SELECT Usuarios_Id,Usuarios_Name,Usuarios_Estado FROM " + ConstantesBD.t_usuarios;
            return this.GD1C2015.ejecutarSentenciaConRetorno(sql);
        }

        internal void insertame_rol_X_usuario(string id_usuario, string rol_descripcion)
        {
            string sql;
            sql = "exec DEVGURUS.insertar_Nuevo_rol_a_usuario "+id_usuario + ",'" +rol_descripcion + "'";
            this.GD1C2015.ejecutarSentenciaSinRetorno(sql);
        }

        internal void habilitacion_user(string id_usuario, string valor)
        {
            string sql;
            sql = "UPDATE " + ConstantesBD.t_usuarios + " SET Usuarios_Estado = '" + valor + "' WHERE Usuarios_Id = " + id_usuario;
            this.GD1C2015.ejecutarSentenciaSinRetorno(sql);
        }

        internal void actualizar_monto_tipo_de_cuenta(string monto, string tipo_cuenta)
        {
            string sql;
            sql = "update DEVGURUS.Tipo_De_Cuentas SET Tipo_De_Cuentas_Costo = " + monto + " where Tipo_De_Cuentas_Nombre = '" + tipo_cuenta + "'";
            this.GD1C2015.ejecutarSentenciaSinRetorno(sql);
        }
    }
}
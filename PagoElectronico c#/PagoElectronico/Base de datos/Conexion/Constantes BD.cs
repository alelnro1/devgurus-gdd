using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.BaseDeDatos.Conexion
{
    abstract class ConstantesBD
    {
        public static String fechaSistema;
        public static String Param_Conexion_urlServidor;
        public static String Param_Conexion_usuario;
        public static String Param_Conexion_contraseña;
        public static String Param_Conexion_nombreBD;
        public static String t_usuarios = "dbo.Usuarios";
        public static String t_roles = "dbo.Roles";
        public static String t_cuentas = "dbo.Cuentas";
        public static String t_clientes = "dbo.Clientes";
        public static String t_paises = "dbo.paises";
        public static String t_tipos_cuentas = "dbo.Tipo_De_Cuentas";
        public static String t_tipo_de_moneda = "dbo.Tipo_De_Moneda";

        public static String proc_eliminar_Rol = "dbo.eliminar_Rol";

        // Recibe una fecha en formato DD/MM/AAAA y lo convierte a formato de BD: AAAAMMDD 00:00:00.00
        public static String cambiarFormatoFecha(String fecha)
        {
            String fechaConFormato = "";
            char[] delimitadores = { '/' };

            string[] palabras = fecha.Split(delimitadores);

            foreach (string s in palabras)
            {
                fechaConFormato = s + fechaConFormato;
            }

            return fechaConFormato + " 00:00:00.00";
        }
    }
}

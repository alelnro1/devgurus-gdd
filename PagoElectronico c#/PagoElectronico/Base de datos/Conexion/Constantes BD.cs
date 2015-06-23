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
        public static String t_usuarios = "DEVGURUS.Usuarios";
        public static String t_roles = "DEVGURUS.Roles";
        public static String t_cuentas = "DEVGURUS.Cuentas";
        public static String t_clientes = "DEVGURUS.Clientes";
        public static String t_paises = "DEVGURUS.paises";
        public static String t_tipos_cuentas = "DEVGURUS.Tipo_De_Cuentas";
        public static String t_tipo_de_moneda = "DEVGURUS.Tipo_De_Moneda";
        public static String t_tipo_doc = "DEVGURUS.Tipo_De_Doc";


        public static String proc_eliminar_Rol = "DEVGURUS.eliminar_Rol";
        public static String proc_eliminar_Cuenta = "DEVGURUS.eliminar_Cuenta";
        public static String proc_eliminar_Cliente = "DEVGURUS.eliminar_Cliente";

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

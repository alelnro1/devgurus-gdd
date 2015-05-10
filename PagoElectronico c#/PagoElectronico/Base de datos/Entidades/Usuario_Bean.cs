using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.BaseDeDatos.Conexion
{
    public class Usuario_Bean
    {
        private static String user_Name;
        private static String user_Pass;
        private static String user_Rol;
        private static String user_PreguntaSec;
        private static String user_RtaSec;

        public String getUser_Name()
        {   return Usuario_Bean.user_Name;}

        public String setUser_Name(String user_Name)
        { return Usuario_Bean.user_Name = user_Name; }

        public String getUser_Pass()
        {   return Usuario_Bean.user_Pass;}

        public String setUser_Pass(String user_Pass)
        { return Usuario_Bean.user_Pass = user_Pass; }

        public String getUser_Rol()
        {   return Usuario_Bean.user_Rol;}

        public String setUser_Rol(String user_Rol)
        { return Usuario_Bean.user_Rol = user_Rol; }

        public static String getUser_PreguntaSecreta()
        {   return Usuario_Bean.user_PreguntaSec;}

        public static String setUser_PreguntaSecreta(String user_PreguntaSec)
        { return Usuario_Bean.user_PreguntaSec = user_PreguntaSec; }

        public static String getUser_RespuestaSecreta()
        {   return Usuario_Bean.user_RtaSec;}
        
        public static String serUser_RespuestaSecreta(String user_RtaSec)
        {   return Usuario_Bean.user_RtaSec = user_RtaSec;}
    }
}
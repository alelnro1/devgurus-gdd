using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.BaseDeDatos.Conexion
{
    public class Rol_Bean
    {
        private static String rol_Id;
        private static String rol_Desc;
        private static String rol_Estado;

        public String getRol_Id()
        { return Rol_Bean.rol_Id; }

        public String setRol_Id(String rol_Id)
        { return Rol_Bean.rol_Id = rol_Id; }

        public String getRol_Desc()
        { return Rol_Bean.rol_Desc; }

        public String setRol_Desc(String rol_Desc)
        { return Rol_Bean.rol_Desc = rol_Desc; }

        public String getRol_Estado()
        { return Rol_Bean.rol_Estado; }

        public String setRol_Estado(String rol_Estado)
        { return Rol_Bean.rol_Estado = rol_Estado; }
    }
}

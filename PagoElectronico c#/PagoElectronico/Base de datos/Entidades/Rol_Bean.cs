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
        private static String rol_Func_Extraer;
        private static String rol_Func_Transferir;
        private static String rol_Func_Depositar;
        private static String rol_Func_ABM_Roles;
        private static String rol_Func_ABM_Cuentas;
        private static String rol_Func_ABM_Clientes;
        private static String rol_Func_ABM_Usuarios;
        private static String rol_Func_Asoc_Tarjeta;

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

        public String getRol_Func_Extraer()
        { return Rol_Bean.rol_Func_Extraer; }

        public String setRol_Func_Extraer(String rol_Func_Extraer)
        { return Rol_Bean.rol_Func_Extraer = rol_Func_Extraer; }

        public String getRol_Func_Transferir()
        { return Rol_Bean.rol_Func_Transferir; }

        public String setRol_Func_Transferir(String rol_Func_Transferir)
        { return Rol_Bean.rol_Func_Transferir = rol_Func_Transferir; }

        public String getRol_Func_Depositar()
        { return Rol_Bean.rol_Func_Depositar; }

        public String setRol_Func_Depositar(String rol_Func_Depositar)
        { return Rol_Bean.rol_Func_Depositar = rol_Func_Depositar; }

        public String getRol_Func_ABM_Roles()
        { return Rol_Bean.rol_Func_ABM_Roles; }

        public String setRol_Func_ABM_Roles(String rol_Func_ABM_Roles)
        { return Rol_Bean.rol_Func_ABM_Roles = rol_Func_ABM_Roles; }

        public String getRol_Func_ABM_Cuentas()
        { return Rol_Bean.rol_Func_ABM_Cuentas; }

        public String setRol_Func_ABM_Cuentas(String rol_Func_ABM_Cuentas)
        { return Rol_Bean.rol_Func_ABM_Cuentas = rol_Func_ABM_Cuentas; }

        public String getRol_Func_ABM_Clientes()
        { return Rol_Bean.rol_Func_ABM_Clientes; }

        public String setRol_Func_ABM_Clientes(String rol_Func_ABM_Clientes)
        { return Rol_Bean.rol_Func_ABM_Clientes = rol_Func_ABM_Clientes; }

        public String getRol_Func_ABM_Usuarios()
        { return Rol_Bean.rol_Func_ABM_Usuarios; }

        public String setRol_Func_ABM_Usuarios(String rol_Func_ABM_Usuarios)
        { return Rol_Bean.rol_Func_ABM_Usuarios = rol_Func_ABM_Usuarios; }

        public String setRol_Func_Asoc_Tarjeta(String rol_Func_Asoc_Tarjeta)
        { return Rol_Bean.rol_Func_Asoc_Tarjeta = rol_Func_Asoc_Tarjeta; }

        public String getRol_Func_Asoc_Tarjeta()
        { return Rol_Bean.rol_Func_Asoc_Tarjeta; }
    }
}

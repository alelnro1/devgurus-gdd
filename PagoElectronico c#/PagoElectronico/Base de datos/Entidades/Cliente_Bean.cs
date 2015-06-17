using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.BaseDeDatos.Conexion
{
    public class Cliente_Bean
    {
        private static String cliente_Id;
        private static String cliente_Name;
        private static String cliente_Apell;
        private static String cliente_TipoDoc;
        private static String cliente_NroDoc;
        private static String cliente_Pais;
        private static String cliente_Calle;
        private static String cliente_Nro;
        private static String cliente_Piso;
        private static String cliente_Dpto;
        private static String cliente_FecNac;
        private static String cliente_Mail;
        private static String cliente_IdUser;
        private static String cliente_Nacionalidad;
        private static String cliente_localidad;

        /// <summary>
        /// //////////GETTERS/
        /// </summary>
        /// <returns></returns>

        public String getCliente_localidad()
        { return Cliente_Bean.cliente_localidad; }


        public String getCliente_Id()
        { return Cliente_Bean.cliente_Id; }

        public String setCliente_Id(String cliente_Id)
        { return Cliente_Bean.cliente_Id = cliente_Id; }

        public String getCliente_Name()
        { return Cliente_Bean.cliente_Name; }

        public String setCliente_Name(String cliente_Name)
        { return Cliente_Bean.cliente_Name = cliente_Name; }

        public String getCliente_Apell()
        { return Cliente_Bean.cliente_Apell; }

        public String setCliente_Apell(String cliente_Apell)
        { return Cliente_Bean.cliente_Apell = cliente_Apell; }

        public String getCliente_TipoDoc()
        { return Cliente_Bean.cliente_TipoDoc; }

        public String setCliente_TipoDoc(String cliente_TipoDoc)
        { return Cliente_Bean.cliente_TipoDoc = cliente_TipoDoc; }

        public String getCliente_NroDoc()
        { return Cliente_Bean.cliente_NroDoc; }

        public String getCliente_Nacionalidad()
        { return Cliente_Bean.cliente_Nacionalidad; }


        /// <summary>
        /// /////////SETERS//////////
        /// </summary>
        /// <param name="cliente_NroDoc"></param>
        /// <returns></returns>

        public String setCliente_NroDoc(String cliente_NroDoc)
        { return Cliente_Bean.cliente_NroDoc = cliente_NroDoc; }

        public String getCliente_Pais()
        { return Cliente_Bean.cliente_Pais; }

        public String setCliente_Pais(String cliente_Pais)
        { return Cliente_Bean.cliente_Pais = cliente_Pais; }

        public String getCliente_Calle()
        { return Cliente_Bean.cliente_Calle; }

        public String setCliente_Calle(String cliente_Calle)
        { return Cliente_Bean.cliente_Calle = cliente_Calle; }


        public String setCliente_localidad(String cliente_localidad)
        { return Cliente_Bean.cliente_localidad = cliente_localidad; }

        public String getCliente_Nro()
        { return Cliente_Bean.cliente_Nro; }

        public String setCliente_Nro(String cliente_Nro)
        { return Cliente_Bean.cliente_Nro = cliente_Nro; }

        public String getCliente_Piso()
        { return Cliente_Bean.cliente_Piso; }

        public String setCliente_Piso(String cliente_Piso)
        { return Cliente_Bean.cliente_Piso = cliente_Piso; }

        public String getCliente_Dpto()
        { return Cliente_Bean.cliente_Dpto; }

        public String setCliente_Dpto(String cliente_Dpto)
        { return Cliente_Bean.cliente_Dpto = cliente_Dpto; }

        public String getCliente_FecNac()
        { return Cliente_Bean.cliente_FecNac; }

        public String setCliente_FecNac(String cliente_FecNac)
        { return Cliente_Bean.cliente_FecNac = cliente_FecNac; }

        public String getCliente_Mail()
        { return Cliente_Bean.cliente_Mail; }

        public String setCliente_Mail(String cliente_Mail)
        { return Cliente_Bean.cliente_Mail = cliente_Mail; }

        public String getCliente_IdUser()
        { return Cliente_Bean.cliente_IdUser; }

        public String setCliente_IdUser(String cliente_IdUser)
        { return Cliente_Bean.cliente_IdUser  = cliente_IdUser; }

        public String setCliente_Nacionalidad(String cliente_Nacionalidad)
        { return Cliente_Bean.cliente_Nacionalidad = cliente_Nacionalidad; }

    }
}
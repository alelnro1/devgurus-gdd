using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.BaseDeDatos.Conexion
{
    public class Cliente_Bean
    {
        private static String cliente_Name;
        private static String cliente_Apell;
        private static String cliente_TipoDoc;
        private static String cliente_NroDoc;
        private static String cliente_Pais;
        private static String cliente_Calle;
        private static String cliente_Nro;
        private static String cliente_Piso;
        private static String cliente_Dpto;
        private static String cliente_FecNec;
        private static String cliente_Mail;

        public String getCliente_Name()
        {   return Cliente_Bean.cliente_Name;}

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

        public String getCliente_FecNec()
        { return Cliente_Bean.cliente_FecNec; }

        public String setCliente_FecNec(String cliente_FecNec)
        { return Cliente_Bean.cliente_FecNec = cliente_FecNec; }

        public String getCliente_Mail()
        { return Cliente_Bean.cliente_Mail; }

        public String setCliente_Mail(String cliente_Mail)
        { return Cliente_Bean.cliente_Mail = cliente_Mail; }
    }
}
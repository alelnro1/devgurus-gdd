using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.BaseDeDatos.Conexion
{
    public class Cuenta_Bean
    {
        private static String nro_cuenta;
        private static String estado;
        private static String pais_origen;
        private static String tipo_moneda;
        private static String fecha_apertura;
        private static String tipo_cuenta;
        private static String pais_asignado;
        private static String fecha_creacion;
        private static String fecha_cierre;
        private static String cliente;
        private static String tarjeta;
        private static String saldo;

        public String get_nro_cuenta()
        {
            return Cuenta_Bean.nro_cuenta;
        }

        public String get_pais_origen()
        {
            return Cuenta_Bean.pais_origen;
        }

        public String get_tipo_moneda()
        {
            return Cuenta_Bean.tipo_moneda;
        }




        public String get_fecha_apertura()
        {
            return Cuenta_Bean.fecha_apertura;
        }



        public String get_tipo_cuenta()
        {
            return Cuenta_Bean.tipo_cuenta;
        }

        public String get_estado()
        {
            return Cuenta_Bean.estado;
        }

        public String get_paisAsignado()
        {
            return pais_asignado;
        }

        public String get_fec_Creacion()
        {
            return fecha_creacion;
        }

        public String get_fec_Cierre()
        {
            return fecha_cierre;
        }

        public String get_Cliente()
        {
            return cliente;
        }
        public String get_Tarjeta()
        {
            return tarjeta;
        }
        public String get_Saldo()
        {
            return saldo;
        }

        //empiezan los set..son 11//

        public String set_nro_cuenta(String nro_cuenta)
        {
            return Cuenta_Bean.nro_cuenta = nro_cuenta;
        }

        public String set_pais_origen(String pais_origen)
        {
            return Cuenta_Bean.pais_origen = pais_origen;
        }

        public String set_tipo_moneda(String tipo_moneda)
        {
            return Cuenta_Bean.tipo_moneda = tipo_moneda;
        }


        public String set_fecha_apertura(String fecha_apertura)
        {
            return Cuenta_Bean.fecha_apertura = fecha_apertura;
        }

        public String set_tipo_cuenta(String tipo_cuenta)
        {
            return Cuenta_Bean.tipo_cuenta = tipo_cuenta;
        }


        public String set_estado(String estado)
        {
            return Cuenta_Bean.estado = estado;
        }


        public String set_paisAsignado(String valor_pais_asignado)
        {
            return pais_asignado = valor_pais_asignado;
        }

        public String set_fec_Creacion(String valor_fecha_creacion)
        {
            return fecha_creacion = valor_fecha_creacion;
        }

        public String set_fec_Cierre(String valor_fecha_cierre)
        {
            return fecha_cierre = valor_fecha_cierre;
        }

        public String set_Cliente(String valor_cliente)
        {
            return cliente = valor_cliente;
        }
        public String set_Tarjeta(String valor_tarjeta)
        {
            return tarjeta = valor_tarjeta;
        }

        public String set_Saldo(String valor_saldo)
        {
            return tarjeta = valor_saldo;
        }



    }
}
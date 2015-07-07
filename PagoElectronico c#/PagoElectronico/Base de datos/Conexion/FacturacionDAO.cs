using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Conexion;
using System.Data.SqlClient;
using PagoElectronico.Excepciones;
using System.Security.Cryptography;
using System.Collections;

namespace PagoElectronico.BaseDeDatos.Conexion
{
    class FacturacionDAO : DevgurusDAO
    {
        public FacturacionDAO()
        {
            this.iniciar();
        }

        public SqlDataReader obtenerTransaccionesPendientes(String cliente_id)
        {
            String sql = "SELECT * FROM " + ConstantesBD.t_transaccion_pendiente + " WHERE Transaccion_Pendiente_Cliente = " + cliente_id ;
            return this.GD1C2015.ejecutarSentenciaConRetorno(sql);
        }
        public string generar_factura(string id_cliente)
        {
            String sql = "exec DEVGURUS.generar_Nueva_Factura " + id_cliente;
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno(sql);
            lector.Read();
            string aux = lector["Numero_Factura"].ToString();
            lector.Close();
            return aux;
        }
        public void asignar_item(string nro_transaccion, string id_factura)
        {
            String sql = "exec DEVGURUS.asignar_Item_A_Factura " + id_factura + ", " + nro_transaccion;
            this.GD1C2015.ejecutarSentenciaSinRetorno(sql);
        }



        public void habilitar_cuenta(String cliente_id_para_facturacion)
        {
            string sentenciaSQLParaAveriguarLasCuentasDelCliente = "select Cuenta_Nro from DEVGURUS.Cuentas where Cuenta_Cliente = " + cliente_id_para_facturacion;
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno(sentenciaSQLParaAveriguarLasCuentasDelCliente);
            while(lector.Read()){
            
            String Cuenta_Cliente = lector["Cuenta_Nro"].ToString();
            string sql = "exec habilitarCuentaConCondicion " + Cuenta_Cliente;
            this.GD1C2015.ejecutarSentenciaSinRetorno(sql);
            
            }
            lector.Close();
        }
    }
}

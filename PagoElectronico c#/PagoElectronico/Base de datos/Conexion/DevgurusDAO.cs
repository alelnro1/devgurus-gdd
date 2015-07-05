using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;
using PagoElectronico.Conexion;
using PagoElectronico.Excepciones;
using System.Security.Cryptography;
using System.Collections;

namespace PagoElectronico.Conexion
{
    abstract class DevgurusDAO
    {
        protected SQLServerBD GD1C2015;

        protected void iniciar()
        {
            this.GD1C2015 = new SQLServerBD(PagoElectronico.BaseDeDatos.Conexion.ConstantesBD.Param_Conexion_urlServidor,
                PagoElectronico.BaseDeDatos.Conexion.ConstantesBD.Param_Conexion_usuario,
                PagoElectronico.BaseDeDatos.Conexion.ConstantesBD.Param_Conexion_contraseña,
                PagoElectronico.BaseDeDatos.Conexion.ConstantesBD.Param_Conexion_nombreBD, "true", "15");
            this.GD1C2015.abrir();
        }

        public void setearEnComboBoxElParametroDeLaColumnaDeLaTabla(ComboBox combo, String parametro, String columna, String tabla)
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select [" + columna + "] from " + tabla);
            while (lector.Read())
            { combo.Items.Add(lector[parametro]); }
            lector.Close();
        }

        public bool tarjetaEstaVencida(String tarjeta, String cliente_id)
        {
            Nullable<DateTime> fecha_vencimiento = null;
            String sql = "SELECT Tarjeta_Fecha_Vencimiento FROM DEVGURUS.Tarjetas WHERE Tarjeta_Digitos_Visibles = '" + tarjeta + "' and Tarjeta_Cliente = " + cliente_id;
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno(sql);

            while (lector.Read())
            {
                fecha_vencimiento = (DateTime)lector["Tarjeta_Fecha_Vencimiento"];
            }

            lector.Close();

            if (fecha_vencimiento > DateTime.Now.Date)
            {
                return true;
            }
            else { return false; }

        }

        public bool tieneSuficienteSaldo(String cuenta_origen, String importe)
        {
            bool tieneSaldo = false;
            String sql = "SELECT Cuenta_Saldo FROM DEVGURUS.Cuentas WHERE Cuenta_Nro = '" + cuenta_origen + "' ";
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno(sql);

            while (lector.Read())
            {
                if (float.Parse(lector["Cuenta_Saldo"].ToString()) >= float.Parse(importe))
                {
                    tieneSaldo = true;
                }
            }

            lector.Close();

            return tieneSaldo;
        }

        public bool numeroEsFloat(String numero)
        {
            float n;
            return float.TryParse(numero, out n);
        }

        public bool numeroEsInt(String numero)
        {
            Int64 n;
            return Int64.TryParse(numero, out n);
        }

        public bool importeEsMayorANumero(String importe, String numero)
        {
            return (float.Parse(importe) > float.Parse(numero));
        }

        public void lanzarMensaje(String mensaje, SqlDataReader lector)
        {
            lector.Close();
            MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK);
        }

        public void tieneCincoTransaccionesEntoncesInhabilitarCuenta(String cuenta)
        {
            String sql = "SELECT COUNT(*) AS transaccionesPendientes FROM DEVGURUS.Transaccion_Pendiente WHERE Transaccion_Pendiente_Cuenta_Nro = '" + cuenta + "' AND Transaccion_Pendiente_Importe > 0";
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno(sql);

            while (lector.Read())
            {
                if (int.Parse(lector["transaccionesPendientes"].ToString()) > 5)
                {
                    String sql_actualizar = "UPDATE DEVGURUS.Cuentas SET Cuenta_Estado = 'Inhabilitado' WHERE Cuenta_Nro = '" + cuenta + "'";
                    this.GD1C2015.ejecutarSentenciaSinRetorno(sql);
                }
            }

            lector.Close();
        }

        public void finalizar()
        {
            this.GD1C2015.cerrar();
        }
    }
}

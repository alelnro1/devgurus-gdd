using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;
using PagoElectronico.Conexion;

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

        public bool tarjetaEstaVencida(String tarjeta)
        {
            Nullable<DateTime> fecha_vencimiento = null;
            String sql = "SELECT Tarjeta_Fecha_Vencimiento FROM Tarjetas WHERE Tarjeta_Nro = '" + tarjeta + "' ";
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno(sql);

            while (lector.Read())
            {
               fecha_vencimiento = (DateTime) lector["Tarjeta_Fecha_Vencimiento"];
            }

            lector.Close();

            if (fecha_vencimiento > DateTime.Now.Date)
            {
                return true;
            }

            return false;
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

        public bool importeEsMayorANumero(string importe, string numero)
        {
            return (float.Parse(importe) > float.Parse(numero));
        }

        public void lanzarMensaje(String mensaje, SqlDataReader lector)
        {
            lector.Close();
            MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK);
        }

        public void finalizar()
        {
            this.GD1C2015.cerrar();
        }
    }
}

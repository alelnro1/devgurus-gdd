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
    class CuentaDAO : DevgurusDAO
    {
        public CuentaDAO()
        {
            this.iniciar();
        }

        public void validarCamposVacios(String campoARevisar, String mensajeError)
        {
            if (campoARevisar.Trim() == "")
                throw new ValidacionErroneaClienteException(mensajeError);
        }


        public void altaCuenta(Cuenta_Bean cuenta)
        {
            
            String Cuenta_Nro = "";
            String Cuenta_Fecha_Creacion = "";
            string pais = cuenta.get_pais_origen();
            string tipo_moneda_nombre = cuenta.get_tipo_moneda();
            string tipo_de_cuenta = cuenta.get_tipo_cuenta();

            String SentenciaSQL = "exec DEVGURUS.insertarEnCuentas" + "'" + pais.Trim() + "'"


              + "," + cuenta.get_estado()
              + ",'" + tipo_moneda_nombre.Trim()
              + "','" + tipo_de_cuenta.Trim()
              + "'," + cuenta.get_paisAsignado()
              + "," + cuenta.get_fec_Cierre()
              + "," + cuenta.get_Cliente();

            SqlDataReader cuentaSQL = this.GD1C2015.ejecutarSentenciaConRetorno(SentenciaSQL);

      
            Cuenta_Nro = dameElDatoDeLaCuentaSQL(cuentaSQL, "Cuenta_Nro");
            //Cuenta_Fecha_Creacion = dameElDatoDeLaCuentaSQL(cuentaSQL, "Cuenta_Fec_Cre");

            MessageBox.Show("Cuenta creada correctamente " + " Nro Cuenta: " + Cuenta_Nro + " \n \n Con la fecha : " + DateTime.Now.ToString(), "Atención!", MessageBoxButtons.OK);

        }

      
        public String dameElDatoDeLaCuentaSQL(SqlDataReader cuentaSQL, String parametro)
        {
            String datoCuenta = "";
            
            while (cuentaSQL.Read())
            {
                datoCuenta = cuentaSQL[parametro].ToString();
              
            }
            cuentaSQL.Close();

            return datoCuenta;
        }



        public SqlDataReader buscarCuentas(List<String> filtros)
        {

            String sentenciaSQL = " select CU.Cuenta_Nro, TC.Tipo_De_Cuentas_Nombre, PO.Pais_Nombre Pais_Origen,PA.Pais_Nombre Pais_Asignado,  CU.Cuenta_Estado, TM.Tipo_De_Moneda_Nombre, CU.Cuenta_Fec_Cre, CU.Cuenta_Fec_Cierre,CU.Cuenta_Cliente, CU.Cuenta_Saldo FROM " + ConstantesBD.t_cuentas + " CU, " + ConstantesBD.t_paises + " PO ,  " + ConstantesBD.t_tipos_cuentas + " TC, " + ConstantesBD.t_tipo_de_moneda + " TM, " + ConstantesBD.t_paises + " PA";
           
            IEnumerator enumerador = filtros.GetEnumerator();
            sentenciaSQL = sentenciaSQL + " where CU.Cuenta_Tipo = TC.Tipo_De_Cuentas_Id and CU.Cuenta_PaisOrigen = PO.Pais_Id and CU.Cuenta_Moneda= TM.Tipo_De_Moneda_Id and CU.Cuenta_PaisAsignado = PA.Pais_Id";
            if (enumerador.MoveNext())
            {
                sentenciaSQL = sentenciaSQL + " and " + enumerador.Current;

                while (enumerador.MoveNext())
                {
                    sentenciaSQL = sentenciaSQL + " and " + enumerador.Current;
                }

            }
            return this.GD1C2015.ejecutarSentenciaConRetorno(sentenciaSQL);
        }



        public void setearEnComboBoxElParametroDeLaColumnaDeLaTabla(ComboBox combo, String parametro, String columna, String tabla)
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select [" + columna + "] from " + tabla);
            while (lector.Read())
            { combo.Items.Add(lector[parametro]); }
            lector.Close();
        }

        public SqlDataReader dameLaCuenta(String id_Cuenta)
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select [Cuenta_Nro], [Cuenta_Estado], [Cuenta_Moneda], [Cuenta_Tipo], [Cuenta_PaisOrigen], [Cuenta_PaisAsignado], [Cuenta_Fec_Cre], [Cuenta_Fec_Cierre], [Cuenta_Cliente] ,[Cuenta_Saldo] from " +
                ConstantesBD.t_cuentas + " where [Cuenta_Nro] = '" + id_Cuenta + "';");
            return lector;
        }

        public void modificarUnaCuenta(Cuenta_Bean una_cuenta)
        {
            String consulta = "EXEC DEVGURUS.actualizar_tipo_de_cuenta '" + una_cuenta.get_tipo_cuenta().Trim() + "'," + una_cuenta.get_nro_cuenta().Trim() + ";";
            this.GD1C2015.ejecutarSentenciaSinRetorno(consulta);
        }

        public void eliminarLaCuenta(String id_Cuenta)
        {
            if (id_Cuenta == "1")
            { MessageBox.Show("No se puede eliminar este Rol - Administrador", "Atención!", MessageBoxButtons.OK); }
            else
            {
                try
                {
                    List<SqlParameter> parametros = new List<SqlParameter>();
                    SqlParameter parametro;

                    parametro = new SqlParameter("@Id_Cuenta", id_Cuenta);
                    parametros.Add(parametro);
                    this.GD1C2015.ejecutarProcedimiento(ConstantesBD.proc_eliminar_Cuenta, parametros).Close();
                    MessageBox.Show("La Cuenta se ha eliminado correctamente", "Atención!", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("No ha sido posible eliminar la Cuenta", "Atención!", MessageBoxButtons.OK);
                }
            }
        }
    }
}



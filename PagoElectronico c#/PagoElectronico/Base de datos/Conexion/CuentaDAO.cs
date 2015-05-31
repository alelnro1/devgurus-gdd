using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Conexion;
using System.Data.SqlClient;
using PagoElectronico.Excepciones;
using System.Security.Cryptography;

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
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno(
                "INSERT INTO " + ConstantesBD.t_cuentas +
               "([Cuenta_Estado],[Cuenta_Moneda],[Cuenta_Tipo],[Cuenta_PaisOrigen],[Cuenta_PaisAsignado],[Cuenta_Fec_Cre],[Cuenta_Fec_Cierre],[Cuenta_Cliente]) VALUES ("
           
           + cuenta.get_estado()
           + "," + cuenta.get_tipo_moneda()
           + "," + cuenta.get_tipo_cuenta()
           + "," + cuenta.get_pais_origen()
           + "," + cuenta.get_paisAsignado()
           + "," + cuenta.get_fec_Creacion()
           + "," + cuenta.get_fec_Cierre()
           + "," + cuenta.get_Cliente() + ");");

               
            
            {
                this.lanzarMensaje("La cuenta fue creada correctamente", lector);
                //this.GD1C2015.ejecutarProcedimiento("EXECUTE Almacenar_Login_Incorrecto '" + usuario.getUser_Name() +
                //"', '" + usuario.getUser_Pass() + "' GO", );
                MessageBox.Show("Cuenta " + cuenta.get_nro_cuenta() + " creada correctamente", "Atención!", MessageBoxButtons.OK);
            }
        }

        
        public SqlDataReader dameLosPaises()
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select [Pais_Nombre] from " + ConstantesBD.t_paises + ";");
            return lector;

        }


        public SqlDataReader dameLosTiposDeCuenta()
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select [Tipo_De_Cuentas_Nombre] from " + ConstantesBD.t_tipos_cuentas + ";");
            return lector;
        }

        protected void lanzarMensaje(String mensaje, SqlDataReader lector)
        {
            lector.Close();
            MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK);
        }
        public SqlDataReader dameLosTiposDeMonedas()
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select [Tipo_De_Moneda_Nombre] from " + ConstantesBD.t_tipo_de_moneda + ";");
            return lector;

        }


       /* public String dameElIdDelPais(String Pais_Nombre)
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select [Pais_Id] from dbo.Paises where Pais_Nombre = '"+ Pais_Nombre +"'");

            return lector;
        }*/
       

       }

     
}



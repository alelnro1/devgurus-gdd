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

        public SqlDataReader dameLosCamposDeLaTabla(String campos, String tabla)
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select"+ campos +"from " + tabla + ";");
            return lector;

        }

        public void crearObjetoConIdNombre(String columna_id, String columna_nombre, String tabla,System.Windows.Forms.ComboBox comboBox)
        { //creamos un objeto con un id y un nombre en String, de una tabla determinada.
            String columna_Id_nombre = columna_id + columna_nombre;
            SqlDataReader lector = this.dameLosCamposDeLaTabla(columna_Id_nombre, tabla); //pedimos de la tabla el id y el nombre
            ObjetoIdNombre[] vector_objeto_id_nombre;
            int i = 0;

            while (lector.Read()) //recorrimos la tabla fila x fila  para poder obtener el nombre y el id de cada fila
            {
                vector_objeto_id_nombre[i] = new ObjetoIdNombre(); //creamos el objeto en el vector para luego asignarle el id y el nombre
                vector_objeto_id_nombre[i].set_nombre(lector[columna_id].ToString()); //asignamos el id como un STRING en el objeto  que vamos a asignarle al vector
                vector_objeto_id_nombre[i].set_nombre(lector[columna_nombre].ToString()); //asignamos el nombre como un STRING en el objeto que vamos a asignarle al vector
                comboBox.Items.Add(vector_objeto_id_nombre[i]);
                i++;
            }
            lector.Close();
        }


     


         

       /* public String dameElIdDelPais(String Pais_Nombre)
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select [Pais_Id] from dbo.Paises where Pais_Nombre = '"+ Pais_Nombre +"'");

            return lector;
        }*/
       

       }

     
}



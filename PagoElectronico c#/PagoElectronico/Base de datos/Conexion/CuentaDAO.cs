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
            string pais = cuenta.get_pais_origen();
            string tipo_moneda_nombre = cuenta.get_tipo_moneda();
            string tipo_de_cuenta = cuenta.get_tipo_cuenta();
            this.GD1C2015.ejecutarSentenciaSinRetorno("exec insertarEnCuentas" + "'" + pais.Trim() + "'"


              + "," + cuenta.get_estado()
              + ",'" + tipo_moneda_nombre.Trim()
              + "','" + tipo_de_cuenta.Trim()
              + "'," + cuenta.get_paisAsignado()
              
              + "," + cuenta.get_fec_Cierre()
              + "," + cuenta.get_Cliente()
              + "," + cuenta.get_Tarjeta()
              
              );


            MessageBox.Show("Cuenta " + cuenta.get_nro_cuenta() + " creada correctamente", "Atención!", MessageBoxButtons.OK);

        }

        protected void lanzarMensaje(String mensaje, SqlDataReader lector)
        {
            lector.Close();
            MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK);
        }
      

        public SqlDataReader dameLosCamposDeLaTabla(String campos, String tabla)
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select" + campos + "from " + tabla + ";");
            return lector;

        }
        /*
        public void crearObjetoConIdNombre(String columna_id, String columna_nombre, String tabla,System.Windows.Forms.ComboBox comboBox)
        { //creamos un objeto con un id y un nombre en String, de una tabla determinada.
            String columna_Id_nombre = "([" + columna_id + "]),([" + columna_nombre +"])";
            SqlDataReader lector = this.dameLosCamposDeLaTabla(columna_Id_nombre, tabla); //pedimos de la tabla el id y el nombre
            int tamanio_total = 0;
            while (lector.Read()) //recorrimos la tabla fila x fila  para poder obtener el nombre y el id de cada fila
            {
                tamanio_total++;
            }
            lector.Close();

            
            ObjetoIdNombre[] vector_objeto_id_nombre = new ObjetoIdNombre[tamanio_total];
            int i = 0;

            lector = this.dameLosCamposDeLaTabla(columna_Id_nombre, tabla); //pedimos de la tabla el id y el nombre
            while (lector.Read()) //recorrimos la tabla fila x fila  para poder obtener el nombre y el id de cada fila
            {
                vector_objeto_id_nombre[i] = new ObjetoIdNombre(); //creamos el objeto en el vector para luego asignarle el id y el nombre
                vector_objeto_id_nombre[i].set_id(lector[columna_id].ToString()); //asignamos el id como un STRING en el objeto  que vamos a asignarle al vector
                vector_objeto_id_nombre[i].set_nombre(lector[columna_nombre].ToString()); //asignamos el nombre como un STRING en el objeto que vamos a asignarle al vector
                comboBox.Items.Add(vector_objeto_id_nombre[i].get_id());
                i++;
            }
            lector.Close();
        }
        */


        public void usarProcedureAsignarIdPais(String Pais_Nombre)
        {
            this.GD1C2015.ejecutarSentenciaSinRetorno("exec asignarIdAlPaisAntesDeInsertar2 ' China'");
        }




        public SqlDataReader buscarCuentas(List<String> filtros)
        {   

            String sentenciaSQL = " select CU.Cuenta_Nro, PA.Pais_Id Pais_Origen, PA.Pais_Nombre from Cuentas CU, Paises PA ";
            
            IEnumerator enumerador = filtros.GetEnumerator();
            if (enumerador.MoveNext())
            {
                sentenciaSQL = sentenciaSQL + " where " + enumerador.Current;

                sentenciaSQL = sentenciaSQL + "and CU.Cuenta_PaisOrigen = PA.Pais_Id"; 
                
                while (enumerador.MoveNext())
                {
                    sentenciaSQL = sentenciaSQL + " and " + enumerador.Current;
                }
            }
            return this.GD1C2015.ejecutarSentenciaConRetorno(sentenciaSQL);
        }


        public String dameElIdDelPais(String nombrePais)
        {   
            SqlDataReader idPaisDeCuentaSql = this.GD1C2015.ejecutarSentenciaConRetorno("exec dameIdDelPais " + "'" + nombrePais + "'");
            String idPais;

            idPaisDeCuentaSql.Read();
            idPais = idPaisDeCuentaSql.ToString();
                       
            return idPais;

        }

        public SqlDataReader ejecutarMetodo() {

            return this.GD1C2015.ejecutarSentenciaConRetorno("select CU.Cuenta_Nro, PA.Pais_Id, PA.Pais_Nombre from Cuentas CU, Paises PA ");
        }

    }


}



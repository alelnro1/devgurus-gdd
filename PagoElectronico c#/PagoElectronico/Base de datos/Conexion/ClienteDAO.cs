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
    class ClienteDAO : DevgurusDAO
    {
        public ClienteDAO()
        {
            this.iniciar();
        }

        public bool validarClienteExiste(Cliente_Bean cliente)
        {
            SqlDataReader lector = this.GD1C2015.ejecutarSentenciaConRetorno("select [Cliente_Id] from " + ConstantesBD.t_clientes +
            " where [Cliente_Nombre] = '" + cliente.getCliente_Name() + "' and [Cliente_Apellido] = '"
                                          + cliente.getCliente_Apell() + "' and [Cliente_Nro_Doc] = '"
                                          + cliente.getCliente_NroDoc() + "' and (convert(varchar(10),[Cliente_Fecha_Nac],103)) = '"
                                          + cliente.getCliente_FecNac() + "';");
                if (lector.HasRows)
                   {
                       cliente.setCliente_Id(lector["Cliente_Id"].ToString());
                       lector.Close(); 
                       return true;
                   }
                   else
                   {
                       lector.Close(); 
                       return false;
                   }
         }

        public void asignaleElUsuario(Cliente_Bean cliente)
        {
 //     AQUI SE DEBE HACER UN UPDATE DEL CLIENTE QUE TOMA COMO PARAMETRO Y CARGARLE EL ID DE USUARIO
 //     BUSCAR POR NUMERO DE DOCUMENTO (INFALIBLE)
        }

        protected void lanzarExcepcion(String mensajeError, SqlDataReader lector)
        {
            lector.Close();
            throw new ValidacionErroneaUsuarioException(mensajeError);
        }

        protected void lanzarMensaje(String mensaje, SqlDataReader lector)
        {
            lector.Close();
            MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK);
        }
    }
}
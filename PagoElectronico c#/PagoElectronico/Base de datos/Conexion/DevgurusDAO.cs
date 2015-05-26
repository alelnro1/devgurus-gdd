using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
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

        public void finalizar()
        {
            this.GD1C2015.cerrar();
        }
    }
}

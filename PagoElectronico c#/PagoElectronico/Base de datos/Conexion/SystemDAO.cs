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
    class SystemDAO : DevgurusDAO
    {
        public SystemDAO()
        {
            this.iniciar();
        }

        public void setearLaFechaDelSistema()
        {
            String sql = "Delete from DEVGURUS.Fecha_Sistema";
            this.GD1C2015.ejecutarSentenciaSinRetorno(sql);
            String sql2 = "Insert into DEVGURUS.Fecha_Sistema values('" + ConstantesBD.fechaSistema + "');";
            this.GD1C2015.ejecutarSentenciaSinRetorno(sql2);
        }
    }
}
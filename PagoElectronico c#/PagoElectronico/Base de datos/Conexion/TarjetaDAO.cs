﻿using System;
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
    class TarjetaDAO : DevgurusDAO
    {
        public TarjetaDAO()
        {
            this.iniciar();
        }
        public SqlDataReader buscarTarjetas()
        {
            ClienteDAO cli =new ClienteDAO();

            String sentenciaSQL = "select Tarjeta_Id, Tarjeta_Digitos_Visibles,Tarjeta_Emisor_Desc,Tarjeta_Fecha_Emision,Tarjeta_Fecha_Vencimiento FROM Tarjetas,Clientes  where Tarjeta_Cliente = Cliente_Id";

           
            return this.GD1C2015.ejecutarSentenciaConRetorno(sentenciaSQL);
        }


    }
}
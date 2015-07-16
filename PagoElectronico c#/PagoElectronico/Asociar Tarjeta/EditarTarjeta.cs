using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PagoElectronico.Excepciones;
using System.Security.Cryptography;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using PagoElectronico.Conexion;
using PagoElectronico.BaseDeDatos.Conexion;


namespace PagoElectronico
{
    public partial class EditarTarjeta : Form
    {
        Cliente_Bean cliente_id_para_editar_tarjetas;
        TarjetaDAO tarjeta_dao;
        private string id_tarjeta_editar;
        public EditarTarjeta(string id_tarjeta,string cliente_id)
        {
            id_tarjeta_editar = id_tarjeta;
            cliente_id_para_editar_tarjetas = new Cliente_Bean();
            tarjeta_dao = new TarjetaDAO();
            cliente_id_para_editar_tarjetas.setCliente_Id(cliente_id);
            InitializeComponent();
            dateTimePicker_vencimiento.MinDate = tarjeta_dao.dame_fecha_sql();
        }

        private void guardar_Click(object sender, EventArgs e)
        {

            tarjeta_dao.actualizar_tarjeta(id_tarjeta_editar, cliente_id_para_editar_tarjetas.getCliente_Id(), dateTimePicker_vencimiento.Text);
            MessageBox.Show("Se edito correctamente la fecha de vencimiento de la tarjeta seleccionada", "Atención!", MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }
    }
}

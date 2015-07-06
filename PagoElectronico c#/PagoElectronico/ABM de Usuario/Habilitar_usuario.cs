using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using PagoElectronico.BaseDeDatos.Conexion;
using PagoElectronico.Conexion;
using System.Data.SqlClient;
using PagoElectronico.Excepciones;
using System.Security.Cryptography;


namespace PagoElectronico
{
    public partial class Habilitar_usuario : Form
    {
        private UsuarioDAO usuario_DAO;
        public Habilitar_usuario()
        {
            usuario_DAO = new UsuarioDAO();
            InitializeComponent();
            this.cargar_data_grid();
            
        }
        private void cargar_data_grid()
        {
            data_usuarios.Rows.Clear();
            SqlDataReader lector = usuario_DAO.obtenerUsuarios();
            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[3];
            while (lector.Read())
            {
                columnas[0] = lector["Usuarios_Id"];
                columnas[1] = lector["Usuarios_Name"];
                columnas[2] = lector["Usuarios_Estado"];

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(data_usuarios, columnas);
            }
            lector.Close();
            data_usuarios.Rows.AddRange(filas.ToArray());
        }


        private void habilitar_desabilitar_user(object sender, EventArgs e, string valor)
        {

            try
            {
                DataGridViewRow fila = data_usuarios.SelectedRows[0];

                    String id_usuario;

                    id_usuario = (fila.Cells[0].Value.ToString());
                    string nombre_usuario = (fila.Cells[1].Value.ToString());
                    usuario_DAO.habilitacion_user(id_usuario,valor);
                    this.cargar_data_grid();
                    MessageBox.Show("Se cambio el estado del Usuario id: "+ id_usuario + " a: " + valor, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                
            }
            catch { MessageBox.Show("Debe seleccionar el Usuario antes de aceptar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            habilitar_desabilitar_user(sender, e, "Habilitado");
        }

        private void Baja_Click(object sender, EventArgs e)
        {
            habilitar_desabilitar_user(sender, e, "Deshabilitado");
        }
    }
}
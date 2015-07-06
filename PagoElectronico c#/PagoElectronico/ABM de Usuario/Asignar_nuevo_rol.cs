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
    public partial class Asignar_nuevo_rol : Form
    {
        private UsuarioDAO usuario_DAO;
        public Asignar_nuevo_rol()
        {
            usuario_DAO = new UsuarioDAO();
            InitializeComponent();
            this.cargar_data_grid();
            usuario_DAO.setearEnComboBoxElParametroDeLaColumnaDeLaTabla(comboBox1, "Rol_Desc", "Rol_Desc", ConstantesBD.t_roles);

        }
        private void cargar_data_grid()
        {
            data_usuarios.Rows.Clear();
            SqlDataReader lector = usuario_DAO.obtenerUsuarios();
            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[2];
            while (lector.Read()) { 
                columnas[0] = lector["Usuarios_Id"];
                columnas[1] = lector["Usuarios_Name"];

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(data_usuarios, columnas);
            }
            lector.Close();
            data_usuarios.Rows.AddRange(filas.ToArray());
         }



        private void Asignar_nuevo_rol_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try { DataGridViewRow fila = data_usuarios.SelectedRows[0]; 
            
            if (comboBox1.Text != "")
            {
                String id_usuario;

                id_usuario = (fila.Cells[0].Value.ToString());
                string nombre_usuario = (fila.Cells[1].Value.ToString());

                try
                {
                    usuario_DAO.insertame_rol_X_usuario(id_usuario, comboBox1.Text);
                    MessageBox.Show("Se le asigno el rol " + comboBox1.Text + " al usuario " + nombre_usuario, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("El usuario ya tiene asignado ese rol", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else { MessageBox.Show("Debe seleccionar un rol", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }}
        catch { MessageBox.Show("Debe seleccionar el Usuario antes de aceptar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }
}

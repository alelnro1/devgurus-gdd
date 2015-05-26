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
    public partial class Login : Form
    {
        private Usuario_Bean usuario;
        private UsuarioDAO usuarioDAO;
        private RolDAO rolDAO;
        
        public Login()
        {
            leerArchivoConfiguracion(); 
            InitializeComponent();
            usuarioDAO = new UsuarioDAO();
            usuario = new Usuario_Bean();
            rolDAO = new RolDAO();
            setearRolesEnComboBox();
        }

        private void leerArchivoConfiguracion()
        {
            try
            {
                using (StreamReader sr = new StreamReader("ArchivoDeConfiguracion.txt"))
                {
                    string line, textoArchivo = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        textoArchivo = textoArchivo + line + "\n";
                    }
                    obtenerFechayParametrosConexion(textoArchivo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PC Banking", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void obtenerFechayParametrosConexion(String archivoConfig)
        {
            char[] delimitadores = { ' ', ',', '.', '\t', '\n' };

            string[] palabras = archivoConfig.Split(delimitadores);

            ConstantesBD.fechaSistema = palabras[2];
            ConstantesBD.Param_Conexion_urlServidor = palabras[9];
            ConstantesBD.Param_Conexion_usuario = palabras[14];
            ConstantesBD.Param_Conexion_contraseña = palabras[17];
            ConstantesBD.Param_Conexion_nombreBD = palabras[24];
        }

        private void setearRolesEnComboBox()
        {
            SqlDataReader lector = rolDAO.dameLosNombresDeLosRoles();
            while (lector.Read())
                {   combo_Roles.Items.Add(lector["Rol_Desc"]);  }
            lector.Close();
        }

        private void boton_Salir_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("Desea salir de la aplicación?", "PC Banking", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (salir == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void button_Ingreso_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(text_User.Text)) ||
               (String.IsNullOrEmpty(text_Pass.Text)) ||
               (String.IsNullOrEmpty(combo_Roles.Text)))
            {   DialogResult alerta = MessageBox.Show("Debe completar los campos antes de continuar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                usuario.setUser_Name(text_User.Text);
                usuario.setUser_Pass(text_Pass.Text);
            // AQUI SE DEBEN AGREGAR FUTUROS ROLES COMO CONDICIONES, PERO SE DEBE AUTOMATIZAR
                if (combo_Roles.Text == "Cliente")
                { usuario.setUser_Rol("1"); };
                if (combo_Roles.Text == "Administrador")
                { usuario.setUser_Rol("2"); };
                usuarioDAO.validarUsuario(usuario);
            } 
            MenuPrincipal nuevoMenu = new MenuPrincipal();
            nuevoMenu.Show();
            this.Hide();
         }

        private void boton_NewCliente_Click(object sender, EventArgs e)
        {
            NewUser nuevoUsuario = new NewUser(usuario);
            nuevoUsuario.Show();
            this.Hide();
        }
   }
}
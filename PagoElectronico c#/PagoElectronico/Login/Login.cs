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
        private ClienteDAO clienteDAO;
        private RolDAO rolDAO;
        private SystemDAO systemaDAO;

        public Login()
        {
            leerArchivoConfiguracion();
            InitializeComponent();
            usuarioDAO = new UsuarioDAO();
            usuario = new Usuario_Bean();
            rolDAO = new RolDAO();
            clienteDAO = new ClienteDAO();
            systemaDAO = new SystemDAO();
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
            { combo_Roles.Items.Add(lector["Rol_Desc"]); }
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
            iniciarPorPrimeraVez();
            enviarFechaDeSistema();
            string nombre_Rol;
            string id_Usuario;
            string id_Cliente;

            if ((String.IsNullOrEmpty(text_User.Text)) ||
               (String.IsNullOrEmpty(text_Pass.Text)) ||
               (String.IsNullOrEmpty(combo_Roles.Text)))
            { DialogResult alerta = MessageBox.Show("Debe completar los campos antes de continuar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                usuario.setUser_Name(text_User.Text);
                usuario.setUser_Pass(text_Pass.Text);
                usuario.setUser_Pass(usuarioDAO.encriptar(usuario.getUser_Pass()));
                nombre_Rol = combo_Roles.Text;
                if (usuarioDAO.validarUsuario(usuario, nombre_Rol))
                {
                    id_Usuario = usuarioDAO.dameElId(usuario);
                    id_Cliente = clienteDAO.dameElIdCliente(id_Usuario);
                    MenuPrincipal nuevoMenu = new MenuPrincipal(id_Cliente, id_Usuario, text_User.Text, nombre_Rol);
                    this.Hide();
                    nuevoMenu.ShowDialog();
                    Form borrar = this;
                    Login nuevoLogin = new Login();
                    nuevoLogin.ShowDialog();
                    borrar.Close();
                };
            }
        }

        private void enviarFechaDeSistema()
        {
            systemaDAO.setearLaFechaDelSistema();
        }

        private void boton_NewCliente_Click(object sender, EventArgs e)
        {
            NewUser nuevoUsuario = new NewUser(usuario);
            nuevoUsuario.Show();
            this.Hide();
        }

        private void iniciarPorPrimeraVez()
        {
            string rtaSecreta;
            string password;
            int nro_Usuarios;

            if (usuarioDAO.primerArranque())
            {
                nro_Usuarios = usuarioDAO.cantidadDeUsuarios();
                for (int user_Id = 1; user_Id <= nro_Usuarios; user_Id++)
                {
                    SqlDataReader lector = usuarioDAO.devolvemeElUsuario(user_Id);
                    lector.Read();
                    rtaSecreta = lector["Usuarios_RespuestaSecreta"].ToString();
                    password = lector["Usuarios_Pass"].ToString();
                    rtaSecreta = usuarioDAO.encriptar(rtaSecreta);
                    password = usuarioDAO.encriptar(password);
                    lector.Close();
                    usuarioDAO.encriptameLosCampos(user_Id, password, rtaSecreta);
                }
            }
        }
    }
}

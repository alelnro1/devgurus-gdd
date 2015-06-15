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
using System.Data.SqlClient;
using PagoElectronico.Excepciones;
using System.Security.Cryptography;

namespace PagoElectronico
{
    public partial class MenuPrincipal : Form
    {
        private ClienteDAO clienteDAO;
        private RolDAO rolDAO;
        private String id_Cliente_Actual;
        private String id_Usuario_Actual;
        private String nombre_rol_Actual;
        private CuentaDAO cuentaDAO;

        public MenuPrincipal(String id_Cliente, String id_Usuario, String user, String nombre_rol)
        {
            InitializeComponent();
            clienteDAO = new ClienteDAO();
            cuentaDAO = new CuentaDAO();
            rolDAO = new RolDAO();
            id_Cliente_Actual = id_Cliente;
            id_Usuario_Actual = id_Usuario;
            nombre_rol_Actual = nombre_rol;
            setearInformacion(user);
            habilitarComandos(nombre_rol);
         }

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void setearInformacion(String usuario)
        {
            if (this.id_Cliente_Actual != "") { cliente_Info.Text = clienteDAO.DameNombreApellido(this.id_Cliente_Actual); }
            else {cliente_Info.Text = " - ";};
            user_Info.Text = usuario;
            rol_Info.Text = this.nombre_rol_Actual;
        }

        private void habilitarComandos(String nombre_rol)
        {
            List<String> filtros = new List<String>();
            filtros.Add("[ROL_DESC] = '" + nombre_rol + "'");
            SqlDataReader lector = rolDAO.buscarRoles(filtros);
            lector.Read();
            if(lector["Func_ABM_Roles"].Equals("Inhabilitado"))
            {
                boton_Nuevo_Rol.Enabled = false;
                boton_Editar_rol.Enabled = false;
                groupABMroles.ForeColor = System.Drawing.Color.Gray;
            }
            if (lector["Func_ABM_Cuentas"].Equals("Inhabilitado"))
            {
                boton_Nueva_Cuenta.Enabled = false;
                boton_Editar_cuenta.Enabled = false;
                groupABMCuentas.ForeColor = System.Drawing.Color.Gray;
            }
            if (lector["Func_ABM_Clientes"].Equals("Inhabilitado"))
            {
                boton_Crear_Cliente.Enabled = false;
                boton_Editar_Cliente.Enabled = false;
                boton_eliminar_cliente.Enabled = false;
                groupBox1.ForeColor = System.Drawing.Color.Gray;
            }
            if (lector["Func_Transferir"].Equals("Inhabilitado"))
            {
                boton_trans.Enabled = false;
            }
            lector.Close();
        }

        private void boton_Salir_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("Desea cerrar la sesion actual?", "PC Banking", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (salir == DialogResult.Yes)
            {
                this.Close();
                Login nuevoLogin = new Login();
                nuevoLogin.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditRol nuevaAltaRol = new EditRol(this);
            nuevaAltaRol.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Busqueda_Rol nuevaEditarRol = new Busqueda_Rol(this);
            nuevaEditarRol.Show();
            this.Hide();
        }

        private void boton_Nueva_Cuenta_Click(object sender, EventArgs e)
        {
          // AltaCuentas nuevaCuenta = new AltaCuentas(this, this.id_Cliente_Actual);
            //nuevaCuenta.Show();
            //this.Hide();
        }

        private void boton_Editar_cuenta_Click(object sender, EventArgs e)
        {
            //BusquedaCuentas buscarCuenta = new BusquedaCuentas(this);
            //buscarCuenta.Show();
            //this.Hide();
        }

        private void boton_Crear_Cliente_Click(object sender, EventArgs e)
        {
            AltaCliente altaCliente = new AltaCliente(this);
            altaCliente.Show();
            this.Hide();
        }

        private void boton_Editar_Cliente_Click(object sender, EventArgs e)
        {
            BusquedaClientes buscador = new BusquedaClientes(this);
            buscador.ShowDialog();

            String cliente = Program.Cliente_id_seleccionado;
            EditarCliente editarCliente = new EditarCliente(cliente,this);
            editarCliente.ShowDialog();
         
        }

        private void boton_eliminar_cliente_Click(object sender, EventArgs e)
        {
            BusquedaClientes buscador = new BusquedaClientes(this);
       
            try
            {
                buscador.ShowDialog();

                String cliente = Program.Cliente_id_seleccionado;
                if (MessageBox.Show("Estas seguro que desas eliminar el Cliente?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clienteDAO.eliminarCliente(cliente);
                }
            }

            catch
            {
                MessageBox.Show("Debe seleccionar un cliente primero", "Devgurus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void boton_trans_Click(object sender, EventArgs e)
        {
            Transferencias trasferencia = new Transferencias(this.id_Cliente_Actual, this);
            trasferencia.Show();
            this.Hide();
        }
    }
}

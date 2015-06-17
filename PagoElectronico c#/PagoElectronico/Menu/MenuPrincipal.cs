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
        private Cliente_Bean cliente_bean; 
        private ClienteDAO clienteDAO;
        private RolDAO rolDAO;
        private String id_Cliente_Actual;
        private String id_Usuario_Actual;
        private String nombre_rol_Actual;
        private CuentaDAO cuentaDAO;
        
        public MenuPrincipal(String id_Cliente, String id_Usuario, String user, String nombre_rol)
        {
            InitializeComponent();
            cliente_bean = new Cliente_Bean();
            cliente_bean.setCliente_Id(id_Cliente);
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
            //else { cliente_Info.Text = " - "; }
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
                /*Login nuevoLogin = new Login();
                nuevoLogin.Show();*/
            }
        }

        private void button1_Click(object sender, EventArgs e) //BOTON DE ALTA
        {
            EditRol nuevaAltaRol = new EditRol();
            nuevaAltaRol.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e) //BOTON DE EDITAR
        {
            Busqueda_Rol nuevaEditarRol = new Busqueda_Rol();
            nuevaEditarRol.ShowDialog();
            
        }
        private string busca_cliente_dame_id()
        {
            string cliente;   
            Program.Cliente_id_seleccionado = "Quiere Volver";
            BusquedaClientes buscador = new BusquedaClientes(this);
            buscador.ShowDialog(); //Asigno el cliente o si quiere volver el mensaje en string "quiero volver"
            cliente = Program.Cliente_id_seleccionado;
            return cliente;

        }
        private void boton_Nueva_Cuenta_Click(object sender, EventArgs e)
        {
           String cliente;
           if ("Cliente" != nombre_rol_Actual)
           {
               cliente = busca_cliente_dame_id();
               if (cliente == "Quiere Volver")
               {
               }
               else //si no quiero volver le seteo un cliente, asignaselo a cliente
               {
                   AltaCuentas nuevaCuenta = new AltaCuentas(cliente);
                   nuevaCuenta.ShowDialog();
               }
           }
           else
           {

               AltaCuentas nuevaCuenta = new AltaCuentas(this.id_Cliente_Actual);
               nuevaCuenta.ShowDialog();
           }

        }

        private void boton_Editar_cuenta_Click(object sender, EventArgs e) {
            
            String cliente;
            if ("Cliente" != nombre_rol_Actual)
            {
                cliente = busca_cliente_dame_id();
                if (cliente == "Quiere Volver")
                {
                }
                else //si no quiero volver le seteo un cliente, asignaselo a cliente
                {
                    BusquedaCuentas buscarCuenta = new BusquedaCuentas(cliente);
                    buscarCuenta.ShowDialog();
                    cliente = Program.Cliente_id_seleccionado;

                }
            }
            else
            {
                cliente = cliente_bean.getCliente_Id();
                BusquedaCuentas buscarCuenta = new BusquedaCuentas(cliente);
                buscarCuenta.ShowDialog();
                cliente = Program.Cliente_id_seleccionado;
            }
        }



      

        private void boton_Crear_Cliente_Click(object sender, EventArgs e)
        {
            AltaCliente altaCliente = new AltaCliente();
            this.Hide();
            altaCliente.ShowDialog();
            this.Show();
            this.BringToFront();
        }

        private void boton_Editar_Cliente_Click(object sender, EventArgs e)
        {
            string cliente = busca_cliente_dame_id();
            if (cliente == "Quiere Volver") {             
            }
            else {
                EditarCliente editarCliente = new EditarCliente(cliente,this);
                editarCliente.ShowDialog();
            }
         
        }

        private void boton_eliminar_cliente_Click(object sender, EventArgs e)
        {
            string cliente = busca_cliente_dame_id();
            if (cliente == "Quiere Volver")
                {}
            else{
                if (MessageBox.Show("Estas seguro que desas eliminar el Cliente?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){           
                    clienteDAO = new ClienteDAO();
                    clienteDAO.eliminarCliente(cliente);
                    MessageBox.Show("Se elimino el cliente ID N°: " + cliente + " - atentamente, Devgurus ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
         }

        private void boton_trans_Click(object sender, EventArgs e)
        {
            if ("Cliente" != nombre_rol_Actual)
            {
                string cliente = busca_cliente_dame_id();
                if (cliente == "Quiere Volver")
                {
                }
                else //si no quiero volver le seteo un cliente, asignaselo a cliente
                {
                    Transferencias trasferencia = new Transferencias(cliente);//LEAAA ACA CUENTDO LO CAMBIES NO LE MANDES EL MENU EEEEE -> OK JULY
                    trasferencia.ShowDialog();
                }

            }
            else
            {
                Transferencias trasferencia = new Transferencias(this.id_Cliente_Actual);//LEAAA ACA CUENTDO LO CAMBIES NO LE MANDES EL MENU EEEEE -> OK JULY
                trasferencia.ShowDialog();
            }
        }

        private void boton_Depositar_Click(object sender, EventArgs e)
        {
             if ("Cliente" != nombre_rol_Actual)
            {
                string cliente = busca_cliente_dame_id();
                if (cliente == "Quiere Volver")
                {
                }
                else //si no quiero volver le seteo un cliente, asignaselo a cliente
                {
            Depositos altaCliente = new Depositos(cliente);           
            altaCliente.ShowDialog();
                }

            }
            else
            {
            Depositos altaCliente = new Depositos(this.id_Cliente_Actual);           
            altaCliente.ShowDialog();
            }
        }


        

        private void boton_Extraer_Click(object sender, EventArgs e)
        {
            if ("Cliente" != nombre_rol_Actual)
            {
                string cliente = busca_cliente_dame_id();
                if (cliente == "Quiere Volver")
                {
                }
                else //si no quiero volver le seteo un cliente, asignaselo a cliente
                {
                    Retiros retiro = new Retiros(cliente);
                    retiro.ShowDialog(); 
                }

            }
            else
            {
                Retiros retiro = new Retiros(this.id_Cliente_Actual);
                retiro.ShowDialog();
            }

 
        }

        private void boton_Asoc_Tarj_Click(object sender, EventArgs e)
        {
            if ("Cliente" != nombre_rol_Actual)
            {
                string cliente = busca_cliente_dame_id();
                if (cliente == "Quiere Volver")
                {
                }
                else //si no quiero volver le seteo un cliente, asignaselo a cliente
                {
                    AsociarTarjeta asociar_Tarjeta = new AsociarTarjeta(cliente);
                    asociar_Tarjeta.ShowDialog();
                }

            }
            else
            {
                AsociarTarjeta asociar_Tarjeta = new AsociarTarjeta(this.id_Cliente_Actual);
                asociar_Tarjeta.ShowDialog();
            }



        }

        private void boton_Consul_Click(object sender, EventArgs e)
        {
            if ("Cliente" != nombre_rol_Actual)
            {
                string cliente = busca_cliente_dame_id();
                if (cliente == "Quiere Volver")
                {
                }
                else //si no quiero volver le seteo un cliente, asignaselo a cliente
                {
                    ConsultarSaldo saldo = new ConsultarSaldo(cliente);
                    saldo.ShowDialog();
                }

            }
            else
            {
                ConsultarSaldo saldo = new ConsultarSaldo(this.id_Cliente_Actual);
                saldo.ShowDialog();
            }
            
        }
        private void boton_facturar_Click(object sender, EventArgs e)
        {
            if ("Cliente" != nombre_rol_Actual)
            {
                string cliente = busca_cliente_dame_id();
                if (cliente == "Quiere Volver")
                {
                }
                else //si no quiero volver le seteo un cliente, asignaselo a cliente
                {
                    Facturacion facturar = new Facturacion(cliente);
                    facturar.ShowDialog();
                }

            }
            else
            {
                Facturacion facturar = new Facturacion(this.id_Cliente_Actual);
                facturar.ShowDialog();
            }
        }
    }
    }    


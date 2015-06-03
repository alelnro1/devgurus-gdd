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
    public partial class EditarRol : Form
    {
        private Rol_Bean rol_Bean;
        private RolDAO rolDAO;
        private Form menuBusqueda;

        public EditarRol(String id_rol, Form busqueda)
        {
            InitializeComponent();
            rol_Bean = new Rol_Bean();
            rolDAO = new RolDAO();
            cargaLosDatosDelRol(id_rol);
            menuBusqueda = busqueda;
        }

        public void cargaLosDatosDelRol(String id_rol)
        {
            SqlDataReader lector = rolDAO.dameElRol(id_rol);
            lector.Read();
            rol_Name.Text = lector["ROL_DESC"].ToString();
            combo_Estado.Text = lector["ROL_ESTADO"].ToString();
            if (lector["Func_Extraer"].Equals("Habilitado")) { check_Extraer.Checked = true; };
            if (lector["Func_Transferir"].Equals("Habilitado")) { check_Transf.Checked = true; };
            if (lector["Func_Depositar"].Equals("Habilitado")) { check_Depos.Checked = true; };
            if (lector["Func_ABM_Roles"].Equals("Habilitado")) { check_ABM_Roles.Checked = true; };
            if (lector["Func_ABM_Clientes"].Equals("Habilitado")) { check_ABM_User.Checked = true; };
            if (lector["Func_ABM_Usuarios"].Equals("Habilitado")) { check_ABM_Client.Checked = true; };
            if (lector["Func_ABM_Cuentas"].Equals("Habilitado")) { check_ABM_Cuentas.Checked = true; };

        }

        private void boton_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.menuBusqueda.Enabled = true;
            this.menuBusqueda.BringToFront();
        }
    }
}

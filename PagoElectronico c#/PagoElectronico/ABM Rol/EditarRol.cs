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


        public EditarRol(String id_rol)
        {
            InitializeComponent();
            rol_Bean = new Rol_Bean();
            rolDAO = new RolDAO();
            cargaLosDatosDelRol(id_rol);

        }

        public void cargaLosDatosDelRol(String id_rol)
        {
            SqlDataReader lector = rolDAO.dameElRol(id_rol);
            lector.Read();
            comboBox1.Text = lector["ROL_DESC"].ToString();
            combo_Estado.Text = lector["ROL_ESTADO"].ToString();
            rol_Bean.setRol_Id(id_rol);
            if (lector["Func_Extraer"].Equals("Habilitado")) { check_Extraer.Checked = true; };
            if (lector["Func_Transferir"].Equals("Habilitado")) { check_Transf.Checked = true; };
            if (lector["Func_Depositar"].Equals("Habilitado")) { check_Depos.Checked = true; };
            if (lector["Func_ABM_Roles"].Equals("Habilitado")) { check_ABM_Roles.Checked = true; };
            if (lector["Func_ABM_Clientes"].Equals("Habilitado")) { check_ABM_User.Checked = true; };
            if (lector["Func_ABM_Usuarios"].Equals("Habilitado")) { check_ABM_Client.Checked = true; };
            if (lector["Func_Asociar_Tarjeta"].Equals("Habilitado")) { check_asociar_tarjeta.Checked = true; };
            if (lector["Func_ABM_Cuentas"].Equals("Habilitado")) { check_ABM_Cuentas.Checked = true; };
            lector.Close();
        }

        private void boton_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void boton_Crear_Click(object sender, EventArgs e)
        {
            rol_Bean.setRol_Desc(comboBox1.Text);
            rol_Bean.setRol_Estado(combo_Estado.Text);
            if (check_Extraer.Checked == true) rol_Bean.setRol_Func_Extraer("Habilitado");
            else { rol_Bean.setRol_Func_Extraer("Inhabilitado"); }
            if (check_Transf.Checked == true) rol_Bean.setRol_Func_Transferir("Habilitado");
            else { rol_Bean.setRol_Func_Transferir("Inhabilitado"); }
            if (check_Depos.Checked == true) rol_Bean.setRol_Func_Depositar("Habilitado");
            else { rol_Bean.setRol_Func_Depositar("Inhabilitado"); }
            if (check_ABM_Roles.Checked == true) rol_Bean.setRol_Func_ABM_Roles("Habilitado");
            else { rol_Bean.setRol_Func_ABM_Roles("Inhabilitado"); }
            if (check_ABM_User.Checked == true) rol_Bean.setRol_Func_ABM_Usuarios("Habilitado");
            else { rol_Bean.setRol_Func_ABM_Usuarios("Inhabilitado"); }
            if (check_ABM_Client.Checked == true) rol_Bean.setRol_Func_ABM_Clientes("Habilitado");
            else { rol_Bean.setRol_Func_ABM_Clientes("Inhabilitado"); }
            if (check_ABM_Cuentas.Checked == true) rol_Bean.setRol_Func_ABM_Cuentas("Habilitado");
            else { rol_Bean.setRol_Func_ABM_Cuentas("Inhabilitado"); }
            if (check_asociar_tarjeta.Checked == true) rol_Bean.setRol_Func_Asoc_Tarjeta("Habilitado");
            else { rol_Bean.setRol_Func_Asoc_Tarjeta("Inhabilitado"); }

            rolDAO.modificarUnRol(rol_Bean);
            
            this.Close();

        }
    }
}

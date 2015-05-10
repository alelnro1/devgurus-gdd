using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.BaseDeDatos.Conexion;

namespace PagoElectronico.ABM_Cuenta
{

    public partial class AltaCuentas : Form
    {   
        private Usuario_Bean usuario = new Usuario_Bean();
        private UsuarioDAO usuarioDAO;
        
        public AltaCuentas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cuentas_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void button_alta_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(text_Nro.Text)) ||
               (String.IsNullOrEmpty(text_pais_origen.Text)) ||
               (String.IsNullOrEmpty(combo_moneda.Text))||
               (String.IsNullOrEmpty(dateTime_apertura.Text))||
               (String.IsNullOrEmpty(text_tipo.Text)))

            {
                DialogResult alerta = MessageBox.Show("Debe completar los campos antes de continuar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (String.IsNullOrEmpty(text_User.Text)) { text_User.Focus(); };
                if (String.IsNullOrEmpty(text_Pass.Text)) { text_Pass.Focus(); };
                if (String.IsNullOrEmpty(combo_Roles.Text)) { combo_Roles.Focus(); };
            }
            else
            {
                usuario.setUser_Name(text_User.Text);
                usuario.setUser_Pass(text_Pass.Text);
                usuario.setUser_Rol(combo_Roles.Text);
                usuarioDAO.validarUsuario(usuario);
            }

        }

        private void text_Pais_origen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

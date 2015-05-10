using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico
{
    public partial class NewUser : Form
    {
       
        public NewUser()
        {
            InitializeComponent();
        }
        
        private ComboBox combo_Rol;
        private TextBox text_Pass;
        private TextBox text_User;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button boton_Cancelar;
        private Button button_Enviar;
        private Label label1;
        private TextBox textNombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textApellido;
        private Label label5;
        private TextBox textNroDoc;
        private Label label9;
        private Label label10;
        private ComboBox comboTipoDoc;

        private void boton_Salir_Click(object sender, EventArgs e)
        {
            DialogResult cancelar = MessageBox.Show("Desea cancelar la aplicación?", "PC Banking", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cancelar == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}

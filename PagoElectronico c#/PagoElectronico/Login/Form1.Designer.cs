namespace PagoElectronico
{
    partial class NewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboPreSec = new System.Windows.Forms.ComboBox();
            this.combo_Rol = new System.Windows.Forms.ComboBox();
            this.text_Pass = new System.Windows.Forms.TextBox();
            this.text_User = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.boton_Cancelar = new System.Windows.Forms.Button();
            this.button_Enviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textRtaSec = new System.Windows.Forms.TextBox();
            this.text_Pass_Conf = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.validation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboPreSec
            // 
            this.comboPreSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPreSec.FormattingEnabled = true;
            this.comboPreSec.Items.AddRange(new object[] {
            "¿Cual es el apellido de tu abuela materna?",
            "¿Cual es tu comida favorita?",
            "¿Como se llamaba tu primer mascota?",
            "¿Cuantos años tenias cuando diste tu primer beso?",
            "¿Cula era la marca de tu primer automovil?",
            "¿Cual es tu equipo de futbol de la infancia?"});
            this.comboPreSec.Location = new System.Drawing.Point(49, 202);
            this.comboPreSec.Name = "comboPreSec";
            this.comboPreSec.Size = new System.Drawing.Size(296, 21);
            this.comboPreSec.TabIndex = 17;
            // 
            // combo_Rol
            // 
            this.combo_Rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Rol.FormattingEnabled = true;
            this.combo_Rol.Location = new System.Drawing.Point(183, 141);
            this.combo_Rol.Name = "combo_Rol";
            this.combo_Rol.Size = new System.Drawing.Size(120, 21);
            this.combo_Rol.TabIndex = 16;
            // 
            // text_Pass
            // 
            this.text_Pass.Location = new System.Drawing.Point(184, 84);
            this.text_Pass.MaxLength = 100;
            this.text_Pass.Name = "text_Pass";
            this.text_Pass.PasswordChar = '*';
            this.text_Pass.Size = new System.Drawing.Size(120, 20);
            this.text_Pass.TabIndex = 14;
            // 
            // text_User
            // 
            this.text_User.Location = new System.Drawing.Point(184, 49);
            this.text_User.MaxLength = 100;
            this.text_User.Name = "text_User";
            this.text_User.Size = new System.Drawing.Size(121, 20);
            this.text_User.TabIndex = 13;
            this.text_User.TextChanged += new System.EventHandler(this.text_User_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(138, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Rol:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(113, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Usuario:";
            // 
            // boton_Cancelar
            // 
            this.boton_Cancelar.Location = new System.Drawing.Point(49, 313);
            this.boton_Cancelar.Name = "boton_Cancelar";
            this.boton_Cancelar.Size = new System.Drawing.Size(94, 23);
            this.boton_Cancelar.TabIndex = 21;
            this.boton_Cancelar.Text = "Cancelar";
            this.boton_Cancelar.UseVisualStyleBackColor = true;
            this.boton_Cancelar.Click += new System.EventHandler(this.boton_Salir_Click);
            // 
            // button_Enviar
            // 
            this.button_Enviar.Location = new System.Drawing.Point(322, 313);
            this.button_Enviar.Name = "button_Enviar";
            this.button_Enviar.Size = new System.Drawing.Size(94, 25);
            this.button_Enviar.TabIndex = 20;
            this.button_Enviar.Text = "Enviar solicitud";
            this.button_Enviar.UseVisualStyleBackColor = true;
            this.button_Enviar.Click += new System.EventHandler(this.button_Enviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Seleccione una pregunta secreta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(46, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 18);
            this.label11.TabIndex = 36;
            this.label11.Text = "Datos del nuevo Usuario";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(46, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 16);
            this.label12.TabIndex = 37;
            this.label12.Text = "Responda la pregunta secreta:";
            // 
            // textRtaSec
            // 
            this.textRtaSec.Location = new System.Drawing.Point(49, 265);
            this.textRtaSec.MaxLength = 255;
            this.textRtaSec.Name = "textRtaSec";
            this.textRtaSec.Size = new System.Drawing.Size(296, 20);
            this.textRtaSec.TabIndex = 18;
            // 
            // text_Pass_Conf
            // 
            this.text_Pass_Conf.Location = new System.Drawing.Point(184, 113);
            this.text_Pass_Conf.MaxLength = 100;
            this.text_Pass_Conf.Name = "text_Pass_Conf";
            this.text_Pass_Conf.PasswordChar = '*';
            this.text_Pass_Conf.Size = new System.Drawing.Size(120, 20);
            this.text_Pass_Conf.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(30, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 16);
            this.label14.TabIndex = 44;
            this.label14.Text = "Confirmar contraseña:";
            // 
            // validation
            // 
            this.validation.BackColor = System.Drawing.SystemColors.Control;
            this.validation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.validation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validation.Location = new System.Drawing.Point(311, 52);
            this.validation.Name = "validation";
            this.validation.ReadOnly = true;
            this.validation.Size = new System.Drawing.Size(134, 13);
            this.validation.TabIndex = 45;
            this.validation.TabStop = false;
            // 
            // NewUser
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(458, 358);
            this.Controls.Add(this.validation);
            this.Controls.Add(this.text_Pass_Conf);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textRtaSec);
            this.Controls.Add(this.comboPreSec);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_Rol);
            this.Controls.Add(this.text_Pass);
            this.Controls.Add(this.text_User);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boton_Cancelar);
            this.Controls.Add(this.button_Enviar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewUser";
            this.Text = "Crear Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textRtaSec;
        private System.Windows.Forms.TextBox text_Pass_Conf;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboPreSec;
        private System.Windows.Forms.TextBox validation;
    }
}
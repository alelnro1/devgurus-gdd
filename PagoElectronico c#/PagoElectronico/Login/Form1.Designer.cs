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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
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
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNroDoc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboTipoDoc = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textRtaSec = new System.Windows.Forms.TextBox();
            this.richTextTermino = new System.Windows.Forms.RichTextBox();
            this.checkTermino = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
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
            this.comboPreSec.Location = new System.Drawing.Point(28, 362);
            this.comboPreSec.Name = "comboPreSec";
            this.comboPreSec.Size = new System.Drawing.Size(296, 21);
            this.comboPreSec.TabIndex = 17;
            // 
            // combo_Rol
            // 
            this.combo_Rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Rol.FormattingEnabled = true;
            this.combo_Rol.Location = new System.Drawing.Point(162, 301);
            this.combo_Rol.Name = "combo_Rol";
            this.combo_Rol.Size = new System.Drawing.Size(120, 21);
            this.combo_Rol.TabIndex = 16;
            // 
            // text_Pass
            // 
            this.text_Pass.Location = new System.Drawing.Point(163, 244);
            this.text_Pass.Name = "text_Pass";
            this.text_Pass.PasswordChar = '*';
            this.text_Pass.Size = new System.Drawing.Size(120, 20);
            this.text_Pass.TabIndex = 14;
            // 
            // text_User
            // 
            this.text_User.Location = new System.Drawing.Point(162, 213);
            this.text_User.Name = "text_User";
            this.text_User.Size = new System.Drawing.Size(121, 20);
            this.text_User.TabIndex = 13;
            this.text_User.TextChanged += new System.EventHandler(this.text_User_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(117, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Rol:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Usuario:";
            // 
            // boton_Cancelar
            // 
            this.boton_Cancelar.Location = new System.Drawing.Point(386, 496);
            this.boton_Cancelar.Name = "boton_Cancelar";
            this.boton_Cancelar.Size = new System.Drawing.Size(94, 23);
            this.boton_Cancelar.TabIndex = 21;
            this.boton_Cancelar.Text = "Cancelar";
            this.boton_Cancelar.UseVisualStyleBackColor = true;
            this.boton_Cancelar.Click += new System.EventHandler(this.boton_Salir_Click);
            // 
            // button_Enviar
            // 
            this.button_Enviar.Location = new System.Drawing.Point(76, 495);
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
            this.label1.Location = new System.Drawing.Point(25, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Seleccione una pregunta secreta:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(101, 58);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(168, 20);
            this.textNombre.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tipo de Doc.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Datos del cliente";
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(355, 59);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(171, 20);
            this.textApellido.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(286, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Apellido:";
            // 
            // textNroDoc
            // 
            this.textNroDoc.Location = new System.Drawing.Point(330, 93);
            this.textNroDoc.Name = "textNroDoc";
            this.textNroDoc.Size = new System.Drawing.Size(133, 20);
            this.textNroDoc.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(241, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Nro. de Doc.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Fecha de Nac.";
            // 
            // comboTipoDoc
            // 
            this.comboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoDoc.FormattingEnabled = true;
            this.comboTipoDoc.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte"});
            this.comboTipoDoc.Location = new System.Drawing.Point(127, 93);
            this.comboTipoDoc.Name = "comboTipoDoc";
            this.comboTipoDoc.Size = new System.Drawing.Size(91, 21);
            this.comboTipoDoc.TabIndex = 10;
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(136, 131);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(120, 20);
            this.datePicker.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 18);
            this.label11.TabIndex = 36;
            this.label11.Text = "Datos del nuevo Usuario";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 16);
            this.label12.TabIndex = 37;
            this.label12.Text = "Responda la pregunta secreta:";
            // 
            // textRtaSec
            // 
            this.textRtaSec.Location = new System.Drawing.Point(28, 425);
            this.textRtaSec.Name = "textRtaSec";
            this.textRtaSec.Size = new System.Drawing.Size(296, 20);
            this.textRtaSec.TabIndex = 18;
            // 
            // richTextTermino
            // 
            this.richTextTermino.Location = new System.Drawing.Point(354, 260);
            this.richTextTermino.Name = "richTextTermino";
            this.richTextTermino.ReadOnly = true;
            this.richTextTermino.Size = new System.Drawing.Size(171, 175);
            this.richTextTermino.TabIndex = 40;
            this.richTextTermino.Text = resources.GetString("richTextTermino.Text");
            // 
            // checkTermino
            // 
            this.checkTermino.AutoSize = true;
            this.checkTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTermino.Location = new System.Drawing.Point(28, 457);
            this.checkTermino.Name = "checkTermino";
            this.checkTermino.Size = new System.Drawing.Size(497, 19);
            this.checkTermino.TabIndex = 19;
            this.checkTermino.Text = "Acepto los terminos y condiciones de uso dispuestos por el Administrador";
            this.checkTermino.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(364, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 20);
            this.label13.TabIndex = 42;
            this.label13.Text = "Terminos y condiciones";
            // 
            // text_Pass_Conf
            // 
            this.text_Pass_Conf.Location = new System.Drawing.Point(163, 273);
            this.text_Pass_Conf.Name = "text_Pass_Conf";
            this.text_Pass_Conf.PasswordChar = '*';
            this.text_Pass_Conf.Size = new System.Drawing.Size(120, 20);
            this.text_Pass_Conf.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 274);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 16);
            this.label14.TabIndex = 44;
            this.label14.Text = "Confirmar contraseña:";
            // 
            // validation
            // 
            this.validation.BackColor = System.Drawing.SystemColors.Control;
            this.validation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.validation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validation.Location = new System.Drawing.Point(301, 216);
            this.validation.Name = "validation";
            this.validation.ReadOnly = true;
            this.validation.Size = new System.Drawing.Size(152, 14);
            this.validation.TabIndex = 45;
            this.validation.TabStop = false;
            // 
            // NewUser
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(566, 532);
            this.Controls.Add(this.validation);
            this.Controls.Add(this.text_Pass_Conf);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.checkTermino);
            this.Controls.Add(this.richTextTermino);
            this.Controls.Add(this.textRtaSec);
            this.Controls.Add(this.comboPreSec);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.comboTipoDoc);
            this.Controls.Add(this.textNroDoc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
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

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textRtaSec;
        private System.Windows.Forms.RichTextBox richTextTermino;
        private System.Windows.Forms.CheckBox checkTermino;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox text_Pass_Conf;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboPreSec;
        private System.Windows.Forms.TextBox validation;
    }
}
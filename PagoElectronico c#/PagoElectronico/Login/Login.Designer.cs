﻿namespace PagoElectronico
{
    partial class Login
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
            this.button_Ingreso = new System.Windows.Forms.Button();
            this.boton_Salir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.boton_NewCliente = new System.Windows.Forms.Button();
            this.text_User = new System.Windows.Forms.TextBox();
            this.text_Pass = new System.Windows.Forms.TextBox();
            this.combo_Roles = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_Ingreso
            // 
            this.button_Ingreso.Location = new System.Drawing.Point(74, 204);
            this.button_Ingreso.Name = "button_Ingreso";
            this.button_Ingreso.Size = new System.Drawing.Size(94, 25);
            this.button_Ingreso.TabIndex = 6;
            this.button_Ingreso.Text = "Ingresar";
            this.button_Ingreso.UseVisualStyleBackColor = true;
            this.button_Ingreso.Click += new System.EventHandler(this.button_Ingreso_Click);
            // 
            // boton_Salir
            // 
            this.boton_Salir.Location = new System.Drawing.Point(233, 206);
            this.boton_Salir.Name = "boton_Salir";
            this.boton_Salir.Size = new System.Drawing.Size(94, 23);
            this.boton_Salir.TabIndex = 7;
            this.boton_Salir.Text = "Salir";
            this.boton_Salir.UseVisualStyleBackColor = true;
            this.boton_Salir.Click += new System.EventHandler(this.boton_Salir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "PC - Banking - Login";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Usuario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Contraseña:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Rol:";
            // 
            // boton_NewCliente
            // 
            this.boton_NewCliente.Location = new System.Drawing.Point(293, 67);
            this.boton_NewCliente.Name = "boton_NewCliente";
            this.boton_NewCliente.Size = new System.Drawing.Size(105, 23);
            this.boton_NewCliente.TabIndex = 2;
            this.boton_NewCliente.Text = "Nuevo Usuario";
            this.boton_NewCliente.UseVisualStyleBackColor = true;
            this.boton_NewCliente.Click += new System.EventHandler(this.boton_NewCliente_Click);
            // 
            // text_User
            // 
            this.text_User.Location = new System.Drawing.Point(109, 70);
            this.text_User.MaxLength = 100;
            this.text_User.Name = "text_User";
            this.text_User.Size = new System.Drawing.Size(145, 20);
            this.text_User.TabIndex = 1;
            // 
            // text_Pass
            // 
            this.text_Pass.Location = new System.Drawing.Point(109, 106);
            this.text_Pass.MaxLength = 100;
            this.text_Pass.Name = "text_Pass";
            this.text_Pass.PasswordChar = '*';
            this.text_Pass.Size = new System.Drawing.Size(145, 20);
            this.text_Pass.TabIndex = 3;
            // 
            // combo_Roles
            // 
            this.combo_Roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Roles.FormattingEnabled = true;
            this.combo_Roles.Location = new System.Drawing.Point(109, 141);
            this.combo_Roles.Name = "combo_Roles";
            this.combo_Roles.Size = new System.Drawing.Size(145, 21);
            this.combo_Roles.TabIndex = 5;
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(413, 265);
            this.Controls.Add(this.combo_Roles);
            this.Controls.Add(this.text_Pass);
            this.Controls.Add(this.text_User);
            this.Controls.Add(this.boton_NewCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boton_Salir);
            this.Controls.Add(this.button_Ingreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Ingreso;
        private System.Windows.Forms.Button boton_Salir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button boton_NewCliente;
        private System.Windows.Forms.TextBox text_User;
        private System.Windows.Forms.TextBox text_Pass;
        private System.Windows.Forms.ComboBox combo_Roles;
    }
}
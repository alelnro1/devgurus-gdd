namespace PagoElectronico
{
    partial class MenuPrincipal
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
            this.boton_Salir = new System.Windows.Forms.Button();
            this.boton_Nuevo_Rol = new System.Windows.Forms.Button();
            this.boton_Editar_rol = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boton_Salir
            // 
            this.boton_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_Salir.ForeColor = System.Drawing.Color.Maroon;
            this.boton_Salir.Location = new System.Drawing.Point(444, 290);
            this.boton_Salir.Name = "boton_Salir";
            this.boton_Salir.Size = new System.Drawing.Size(141, 34);
            this.boton_Salir.TabIndex = 5;
            this.boton_Salir.Text = "Cerrar sesion";
            this.boton_Salir.UseVisualStyleBackColor = true;
            this.boton_Salir.Click += new System.EventHandler(this.boton_Salir_Click);
            // 
            // boton_Nuevo_Rol
            // 
            this.boton_Nuevo_Rol.Location = new System.Drawing.Point(18, 29);
            this.boton_Nuevo_Rol.Name = "boton_Nuevo_Rol";
            this.boton_Nuevo_Rol.Size = new System.Drawing.Size(171, 28);
            this.boton_Nuevo_Rol.TabIndex = 6;
            this.boton_Nuevo_Rol.Text = "Crear nuevo Rol";
            this.boton_Nuevo_Rol.UseVisualStyleBackColor = true;
            this.boton_Nuevo_Rol.Click += new System.EventHandler(this.button1_Click);
            // 
            // boton_Editar_rol
            // 
            this.boton_Editar_rol.Location = new System.Drawing.Point(18, 67);
            this.boton_Editar_rol.Name = "boton_Editar_rol";
            this.boton_Editar_rol.Size = new System.Drawing.Size(171, 28);
            this.boton_Editar_rol.TabIndex = 7;
            this.boton_Editar_rol.Text = "Eliminar/Editar Rol";
            this.boton_Editar_rol.UseVisualStyleBackColor = true;
            this.boton_Editar_rol.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boton_Editar_rol);
            this.groupBox1.Controls.Add(this.boton_Nuevo_Rol);
            this.groupBox1.Location = new System.Drawing.Point(43, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 133);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Roles";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 372);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.boton_Salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_Salir;
        private System.Windows.Forms.Button boton_Nuevo_Rol;
        private System.Windows.Forms.Button boton_Editar_rol;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
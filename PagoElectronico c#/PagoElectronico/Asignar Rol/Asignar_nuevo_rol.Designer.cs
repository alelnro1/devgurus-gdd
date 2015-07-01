namespace PagoElectronico
{
    partial class Asignar_nuevo_rol
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
            this.data_usuarios = new System.Windows.Forms.DataGridView();
            this.id_de_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // data_usuarios
            // 
            this.data_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_de_usuario,
            this.nombre_usuario});
            this.data_usuarios.Location = new System.Drawing.Point(12, 12);
            this.data_usuarios.Name = "data_usuarios";
            this.data_usuarios.Size = new System.Drawing.Size(245, 290);
            this.data_usuarios.TabIndex = 0;
            // 
            // id_de_usuario
            // 
            this.id_de_usuario.HeaderText = "ID De Usuario";
            this.id_de_usuario.Name = "id_de_usuario";
            // 
            // nombre_usuario
            // 
            this.nombre_usuario.HeaderText = "Nombre De Usuario";
            this.nombre_usuario.Name = "nombre_usuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(266, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione el rol a agregar";
            // 
            // Asignar_nuevo_rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.data_usuarios);
            this.Name = "Asignar_nuevo_rol";
            this.Text = "Asignar Nuevo Rol";
            this.Load += new System.EventHandler(this.Asignar_nuevo_rol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_usuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_de_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_usuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}
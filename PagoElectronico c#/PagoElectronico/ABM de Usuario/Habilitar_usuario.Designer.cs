namespace PagoElectronico
{
    partial class Habilitar_usuario
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
            this.button1 = new System.Windows.Forms.Button();
            this.data_usuarios = new System.Windows.Forms.DataGridView();
            this.id_de_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Alta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // data_usuarios
            // 
            this.data_usuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_de_usuario,
            this.nombre_usuario,
            this.estado});
            this.data_usuarios.Location = new System.Drawing.Point(12, 12);
            this.data_usuarios.Name = "data_usuarios";
            this.data_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_usuarios.Size = new System.Drawing.Size(347, 290);
            this.data_usuarios.TabIndex = 4;
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
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // Baja
            // 
            this.Baja.Location = new System.Drawing.Point(404, 92);
            this.Baja.Name = "Baja";
            this.Baja.Size = new System.Drawing.Size(108, 43);
            this.Baja.TabIndex = 6;
            this.Baja.Text = "Baja";
            this.Baja.UseVisualStyleBackColor = true;
            this.Baja.Click += new System.EventHandler(this.Baja_Click);
            // 
            // Habilitar_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 330);
            this.Controls.Add(this.Baja);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.data_usuarios);
            this.Name = "Habilitar_usuario";
            this.Text = "Habilitar Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.data_usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView data_usuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_de_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Button Baja;
    }
}
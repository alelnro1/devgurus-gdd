namespace PagoElectronico
{
    partial class Estadistico_Cliente_Mayor_Trans
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
            this.lista_clientes = new System.Windows.Forms.DataGridView();
            this.boton_Volver = new System.Windows.Forms.Button();
            this.Info_estadistica = new System.Windows.Forms.TextBox();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auxiliar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_identificacion_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pais_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalidad_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piso_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depto_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nac_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lista_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lista_clientes
            // 
            this.lista_clientes.AllowUserToAddRows = false;
            this.lista_clientes.AllowUserToDeleteRows = false;
            this.lista_clientes.BackgroundColor = System.Drawing.Color.White;
            this.lista_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.nombre_cliente,
            this.apellido_cliente,
            this.Auxiliar,
            this.tipo_doc,
            this.nro_identificacion_cliente,
            this.pais_cliente,
            this.nacionalidad_cliente,
            this.localidad_cliente,
            this.calle_cliente,
            this.domicilio_num,
            this.piso_cliente,
            this.depto_cliente,
            this.fecha_nac_cliente,
            this.mail});
            this.lista_clientes.Location = new System.Drawing.Point(31, 60);
            this.lista_clientes.Name = "lista_clientes";
            this.lista_clientes.ReadOnly = true;
            this.lista_clientes.Size = new System.Drawing.Size(735, 185);
            this.lista_clientes.TabIndex = 223285;
            // 
            // boton_Volver
            // 
            this.boton_Volver.Location = new System.Drawing.Point(31, 260);
            this.boton_Volver.Name = "boton_Volver";
            this.boton_Volver.Size = new System.Drawing.Size(124, 27);
            this.boton_Volver.TabIndex = 223286;
            this.boton_Volver.Text = "Volver";
            this.boton_Volver.UseVisualStyleBackColor = true;
            this.boton_Volver.Click += new System.EventHandler(this.boton_Volver_Click);
            // 
            // Info_estadistica
            // 
            this.Info_estadistica.BackColor = System.Drawing.SystemColors.Control;
            this.Info_estadistica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Info_estadistica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info_estadistica.ForeColor = System.Drawing.Color.DarkRed;
            this.Info_estadistica.Location = new System.Drawing.Point(31, 23);
            this.Info_estadistica.Name = "Info_estadistica";
            this.Info_estadistica.ReadOnly = true;
            this.Info_estadistica.Size = new System.Drawing.Size(735, 15);
            this.Info_estadistica.TabIndex = 223288;
            this.Info_estadistica.TabStop = false;
            // 
            // id_cliente
            // 
            this.id_cliente.HeaderText = "Cliente Id";
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.ReadOnly = true;
            this.id_cliente.Visible = false;
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.HeaderText = "Nombre";
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.ReadOnly = true;
            // 
            // apellido_cliente
            // 
            this.apellido_cliente.HeaderText = "Apellido";
            this.apellido_cliente.Name = "apellido_cliente";
            this.apellido_cliente.ReadOnly = true;
            // 
            // Auxiliar
            // 
            this.Auxiliar.HeaderText = "Cantidad de Transacciones";
            this.Auxiliar.Name = "Auxiliar";
            this.Auxiliar.ReadOnly = true;
            // 
            // tipo_doc
            // 
            this.tipo_doc.HeaderText = "Tipo Documento";
            this.tipo_doc.Name = "tipo_doc";
            this.tipo_doc.ReadOnly = true;
            // 
            // nro_identificacion_cliente
            // 
            this.nro_identificacion_cliente.HeaderText = "Nro Identificacion";
            this.nro_identificacion_cliente.Name = "nro_identificacion_cliente";
            this.nro_identificacion_cliente.ReadOnly = true;
            // 
            // pais_cliente
            // 
            this.pais_cliente.HeaderText = "Pais";
            this.pais_cliente.Name = "pais_cliente";
            this.pais_cliente.ReadOnly = true;
            // 
            // nacionalidad_cliente
            // 
            this.nacionalidad_cliente.HeaderText = "Nacionalidad";
            this.nacionalidad_cliente.Name = "nacionalidad_cliente";
            this.nacionalidad_cliente.ReadOnly = true;
            // 
            // localidad_cliente
            // 
            this.localidad_cliente.HeaderText = "Localidad";
            this.localidad_cliente.Name = "localidad_cliente";
            this.localidad_cliente.ReadOnly = true;
            // 
            // calle_cliente
            // 
            this.calle_cliente.HeaderText = "Calle";
            this.calle_cliente.Name = "calle_cliente";
            this.calle_cliente.ReadOnly = true;
            // 
            // domicilio_num
            // 
            this.domicilio_num.HeaderText = "Nro Domicilio";
            this.domicilio_num.Name = "domicilio_num";
            this.domicilio_num.ReadOnly = true;
            // 
            // piso_cliente
            // 
            this.piso_cliente.HeaderText = "Piso";
            this.piso_cliente.Name = "piso_cliente";
            this.piso_cliente.ReadOnly = true;
            this.piso_cliente.Width = 40;
            // 
            // depto_cliente
            // 
            this.depto_cliente.HeaderText = "Depto";
            this.depto_cliente.Name = "depto_cliente";
            this.depto_cliente.ReadOnly = true;
            this.depto_cliente.Width = 40;
            // 
            // fecha_nac_cliente
            // 
            this.fecha_nac_cliente.HeaderText = "Fecha Nacimiento";
            this.fecha_nac_cliente.Name = "fecha_nac_cliente";
            this.fecha_nac_cliente.ReadOnly = true;
            // 
            // mail
            // 
            this.mail.HeaderText = "Email";
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            // 
            // Estadistico_Cliente_Mayor_Trans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 305);
            this.Controls.Add(this.Info_estadistica);
            this.Controls.Add(this.boton_Volver);
            this.Controls.Add(this.lista_clientes);
            this.Name = "Estadistico_Cliente_Mayor_Trans";
            this.Text = "Datos Estadisticos";
            ((System.ComponentModel.ISupportInitialize)(this.lista_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lista_clientes;
        private System.Windows.Forms.Button boton_Volver;
        private System.Windows.Forms.TextBox Info_estadistica;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auxiliar;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_identificacion_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacionalidad_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn piso_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn depto_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nac_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;

    }
}
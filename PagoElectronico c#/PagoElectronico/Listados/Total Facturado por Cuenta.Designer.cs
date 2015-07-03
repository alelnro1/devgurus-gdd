namespace PagoElectronico
{
    partial class Total_Facturado_por_Cuenta
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
            this.pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boton_Volver = new System.Windows.Forms.Button();
            this.Info_estadistica = new System.Windows.Forms.TextBox();
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
            this.pais,
            this.nombre_cliente});
            this.lista_clientes.Location = new System.Drawing.Point(31, 61);
            this.lista_clientes.Name = "lista_clientes";
            this.lista_clientes.ReadOnly = true;
            this.lista_clientes.Size = new System.Drawing.Size(456, 174);
            this.lista_clientes.TabIndex = 223285;
            // 
            // pais
            // 
            this.pais.HeaderText = "Tipo de Cuenta";
            this.pais.Name = "pais";
            this.pais.ReadOnly = true;
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.HeaderText = "Total facturado";
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.ReadOnly = true;
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
            this.Info_estadistica.Location = new System.Drawing.Point(3, 22);
            this.Info_estadistica.Name = "Info_estadistica";
            this.Info_estadistica.ReadOnly = true;
            this.Info_estadistica.Size = new System.Drawing.Size(516, 15);
            this.Info_estadistica.TabIndex = 223288;
            this.Info_estadistica.TabStop = false;
            // 
            // Total_Facturado_por_Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 305);
            this.Controls.Add(this.Info_estadistica);
            this.Controls.Add(this.boton_Volver);
            this.Controls.Add(this.lista_clientes);
            this.Name = "Total_Facturado_por_Cuenta";
            this.Text = "Datos Estadisticos";
            ((System.ComponentModel.ISupportInitialize)(this.lista_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lista_clientes;
        private System.Windows.Forms.Button boton_Volver;
        private System.Windows.Forms.TextBox Info_estadistica;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_cliente;

    }
}
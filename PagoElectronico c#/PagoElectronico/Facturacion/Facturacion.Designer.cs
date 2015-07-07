namespace PagoElectronico
{
    partial class Facturacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.rendirButton = new System.Windows.Forms.Button();
            this.tansacciones_pendientes_data_grid = new System.Windows.Forms.DataGridView();
            this.identicicador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volverButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tansacciones_pendientes_data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transacciones Pendientes De Facturacion";
            // 
            // rendirButton
            // 
            this.rendirButton.Location = new System.Drawing.Point(671, 344);
            this.rendirButton.Name = "rendirButton";
            this.rendirButton.Size = new System.Drawing.Size(75, 43);
            this.rendirButton.TabIndex = 2;
            this.rendirButton.Text = "Generar Factura";
            this.rendirButton.UseVisualStyleBackColor = true;
            this.rendirButton.Click += new System.EventHandler(this.rendirButton_Click);
            // 
            // tansacciones_pendientes_data_grid
            // 
            this.tansacciones_pendientes_data_grid.AllowUserToAddRows = false;
            this.tansacciones_pendientes_data_grid.AllowUserToDeleteRows = false;
            this.tansacciones_pendientes_data_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tansacciones_pendientes_data_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tansacciones_pendientes_data_grid.BackgroundColor = System.Drawing.Color.White;
            this.tansacciones_pendientes_data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tansacciones_pendientes_data_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identicicador,
            this.importe,
            this.descripcion,
            this.fecha,
            this.nro_cuenta});
            this.tansacciones_pendientes_data_grid.GridColor = System.Drawing.SystemColors.Window;
            this.tansacciones_pendientes_data_grid.Location = new System.Drawing.Point(41, 91);
            this.tansacciones_pendientes_data_grid.Name = "tansacciones_pendientes_data_grid";
            this.tansacciones_pendientes_data_grid.ReadOnly = true;
            this.tansacciones_pendientes_data_grid.RowHeadersVisible = false;
            this.tansacciones_pendientes_data_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tansacciones_pendientes_data_grid.Size = new System.Drawing.Size(705, 247);
            this.tansacciones_pendientes_data_grid.TabIndex = 0;
            this.tansacciones_pendientes_data_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOperaciones_CellContentClick);
            // 
            // identicicador
            // 
            this.identicicador.HeaderText = "Identificador";
            this.identicicador.Name = "identicicador";
            this.identicicador.ReadOnly = true;
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // nro_cuenta
            // 
            this.nro_cuenta.HeaderText = "Numero De Cuenta";
            this.nro_cuenta.Name = "nro_cuenta";
            this.nro_cuenta.ReadOnly = true;
            // 
            // volverButton
            // 
            this.volverButton.Location = new System.Drawing.Point(41, 344);
            this.volverButton.Name = "volverButton";
            this.volverButton.Size = new System.Drawing.Size(76, 43);
            this.volverButton.TabIndex = 3;
            this.volverButton.Text = "< < Volver";
            this.volverButton.UseVisualStyleBackColor = true;
            this.volverButton.Click += new System.EventHandler(this.volverButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.richTextBox1.Location = new System.Drawing.Point(275, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(471, 59);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Si desea facturar mas de una transaccion pendiente presione\"Control +Click\" en ca" +
                "da una de  las filas que desee, lugo presione \"Generar Facturación\"";
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 412);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.volverButton);
            this.Controls.Add(this.rendirButton);
            this.Controls.Add(this.tansacciones_pendientes_data_grid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Facturacion";
            this.Text = "Facturación De Costos";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tansacciones_pendientes_data_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rendirButton;
        private System.Windows.Forms.DataGridView tansacciones_pendientes_data_grid;
        private System.Windows.Forms.Button volverButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn identicicador;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_cuenta;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
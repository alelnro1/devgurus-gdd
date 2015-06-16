namespace PagoElectronico
{
    partial class AsociarTarjeta
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
            this.boton_Volver = new System.Windows.Forms.Button();
            this.boton_Desasociar = new System.Windows.Forms.Button();
            this.buttom_Asociar = new System.Windows.Forms.Button();
            this.lista_Tarjetas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lista_Tarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // boton_Volver
            // 
            this.boton_Volver.Location = new System.Drawing.Point(880, 28);
            this.boton_Volver.Name = "boton_Volver";
            this.boton_Volver.Size = new System.Drawing.Size(147, 35);
            this.boton_Volver.TabIndex = 223289;
            this.boton_Volver.Text = "Volver";
            this.boton_Volver.UseVisualStyleBackColor = true;
            this.boton_Volver.Click += new System.EventHandler(this.boton_Volver_Click_1);
            // 
            // boton_Desasociar
            // 
            this.boton_Desasociar.Location = new System.Drawing.Point(664, 140);
            this.boton_Desasociar.Name = "boton_Desasociar";
            this.boton_Desasociar.Size = new System.Drawing.Size(147, 41);
            this.boton_Desasociar.TabIndex = 223291;
            this.boton_Desasociar.Text = "Desasociar";
            this.boton_Desasociar.UseVisualStyleBackColor = true;
            // 
            // buttom_Asociar
            // 
            this.buttom_Asociar.Location = new System.Drawing.Point(664, 72);
            this.buttom_Asociar.Name = "buttom_Asociar";
            this.buttom_Asociar.Size = new System.Drawing.Size(147, 41);
            this.buttom_Asociar.TabIndex = 223292;
            this.buttom_Asociar.Text = "Asociar";
            this.buttom_Asociar.UseVisualStyleBackColor = true;
            // 
            // lista_Tarjetas
            // 
            this.lista_Tarjetas.AllowUserToAddRows = false;
            this.lista_Tarjetas.AllowUserToDeleteRows = false;
            this.lista_Tarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista_Tarjetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.lista_Tarjetas.Location = new System.Drawing.Point(23, 28);
            this.lista_Tarjetas.Name = "lista_Tarjetas";
            this.lista_Tarjetas.Size = new System.Drawing.Size(593, 213);
            this.lista_Tarjetas.TabIndex = 223293;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "TarjetaID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "NroTarjeta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Emisor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "FechaCreacion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "FechaVencimiento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // AsociarTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 262);
            this.Controls.Add(this.lista_Tarjetas);
            this.Controls.Add(this.buttom_Asociar);
            this.Controls.Add(this.boton_Desasociar);
            this.Controls.Add(this.boton_Volver);
            this.Name = "AsociarTarjeta";
            this.Text = "AsociarTarjeta";
            this.Load += new System.EventHandler(this.AsociarTarjeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lista_Tarjetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_Volver;
        private System.Windows.Forms.Button boton_Desasociar;
        private System.Windows.Forms.Button buttom_Asociar;
        private System.Windows.Forms.DataGridView lista_Tarjetas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
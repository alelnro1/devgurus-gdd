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
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_nroTarjeta = new System.Windows.Forms.TextBox();
            this.NuevaTarjeta = new System.Windows.Forms.GroupBox();
            this.comboBox_Emisor = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_codigoSeguridad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lista_Tarjetas)).BeginInit();
            this.NuevaTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // boton_Volver
            // 
            this.boton_Volver.Location = new System.Drawing.Point(963, 12);
            this.boton_Volver.Name = "boton_Volver";
            this.boton_Volver.Size = new System.Drawing.Size(145, 28);
            this.boton_Volver.TabIndex = 223289;
            this.boton_Volver.Text = "Volver";
            this.boton_Volver.UseVisualStyleBackColor = true;
            this.boton_Volver.Click += new System.EventHandler(this.boton_Volver_Click_1);
            // 
            // boton_Desasociar
            // 
            this.boton_Desasociar.Location = new System.Drawing.Point(199, 260);
            this.boton_Desasociar.Name = "boton_Desasociar";
            this.boton_Desasociar.Size = new System.Drawing.Size(147, 41);
            this.boton_Desasociar.TabIndex = 223291;
            this.boton_Desasociar.Text = "Desasociar";
            this.boton_Desasociar.UseVisualStyleBackColor = true;
            this.boton_Desasociar.Click += new System.EventHandler(this.boton_Desasociar_Click_1);
            // 
            // buttom_Asociar
            // 
            this.buttom_Asociar.Location = new System.Drawing.Point(368, 260);
            this.buttom_Asociar.Name = "buttom_Asociar";
            this.buttom_Asociar.Size = new System.Drawing.Size(147, 41);
            this.buttom_Asociar.TabIndex = 223292;
            this.buttom_Asociar.Text = "Asociar";
            this.buttom_Asociar.UseVisualStyleBackColor = true;
            this.buttom_Asociar.Click += new System.EventHandler(this.buttom_Asociar_Click_1);
            // 
            // lista_Tarjetas
            // 
            this.lista_Tarjetas.AllowUserToAddRows = false;
            this.lista_Tarjetas.AllowUserToDeleteRows = false;
            this.lista_Tarjetas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lista_Tarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista_Tarjetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.estado});
            this.lista_Tarjetas.Location = new System.Drawing.Point(47, 25);
            this.lista_Tarjetas.Name = "lista_Tarjetas";
            this.lista_Tarjetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista_Tarjetas.Size = new System.Drawing.Size(550, 216);
            this.lista_Tarjetas.TabIndex = 223293;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "NroTarjeta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Emisor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "FechaCreacion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "FechaVencimiento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // textBox_nroTarjeta
            // 
            this.textBox_nroTarjeta.Location = new System.Drawing.Point(116, 26);
            this.textBox_nroTarjeta.MaxLength = 18;
            this.textBox_nroTarjeta.Name = "textBox_nroTarjeta";
            this.textBox_nroTarjeta.Size = new System.Drawing.Size(132, 20);
            this.textBox_nroTarjeta.TabIndex = 223295;
            // 
            // NuevaTarjeta
            // 
            this.NuevaTarjeta.Controls.Add(this.label3);
            this.NuevaTarjeta.Controls.Add(this.textBox_codigoSeguridad);
            this.NuevaTarjeta.Controls.Add(this.button1);
            this.NuevaTarjeta.Controls.Add(this.label2);
            this.NuevaTarjeta.Controls.Add(this.label1);
            this.NuevaTarjeta.Controls.Add(this.label11);
            this.NuevaTarjeta.Controls.Add(this.dateTimePicker_vencimiento);
            this.NuevaTarjeta.Controls.Add(this.comboBox_Emisor);
            this.NuevaTarjeta.Controls.Add(this.textBox_nroTarjeta);
            this.NuevaTarjeta.Location = new System.Drawing.Point(626, 25);
            this.NuevaTarjeta.Name = "NuevaTarjeta";
            this.NuevaTarjeta.Size = new System.Drawing.Size(313, 246);
            this.NuevaTarjeta.TabIndex = 223296;
            this.NuevaTarjeta.TabStop = false;
            this.NuevaTarjeta.Text = "Nueva Tarjeta";
            this.NuevaTarjeta.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox_Emisor
            // 
            this.comboBox_Emisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Emisor.FormattingEnabled = true;
            this.comboBox_Emisor.Items.AddRange(new object[] {
            "Visa",
            "Master Card",
            "American Express"});
            this.comboBox_Emisor.Location = new System.Drawing.Point(116, 111);
            this.comboBox_Emisor.Name = "comboBox_Emisor";
            this.comboBox_Emisor.Size = new System.Drawing.Size(132, 21);
            this.comboBox_Emisor.TabIndex = 223296;
            // 
            // dateTimePicker_vencimiento
            // 
            this.dateTimePicker_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_vencimiento.Location = new System.Drawing.Point(116, 162);
            this.dateTimePicker_vencimiento.Name = "dateTimePicker_vencimiento";
            this.dateTimePicker_vencimiento.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker_vencimiento.TabIndex = 223310;
            this.dateTimePicker_vencimiento.Value = new System.DateTime(2018, 2, 1, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 223311;
            this.label11.Text = "Fecha Vencimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 223312;
            this.label1.Text = "Emisor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 223313;
            this.label2.Text = "Nro Tarjeta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 223314;
            this.button1.Text = "Generar Nueva Tarejta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_codigoSeguridad
            // 
            this.textBox_codigoSeguridad.Location = new System.Drawing.Point(116, 69);
            this.textBox_codigoSeguridad.MaxLength = 6;
            this.textBox_codigoSeguridad.Name = "textBox_codigoSeguridad";
            this.textBox_codigoSeguridad.Size = new System.Drawing.Size(132, 20);
            this.textBox_codigoSeguridad.TabIndex = 223315;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 223316;
            this.label3.Text = "Codigo Seguridad";
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(47, 260);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(129, 41);
            this.editar.TabIndex = 223297;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // AsociarTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 313);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.NuevaTarjeta);
            this.Controls.Add(this.lista_Tarjetas);
            this.Controls.Add(this.buttom_Asociar);
            this.Controls.Add(this.boton_Desasociar);
            this.Controls.Add(this.boton_Volver);
            this.Name = "AsociarTarjeta";
            this.Text = "AsociarTarjeta";
            this.Load += new System.EventHandler(this.AsociarTarjeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lista_Tarjetas)).EndInit();
            this.NuevaTarjeta.ResumeLayout(false);
            this.NuevaTarjeta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_Volver;
        private System.Windows.Forms.Button boton_Desasociar;
        private System.Windows.Forms.Button buttom_Asociar;
        private System.Windows.Forms.DataGridView lista_Tarjetas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.TextBox textBox_nroTarjeta;
        private System.Windows.Forms.GroupBox NuevaTarjeta;
        private System.Windows.Forms.ComboBox comboBox_Emisor;
        private System.Windows.Forms.DateTimePicker dateTimePicker_vencimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_codigoSeguridad;
        private System.Windows.Forms.Button editar;
    }
}
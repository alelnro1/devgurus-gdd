namespace PagoElectronico
{
    partial class ConsultarSaldo
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDepositos = new System.Windows.Forms.DataGridView();
            this.FechaDeposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteDeposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonedaDeposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewRetiros = new System.Windows.Forms.DataGridView();
            this.FechaRetiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteRetiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewTransferencias = new System.Windows.Forms.DataGridView();
            this.FechaTransferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuentaDestinoTransferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteTransferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoTransferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuenta_combobox = new System.Windows.Forms.ComboBox();
            this.textBox_saldo = new System.Windows.Forms.TextBox();
            this.saldo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepositos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRetiros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransferencias)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Consultar Saldo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cuenta";
            // 
            // dataGridViewDepositos
            // 
            this.dataGridViewDepositos.AllowUserToAddRows = false;
            this.dataGridViewDepositos.AllowUserToDeleteRows = false;
            this.dataGridViewDepositos.AllowUserToResizeRows = false;
            this.dataGridViewDepositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepositos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaDeposito,
            this.ImporteDeposito,
            this.MonedaDeposito});
            this.dataGridViewDepositos.Location = new System.Drawing.Point(15, 61);
            this.dataGridViewDepositos.Name = "dataGridViewDepositos";
            this.dataGridViewDepositos.Size = new System.Drawing.Size(343, 141);
            this.dataGridViewDepositos.TabIndex = 3;
            // 
            // FechaDeposito
            // 
            this.FechaDeposito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaDeposito.HeaderText = "Fecha";
            this.FechaDeposito.Name = "FechaDeposito";
            this.FechaDeposito.ReadOnly = true;
            // 
            // ImporteDeposito
            // 
            this.ImporteDeposito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImporteDeposito.HeaderText = "Importe";
            this.ImporteDeposito.Name = "ImporteDeposito";
            this.ImporteDeposito.ReadOnly = true;
            // 
            // MonedaDeposito
            // 
            this.MonedaDeposito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MonedaDeposito.HeaderText = "Moneda";
            this.MonedaDeposito.Name = "MonedaDeposito";
            this.MonedaDeposito.ReadOnly = true;
            // 
            // dataGridViewRetiros
            // 
            this.dataGridViewRetiros.AllowUserToAddRows = false;
            this.dataGridViewRetiros.AllowUserToDeleteRows = false;
            this.dataGridViewRetiros.AllowUserToResizeRows = false;
            this.dataGridViewRetiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRetiros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaRetiro,
            this.ImporteRetiro});
            this.dataGridViewRetiros.Location = new System.Drawing.Point(385, 61);
            this.dataGridViewRetiros.Name = "dataGridViewRetiros";
            this.dataGridViewRetiros.Size = new System.Drawing.Size(244, 141);
            this.dataGridViewRetiros.TabIndex = 4;
            // 
            // FechaRetiro
            // 
            this.FechaRetiro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaRetiro.HeaderText = "Fecha";
            this.FechaRetiro.Name = "FechaRetiro";
            this.FechaRetiro.ReadOnly = true;
            // 
            // ImporteRetiro
            // 
            this.ImporteRetiro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImporteRetiro.HeaderText = "Importe";
            this.ImporteRetiro.Name = "ImporteRetiro";
            this.ImporteRetiro.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Últimos 5 depositos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Últimos 5 retiros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Últimas 10 transferencias";
            // 
            // dataGridViewTransferencias
            // 
            this.dataGridViewTransferencias.AllowUserToAddRows = false;
            this.dataGridViewTransferencias.AllowUserToDeleteRows = false;
            this.dataGridViewTransferencias.AllowUserToResizeRows = false;
            this.dataGridViewTransferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransferencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaTransferencia,
            this.CuentaDestinoTransferencia,
            this.ImporteTransferencia,
            this.CostoTransferencia});
            this.dataGridViewTransferencias.Location = new System.Drawing.Point(15, 248);
            this.dataGridViewTransferencias.Name = "dataGridViewTransferencias";
            this.dataGridViewTransferencias.Size = new System.Drawing.Size(614, 231);
            this.dataGridViewTransferencias.TabIndex = 8;
            // 
            // FechaTransferencia
            // 
            this.FechaTransferencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaTransferencia.HeaderText = "Fecha";
            this.FechaTransferencia.Name = "FechaTransferencia";
            this.FechaTransferencia.ReadOnly = true;
            // 
            // CuentaDestinoTransferencia
            // 
            this.CuentaDestinoTransferencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CuentaDestinoTransferencia.HeaderText = "Cuenta Destino";
            this.CuentaDestinoTransferencia.Name = "CuentaDestinoTransferencia";
            this.CuentaDestinoTransferencia.ReadOnly = true;
            // 
            // ImporteTransferencia
            // 
            this.ImporteTransferencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImporteTransferencia.HeaderText = "Importe";
            this.ImporteTransferencia.Name = "ImporteTransferencia";
            this.ImporteTransferencia.ReadOnly = true;
            // 
            // CostoTransferencia
            // 
            this.CostoTransferencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CostoTransferencia.HeaderText = "Costo";
            this.CostoTransferencia.Name = "CostoTransferencia";
            this.CostoTransferencia.ReadOnly = true;
            // 
            // cuenta_combobox
            // 
            this.cuenta_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuenta_combobox.FormattingEnabled = true;
            this.cuenta_combobox.Location = new System.Drawing.Point(59, 9);
            this.cuenta_combobox.Name = "cuenta_combobox";
            this.cuenta_combobox.Size = new System.Drawing.Size(121, 21);
            this.cuenta_combobox.TabIndex = 9;
            // 
            // textBox_saldo
            // 
            this.textBox_saldo.Enabled = false;
            this.textBox_saldo.Location = new System.Drawing.Point(469, 6);
            this.textBox_saldo.Name = "textBox_saldo";
            this.textBox_saldo.Size = new System.Drawing.Size(100, 20);
            this.textBox_saldo.TabIndex = 10;
            // 
            // saldo
            // 
            this.saldo.AutoSize = true;
            this.saldo.Location = new System.Drawing.Point(382, 9);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(67, 13);
            this.saldo.TabIndex = 11;
            this.saldo.Text = "Saldo Actual";
            // 
            // ConsultarSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 491);
            this.Controls.Add(this.saldo);
            this.Controls.Add(this.textBox_saldo);
            this.Controls.Add(this.cuenta_combobox);
            this.Controls.Add(this.dataGridViewTransferencias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewRetiros);
            this.Controls.Add(this.dataGridViewDepositos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "ConsultarSaldo";
            this.Text = "ConsultarSaldo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepositos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRetiros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransferencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDepositos;
        private System.Windows.Forms.DataGridView dataGridViewRetiros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewTransferencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteDeposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonedaDeposito;
        private System.Windows.Forms.ComboBox cuenta_combobox;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRetiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteRetiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaTransferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuentaDestinoTransferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteTransferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoTransferencia;
        private System.Windows.Forms.TextBox textBox_saldo;
        private System.Windows.Forms.Label saldo;
    }
}
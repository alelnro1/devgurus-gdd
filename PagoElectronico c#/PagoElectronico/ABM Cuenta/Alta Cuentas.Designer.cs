namespace PagoElectronico.ABM_Cuenta
{
    partial class AltaCuentas
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
            this.text_Nro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_moneda = new System.Windows.Forms.ComboBox();
            this.text_pais_origen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTime_apertura = new System.Windows.Forms.DateTimePicker();
            this.text_tipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_dar_alta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de cuenta";
            // 
            // text_Nro
            // 
            this.text_Nro.Location = new System.Drawing.Point(169, 28);
            this.text_Nro.Name = "text_Nro";
            this.text_Nro.Size = new System.Drawing.Size(100, 20);
            this.text_Nro.TabIndex = 1;
            this.text_Nro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pais origen";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // combo_moneda
            // 
            this.combo_moneda.FormattingEnabled = true;
            this.combo_moneda.Location = new System.Drawing.Point(169, 96);
            this.combo_moneda.Name = "combo_moneda";
            this.combo_moneda.Size = new System.Drawing.Size(100, 21);
            this.combo_moneda.TabIndex = 3;
            // 
            // text_pais_origen
            // 
            this.text_pais_origen.Location = new System.Drawing.Point(169, 65);
            this.text_pais_origen.Name = "text_pais_origen";
            this.text_pais_origen.Size = new System.Drawing.Size(100, 20);
            this.text_pais_origen.TabIndex = 4;
            this.text_pais_origen.TextChanged += new System.EventHandler(this.text_Pais_origen_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Moneda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de apertura";
            // 
            // dateTime_apertura
            // 
            this.dateTime_apertura.Location = new System.Drawing.Point(169, 130);
            this.dateTime_apertura.Name = "dateTime_apertura";
            this.dateTime_apertura.Size = new System.Drawing.Size(223, 20);
            this.dateTime_apertura.TabIndex = 8;
            // 
            // text_tipo
            // 
            this.text_tipo.FormattingEnabled = true;
            this.text_tipo.Location = new System.Drawing.Point(169, 169);
            this.text_tipo.Name = "text_tipo";
            this.text_tipo.Size = new System.Drawing.Size(121, 21);
            this.text_tipo.TabIndex = 9;
            this.text_tipo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo de cuenta";
            // 
            // button_dar_alta
            // 
            this.button_dar_alta.Location = new System.Drawing.Point(40, 209);
            this.button_dar_alta.Name = "button_dar_alta";
            this.button_dar_alta.Size = new System.Drawing.Size(343, 58);
            this.button_dar_alta.TabIndex = 11;
            this.button_dar_alta.Text = "Dar Alta ";
            this.button_dar_alta.UseVisualStyleBackColor = true;
            // 
            // AltaCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 280);
            this.Controls.Add(this.button_dar_alta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_tipo);
            this.Controls.Add(this.dateTime_apertura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_pais_origen);
            this.Controls.Add(this.combo_moneda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_Nro);
            this.Controls.Add(this.label1);
            this.Name = "AltaCuentas";
            this.Text = "Alta de Cuentas";
            this.Load += new System.EventHandler(this.Cuentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_Nro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_moneda;
        private System.Windows.Forms.TextBox text_pais_origen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTime_apertura;
        private System.Windows.Forms.ComboBox text_tipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_dar_alta;
    }
}
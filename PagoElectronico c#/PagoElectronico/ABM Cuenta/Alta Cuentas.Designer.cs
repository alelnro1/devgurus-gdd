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
            this.label2 = new System.Windows.Forms.Label();
            this.combo_moneda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_tipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_dar_alta = new System.Windows.Forms.Button();
            this.pais_origen_seleccionador = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Moneda";
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
            this.button_dar_alta.Click += new System.EventHandler(this.button_dar_alta_Click);
            // 
            // pais_origen_seleccionador
            // 
            this.pais_origen_seleccionador.AllowDrop = true;
            this.pais_origen_seleccionador.FormattingEnabled = true;
            this.pais_origen_seleccionador.Items.AddRange(new object[] {
            "1"});
            this.pais_origen_seleccionador.Location = new System.Drawing.Point(169, 68);
            this.pais_origen_seleccionador.Name = "pais_origen_seleccionador";
            this.pais_origen_seleccionador.Size = new System.Drawing.Size(121, 21);
            this.pais_origen_seleccionador.TabIndex = 12;
            // 
            // AltaCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 280);
            this.Controls.Add(this.pais_origen_seleccionador);
            this.Controls.Add(this.button_dar_alta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_tipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_moneda);
            this.Controls.Add(this.label2);
            this.Name = "AltaCuentas";
            this.Text = "Alta de Cuentas";
            this.Load += new System.EventHandler(this.Cuentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

   
    
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_moneda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox text_tipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_dar_alta;
        private System.Windows.Forms.ComboBox pais_origen_seleccionador;
    }
}
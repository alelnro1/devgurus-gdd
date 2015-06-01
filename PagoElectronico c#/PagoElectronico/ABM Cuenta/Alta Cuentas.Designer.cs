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
            this.label_pais_origen = new System.Windows.Forms.Label();
            this.combo_tipo_moneda = new System.Windows.Forms.ComboBox();
            this.label_moneda = new System.Windows.Forms.Label();
            this.combo_tipo_cuenta = new System.Windows.Forms.ComboBox();
            this.label_tipo_cuenta = new System.Windows.Forms.Label();
            this.button_dar_alta = new System.Windows.Forms.Button();
            this.combo_pais_origen = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_pais_origen
            // 
            this.label_pais_origen.AutoSize = true;
            this.label_pais_origen.Location = new System.Drawing.Point(44, 68);
            this.label_pais_origen.Name = "label_pais_origen";
            this.label_pais_origen.Size = new System.Drawing.Size(59, 13);
            this.label_pais_origen.TabIndex = 2;
            this.label_pais_origen.Text = "Pais origen";
            this.label_pais_origen.Click += new System.EventHandler(this.label2_Click);
            // 
            // combo_tipo_moneda
            // 
            this.combo_tipo_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_tipo_moneda.FormattingEnabled = true;
            this.combo_tipo_moneda.Location = new System.Drawing.Point(169, 96);
            this.combo_tipo_moneda.Name = "combo_tipo_moneda";
            this.combo_tipo_moneda.Size = new System.Drawing.Size(100, 21);
            this.combo_tipo_moneda.TabIndex = 3;
            // 
            // label_moneda
            // 
            this.label_moneda.AutoSize = true;
            this.label_moneda.Location = new System.Drawing.Point(44, 99);
            this.label_moneda.Name = "label_moneda";
            this.label_moneda.Size = new System.Drawing.Size(46, 13);
            this.label_moneda.TabIndex = 5;
            this.label_moneda.Text = "Moneda";
            this.label_moneda.Click += new System.EventHandler(this.label3_Click);
            // 
            // combo_tipo_cuenta
            // 
            this.combo_tipo_cuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_tipo_cuenta.FormattingEnabled = true;
            this.combo_tipo_cuenta.Location = new System.Drawing.Point(169, 169);
            this.combo_tipo_cuenta.Name = "combo_tipo_cuenta";
            this.combo_tipo_cuenta.Size = new System.Drawing.Size(121, 21);
            this.combo_tipo_cuenta.TabIndex = 9;
            this.combo_tipo_cuenta.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label_tipo_cuenta
            // 
            this.label_tipo_cuenta.AutoSize = true;
            this.label_tipo_cuenta.Location = new System.Drawing.Point(44, 172);
            this.label_tipo_cuenta.Name = "label_tipo_cuenta";
            this.label_tipo_cuenta.Size = new System.Drawing.Size(79, 13);
            this.label_tipo_cuenta.TabIndex = 10;
            this.label_tipo_cuenta.Text = "Tipo de cuenta";
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
            // combo_pais_origen
            // 
            this.combo_pais_origen.FormattingEnabled = true;
            this.combo_pais_origen.Location = new System.Drawing.Point(169, 69);
            this.combo_pais_origen.Name = "combo_pais_origen";
            this.combo_pais_origen.Size = new System.Drawing.Size(121, 21);
            this.combo_pais_origen.TabIndex = 13;
            this.combo_pais_origen.SelectedIndexChanged += new System.EventHandler(this.combo_pais_origen_SelectedIndexChanged);
            // 
            // AltaCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 280);
            this.Controls.Add(this.combo_pais_origen);
            this.Controls.Add(this.button_dar_alta);
            this.Controls.Add(this.label_tipo_cuenta);
            this.Controls.Add(this.combo_tipo_cuenta);
            this.Controls.Add(this.label_moneda);
            this.Controls.Add(this.combo_tipo_moneda);
            this.Controls.Add(this.label_pais_origen);
            this.Name = "AltaCuentas";
            this.Text = "Alta de Cuentas";
            this.Load += new System.EventHandler(this.Cuentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.Label label_pais_origen;
        private System.Windows.Forms.ComboBox combo_tipo_moneda;
        private System.Windows.Forms.Label label_moneda;
        private System.Windows.Forms.ComboBox combo_tipo_cuenta;
        private System.Windows.Forms.Label label_tipo_cuenta;
        private System.Windows.Forms.Button button_dar_alta;
        private System.Windows.Forms.ComboBox combo_pais_origen;
    }
}
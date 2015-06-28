namespace PagoElectronico
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
            this.label_pais_Asignado = new System.Windows.Forms.Label();
            this.combo_tipo_moneda = new System.Windows.Forms.ComboBox();
            this.label_moneda = new System.Windows.Forms.Label();
            this.combo_tipo_cuenta = new System.Windows.Forms.ComboBox();
            this.label_tipo_cuenta = new System.Windows.Forms.Label();
            this.button_dar_alta = new System.Windows.Forms.Button();
            this.combo_pais_Asignado = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_pais_Asignado
            // 
            this.label_pais_Asignado.AutoSize = true;
            this.label_pais_Asignado.Location = new System.Drawing.Point(82, 36);
            this.label_pais_Asignado.Name = "label_pais_Asignado";
            this.label_pais_Asignado.Size = new System.Drawing.Size(76, 13);
            this.label_pais_Asignado.TabIndex = 2;
            this.label_pais_Asignado.Text = "Pais asignado:";
            // 
            // combo_tipo_moneda
            // 
            this.combo_tipo_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_tipo_moneda.FormattingEnabled = true;
            this.combo_tipo_moneda.Location = new System.Drawing.Point(168, 81);
            this.combo_tipo_moneda.Name = "combo_tipo_moneda";
            this.combo_tipo_moneda.Size = new System.Drawing.Size(121, 21);
            this.combo_tipo_moneda.TabIndex = 3;
            // 
            // label_moneda
            // 
            this.label_moneda.AutoSize = true;
            this.label_moneda.Location = new System.Drawing.Point(95, 84);
            this.label_moneda.Name = "label_moneda";
            this.label_moneda.Size = new System.Drawing.Size(49, 13);
            this.label_moneda.TabIndex = 5;
            this.label_moneda.Text = "Moneda:";
            // 
            // combo_tipo_cuenta
            // 
            this.combo_tipo_cuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_tipo_cuenta.FormattingEnabled = true;
            this.combo_tipo_cuenta.Location = new System.Drawing.Point(168, 125);
            this.combo_tipo_cuenta.Name = "combo_tipo_cuenta";
            this.combo_tipo_cuenta.Size = new System.Drawing.Size(121, 21);
            this.combo_tipo_cuenta.TabIndex = 9;
            // 
            // label_tipo_cuenta
            // 
            this.label_tipo_cuenta.AutoSize = true;
            this.label_tipo_cuenta.Location = new System.Drawing.Point(62, 128);
            this.label_tipo_cuenta.Name = "label_tipo_cuenta";
            this.label_tipo_cuenta.Size = new System.Drawing.Size(82, 13);
            this.label_tipo_cuenta.TabIndex = 10;
            this.label_tipo_cuenta.Text = "Tipo de cuenta:";
            // 
            // button_dar_alta
            // 
            this.button_dar_alta.Location = new System.Drawing.Point(232, 187);
            this.button_dar_alta.Name = "button_dar_alta";
            this.button_dar_alta.Size = new System.Drawing.Size(105, 29);
            this.button_dar_alta.TabIndex = 11;
            this.button_dar_alta.Text = "Crear";
            this.button_dar_alta.UseVisualStyleBackColor = true;
            this.button_dar_alta.Click += new System.EventHandler(this.button_dar_alta_Click);
            // 
            // combo_pais_Asignado
            // 
            this.combo_pais_Asignado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_pais_Asignado.FormattingEnabled = true;
            this.combo_pais_Asignado.Location = new System.Drawing.Point(168, 33);
            this.combo_pais_Asignado.Name = "combo_pais_Asignado";
            this.combo_pais_Asignado.Size = new System.Drawing.Size(121, 21);
            this.combo_pais_Asignado.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AltaCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 238);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.combo_pais_Asignado);
            this.Controls.Add(this.button_dar_alta);
            this.Controls.Add(this.label_tipo_cuenta);
            this.Controls.Add(this.combo_tipo_cuenta);
            this.Controls.Add(this.label_moneda);
            this.Controls.Add(this.combo_tipo_moneda);
            this.Controls.Add(this.label_pais_Asignado);
            this.Name = "AltaCuentas";
            this.Text = "Alta de Cuentas";
            this.Load += new System.EventHandler(this.AltaCuentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.Label label_pais_Asignado;
        private System.Windows.Forms.ComboBox combo_tipo_moneda;
        private System.Windows.Forms.Label label_moneda;
        private System.Windows.Forms.ComboBox combo_tipo_cuenta;
        private System.Windows.Forms.Label label_tipo_cuenta;
        private System.Windows.Forms.Button button_dar_alta;
        private System.Windows.Forms.ComboBox combo_pais_Asignado;
        private System.Windows.Forms.Button button1;
    }
}
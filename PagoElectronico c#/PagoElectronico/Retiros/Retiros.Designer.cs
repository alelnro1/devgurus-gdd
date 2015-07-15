namespace PagoElectronico
{
    partial class Retiros
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
            this.cuenta_combobox = new System.Windows.Forms.ComboBox();
            this.Importe = new System.Windows.Forms.Label();
            this.importe_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nro_doc_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.boton_Cancel = new System.Windows.Forms.Button();
            this.banco_Combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuenta";
            // 
            // cuenta_combobox
            // 
            this.cuenta_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuenta_combobox.FormattingEnabled = true;
            this.cuenta_combobox.Location = new System.Drawing.Point(73, 13);
            this.cuenta_combobox.Name = "cuenta_combobox";
            this.cuenta_combobox.Size = new System.Drawing.Size(121, 21);
            this.cuenta_combobox.TabIndex = 1;
            // 
            // Importe
            // 
            this.Importe.AutoSize = true;
            this.Importe.Location = new System.Drawing.Point(21, 72);
            this.Importe.Name = "Importe";
            this.Importe.Size = new System.Drawing.Size(42, 13);
            this.Importe.TabIndex = 2;
            this.Importe.Text = "Importe";
            // 
            // importe_textbox
            // 
            this.importe_textbox.Location = new System.Drawing.Point(73, 69);
            this.importe_textbox.MaxLength = 15;
            this.importe_textbox.Name = "importe_textbox";
            this.importe_textbox.Size = new System.Drawing.Size(121, 20);
            this.importe_textbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nro Doc";
            // 
            // nro_doc_textbox
            // 
            this.nro_doc_textbox.Location = new System.Drawing.Point(73, 42);
            this.nro_doc_textbox.MaxLength = 9;
            this.nro_doc_textbox.Name = "nro_doc_textbox";
            this.nro_doc_textbox.Size = new System.Drawing.Size(121, 20);
            this.nro_doc_textbox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Retirar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // boton_Cancel
            // 
            this.boton_Cancel.Location = new System.Drawing.Point(19, 149);
            this.boton_Cancel.Name = "boton_Cancel";
            this.boton_Cancel.Size = new System.Drawing.Size(75, 23);
            this.boton_Cancel.TabIndex = 7;
            this.boton_Cancel.Text = "Cancelar";
            this.boton_Cancel.UseVisualStyleBackColor = true;
            this.boton_Cancel.Click += new System.EventHandler(this.boton_Cancel_Click);
            // 
            // banco_Combo
            // 
            this.banco_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.banco_Combo.FormattingEnabled = true;
            this.banco_Combo.Location = new System.Drawing.Point(72, 99);
            this.banco_Combo.Name = "banco_Combo";
            this.banco_Combo.Size = new System.Drawing.Size(121, 21);
            this.banco_Combo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Banco";
            // 
            // Retiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 195);
            this.Controls.Add(this.banco_Combo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boton_Cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nro_doc_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.importe_textbox);
            this.Controls.Add(this.Importe);
            this.Controls.Add(this.cuenta_combobox);
            this.Controls.Add(this.label1);
            this.Name = "Retiros";
            this.Text = "Retiros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cuenta_combobox;
        private System.Windows.Forms.Label Importe;
        private System.Windows.Forms.TextBox importe_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nro_doc_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button boton_Cancel;
        private System.Windows.Forms.ComboBox banco_Combo;
        private System.Windows.Forms.Label label3;
    }
}
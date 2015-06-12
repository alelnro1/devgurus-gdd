namespace PagoElectronico.Retiros
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
            this.nro_doc_textbox.Name = "nro_doc_textbox";
            this.nro_doc_textbox.Size = new System.Drawing.Size(121, 20);
            this.nro_doc_textbox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Retirar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Retiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 159);
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
    }
}
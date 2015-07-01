namespace PagoElectronico
{
    partial class Transferencias
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
            this.label2 = new System.Windows.Forms.Label();
            this.cuenta_destino_text = new System.Windows.Forms.TextBox();
            this.cuenta_origen_combobox = new System.Windows.Forms.ComboBox();
            this.Importe = new System.Windows.Forms.Label();
            this.importe_textbox = new System.Windows.Forms.TextBox();
            this.Transferir = new System.Windows.Forms.Button();
            this.boton_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuenta Origen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuenta Destino";
            // 
            // cuenta_destino_text
            // 
            this.cuenta_destino_text.Location = new System.Drawing.Point(95, 40);
            this.cuenta_destino_text.MaxLength = 100;
            this.cuenta_destino_text.Name = "cuenta_destino_text";
            this.cuenta_destino_text.Size = new System.Drawing.Size(121, 20);
            this.cuenta_destino_text.TabIndex = 3;
            this.cuenta_destino_text.TextChanged += new System.EventHandler(this.cuenta_destino_text_TextChanged);
            // 
            // cuenta_origen_combobox
            // 
            this.cuenta_origen_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuenta_origen_combobox.FormattingEnabled = true;
            this.cuenta_origen_combobox.Location = new System.Drawing.Point(95, 13);
            this.cuenta_origen_combobox.MaxLength = 100;
            this.cuenta_origen_combobox.Name = "cuenta_origen_combobox";
            this.cuenta_origen_combobox.Size = new System.Drawing.Size(121, 21);
            this.cuenta_origen_combobox.TabIndex = 4;
            this.cuenta_origen_combobox.SelectedIndexChanged += new System.EventHandler(this.cuenta_origen_combobox_SelectedIndexChanged);
            // 
            // Importe
            // 
            this.Importe.AutoSize = true;
            this.Importe.Location = new System.Drawing.Point(46, 70);
            this.Importe.Name = "Importe";
            this.Importe.Size = new System.Drawing.Size(42, 13);
            this.Importe.TabIndex = 5;
            this.Importe.Text = "Importe";
            // 
            // importe_textbox
            // 
            this.importe_textbox.Location = new System.Drawing.Point(95, 67);
            this.importe_textbox.MaxLength = 15;
            this.importe_textbox.Name = "importe_textbox";
            this.importe_textbox.Size = new System.Drawing.Size(121, 20);
            this.importe_textbox.TabIndex = 6;
            // 
            // Transferir
            // 
            this.Transferir.Location = new System.Drawing.Point(141, 103);
            this.Transferir.Name = "Transferir";
            this.Transferir.Size = new System.Drawing.Size(75, 23);
            this.Transferir.TabIndex = 7;
            this.Transferir.Text = "Transferir";
            this.Transferir.UseVisualStyleBackColor = true;
            this.Transferir.Click += new System.EventHandler(this.Transferir_Click);
            // 
            // boton_Cancel
            // 
            this.boton_Cancel.Location = new System.Drawing.Point(18, 103);
            this.boton_Cancel.Name = "boton_Cancel";
            this.boton_Cancel.Size = new System.Drawing.Size(75, 23);
            this.boton_Cancel.TabIndex = 8;
            this.boton_Cancel.Text = "Cancelar";
            this.boton_Cancel.UseVisualStyleBackColor = true;
            this.boton_Cancel.Click += new System.EventHandler(this.boton_Cancel_Click);
            // 
            // Transferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 138);
            this.Controls.Add(this.boton_Cancel);
            this.Controls.Add(this.Transferir);
            this.Controls.Add(this.importe_textbox);
            this.Controls.Add(this.Importe);
            this.Controls.Add(this.cuenta_origen_combobox);
            this.Controls.Add(this.cuenta_destino_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Transferencias";
            this.Text = "Transferencias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cuenta_destino_text;
        private System.Windows.Forms.ComboBox cuenta_origen_combobox;
        private System.Windows.Forms.Label Importe;
        private System.Windows.Forms.TextBox importe_textbox;
        private System.Windows.Forms.Button Transferir;
        private System.Windows.Forms.Button boton_Cancel;
    }
}
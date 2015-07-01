namespace PagoElectronico
{
    partial class Depositos
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
            this.cuenta_combobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.importe_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.moneda_combobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tarjeta_combobox = new System.Windows.Forms.ComboBox();
            this.boton_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Depositar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cuenta";
            // 
            // cuenta_combobox
            // 
            this.cuenta_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuenta_combobox.FormattingEnabled = true;
            this.cuenta_combobox.Location = new System.Drawing.Point(65, 13);
            this.cuenta_combobox.Name = "cuenta_combobox";
            this.cuenta_combobox.Size = new System.Drawing.Size(139, 21);
            this.cuenta_combobox.TabIndex = 2;
            this.cuenta_combobox.SelectedIndexChanged += new System.EventHandler(this.cuenta_combobox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Importe";
            // 
            // importe_textbox
            // 
            this.importe_textbox.Location = new System.Drawing.Point(65, 92);
            this.importe_textbox.Name = "importe_textbox";
            this.importe_textbox.Size = new System.Drawing.Size(139, 20);
            this.importe_textbox.TabIndex = 4;
            this.importe_textbox.TextChanged += new System.EventHandler(this.importe_textbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Moneda";
            // 
            // moneda_combobox
            // 
            this.moneda_combobox.FormattingEnabled = true;
            this.moneda_combobox.Location = new System.Drawing.Point(65, 38);
            this.moneda_combobox.Name = "moneda_combobox";
            this.moneda_combobox.Size = new System.Drawing.Size(139, 21);
            this.moneda_combobox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tarjeta";
            // 
            // tarjeta_combobox
            // 
            this.tarjeta_combobox.FormattingEnabled = true;
            this.tarjeta_combobox.Location = new System.Drawing.Point(65, 65);
            this.tarjeta_combobox.Name = "tarjeta_combobox";
            this.tarjeta_combobox.Size = new System.Drawing.Size(139, 21);
            this.tarjeta_combobox.TabIndex = 8;
            this.tarjeta_combobox.SelectedIndexChanged += new System.EventHandler(this.tarjeta_combobox_SelectedIndexChanged);
            // 
            // boton_Cancel
            // 
            this.boton_Cancel.Location = new System.Drawing.Point(18, 143);
            this.boton_Cancel.Name = "boton_Cancel";
            this.boton_Cancel.Size = new System.Drawing.Size(75, 23);
            this.boton_Cancel.TabIndex = 9;
            this.boton_Cancel.Text = "Cancelar";
            this.boton_Cancel.UseVisualStyleBackColor = true;
            this.boton_Cancel.Click += new System.EventHandler(this.boton_Cancel_Click);
            // 
            // Depositos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 178);
            this.Controls.Add(this.boton_Cancel);
            this.Controls.Add(this.tarjeta_combobox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.moneda_combobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.importe_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cuenta_combobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Depositos";
            this.Text = "Depositos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cuenta_combobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox importe_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox moneda_combobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tarjeta_combobox;
        private System.Windows.Forms.Button boton_Cancel;
    }
}
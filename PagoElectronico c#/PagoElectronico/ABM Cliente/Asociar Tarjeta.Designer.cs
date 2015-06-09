namespace PagoElectronico.ABM_Cliente
{
    partial class Asociar_Tarjeta
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Emisor = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_emisor = new System.Windows.Forms.ComboBox();
            this.boton_Crear = new System.Windows.Forms.Button();
            this.boton_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(213, 203);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Numero De Cuenta a Asociar";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(213, 272);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 52;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 18);
            this.label5.TabIndex = 49;
            this.label5.Text = "Asociar Tarjeta Nueva";
            // 
            // Emisor
            // 
            this.Emisor.AutoSize = true;
            this.Emisor.Location = new System.Drawing.Point(135, 137);
            this.Emisor.Name = "Emisor";
            this.Emisor.Size = new System.Drawing.Size(38, 13);
            this.Emisor.TabIndex = 48;
            this.Emisor.Text = "Emisor";
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Location = new System.Drawing.Point(111, 279);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(61, 13);
            this.Contraseña.TabIndex = 47;
            this.Contraseña.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Numero de tarjeta";
            // 
            // combo_emisor
            // 
            this.combo_emisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_emisor.FormattingEnabled = true;
            this.combo_emisor.Items.AddRange(new object[] {
            "American Express",
            "Visa",
            "Master Card"});
            this.combo_emisor.Location = new System.Drawing.Point(213, 134);
            this.combo_emisor.Name = "combo_emisor";
            this.combo_emisor.Size = new System.Drawing.Size(121, 21);
            this.combo_emisor.TabIndex = 55;
            // 
            // boton_Crear
            // 
            this.boton_Crear.Location = new System.Drawing.Point(280, 325);
            this.boton_Crear.Name = "boton_Crear";
            this.boton_Crear.Size = new System.Drawing.Size(101, 28);
            this.boton_Crear.TabIndex = 223281;
            this.boton_Crear.Text = "Guardar cambios";
            this.boton_Crear.UseVisualStyleBackColor = true;
            // 
            // boton_Cancelar
            // 
            this.boton_Cancelar.Location = new System.Drawing.Point(38, 325);
            this.boton_Cancelar.Name = "boton_Cancelar";
            this.boton_Cancelar.Size = new System.Drawing.Size(101, 28);
            this.boton_Cancelar.TabIndex = 223280;
            this.boton_Cancelar.Text = "Cancelar edición";
            this.boton_Cancelar.UseVisualStyleBackColor = true;
            this.boton_Cancelar.Click += new System.EventHandler(this.boton_Cancelar_Click);
            // 
            // Asociar_Tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 436);
            this.Controls.Add(this.boton_Crear);
            this.Controls.Add(this.boton_Cancelar);
            this.Controls.Add(this.combo_emisor);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Emisor);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.label1);
            this.Name = "Asociar_Tarjeta";
            this.Text = "Asociar_Tarjeta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Emisor;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_emisor;
        private System.Windows.Forms.Button boton_Crear;
        private System.Windows.Forms.Button boton_Cancelar;
    }
}
﻿namespace PagoElectronico.ABM_Cliente
{
    partial class AltaCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Generar = new System.Windows.Forms.Button();
            this.tipo_doc_textbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.fecha_nac_textbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.localidad_textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.depto_textbox = new System.Windows.Forms.TextBox();
            this.piso_textbox = new System.Windows.Forms.TextBox();
            this.calle_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_pais = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mail_textbox = new System.Windows.Forms.TextBox();
            this.num_doc_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.apellido_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Generar);
            this.groupBox1.Controls.Add(this.tipo_doc_textbox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.fecha_nac_textbox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.localidad_textbox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.depto_textbox);
            this.groupBox1.Controls.Add(this.piso_textbox);
            this.groupBox1.Controls.Add(this.calle_textbox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.combo_pais);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mail_textbox);
            this.groupBox1.Controls.Add(this.num_doc_textbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.apellido_textbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nombre_textbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // Generar
            // 
            this.Generar.Location = new System.Drawing.Point(361, 164);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(75, 23);
            this.Generar.TabIndex = 26;
            this.Generar.Text = "Generar";
            this.Generar.UseVisualStyleBackColor = true;
            this.Generar.Click += new System.EventHandler(this.Generar_Click);
            // 
            // tipo_doc_textbox
            // 
            this.tipo_doc_textbox.Location = new System.Drawing.Point(101, 47);
            this.tipo_doc_textbox.Name = "tipo_doc_textbox";
            this.tipo_doc_textbox.Size = new System.Drawing.Size(121, 20);
            this.tipo_doc_textbox.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Tipo Documento";
            // 
            // fecha_nac_textbox
            // 
            this.fecha_nac_textbox.Location = new System.Drawing.Point(101, 106);
            this.fecha_nac_textbox.Name = "fecha_nac_textbox";
            this.fecha_nac_textbox.Size = new System.Drawing.Size(121, 20);
            this.fecha_nac_textbox.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Fecha de Nac";
            // 
            // localidad_textbox
            // 
            this.localidad_textbox.Enabled = false;
            this.localidad_textbox.Location = new System.Drawing.Point(315, 113);
            this.localidad_textbox.Name = "localidad_textbox";
            this.localidad_textbox.Size = new System.Drawing.Size(121, 20);
            this.localidad_textbox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(256, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Localidad";
            // 
            // depto_textbox
            // 
            this.depto_textbox.Location = new System.Drawing.Point(101, 161);
            this.depto_textbox.Name = "depto_textbox";
            this.depto_textbox.Size = new System.Drawing.Size(31, 20);
            this.depto_textbox.TabIndex = 17;
            // 
            // piso_textbox
            // 
            this.piso_textbox.Location = new System.Drawing.Point(315, 138);
            this.piso_textbox.Name = "piso_textbox";
            this.piso_textbox.Size = new System.Drawing.Size(31, 20);
            this.piso_textbox.TabIndex = 16;
            // 
            // calle_textbox
            // 
            this.calle_textbox.Location = new System.Drawing.Point(101, 135);
            this.calle_textbox.Name = "calle_textbox";
            this.calle_textbox.Size = new System.Drawing.Size(121, 20);
            this.calle_textbox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Depto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Piso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Calle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pais";
            // 
            // combo_pais
            // 
            this.combo_pais.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.combo_pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_pais.FormattingEnabled = true;
            this.combo_pais.Location = new System.Drawing.Point(315, 77);
            this.combo_pais.Name = "combo_pais";
            this.combo_pais.Size = new System.Drawing.Size(121, 21);
            this.combo_pais.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mail";
            // 
            // mail_textbox
            // 
            this.mail_textbox.Location = new System.Drawing.Point(101, 77);
            this.mail_textbox.Name = "mail_textbox";
            this.mail_textbox.Size = new System.Drawing.Size(121, 20);
            this.mail_textbox.TabIndex = 6;
            // 
            // num_doc_textbox
            // 
            this.num_doc_textbox.Location = new System.Drawing.Point(315, 47);
            this.num_doc_textbox.Name = "num_doc_textbox";
            this.num_doc_textbox.Size = new System.Drawing.Size(121, 20);
            this.num_doc_textbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "N° Identificacion";
            // 
            // apellido_textbox
            // 
            this.apellido_textbox.Location = new System.Drawing.Point(315, 20);
            this.apellido_textbox.Name = "apellido_textbox";
            this.apellido_textbox.Size = new System.Drawing.Size(121, 20);
            this.apellido_textbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // nombre_textbox
            // 
            this.nombre_textbox.Location = new System.Drawing.Point(101, 19);
            this.nombre_textbox.Name = "nombre_textbox";
            this.nombre_textbox.Size = new System.Drawing.Size(121, 20);
            this.nombre_textbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Usuario";
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 399);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaCliente";
            this.Text = "AltaCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox apellido_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num_doc_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mail_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_pais;
        private System.Windows.Forms.TextBox depto_textbox;
        private System.Windows.Forms.TextBox piso_textbox;
        private System.Windows.Forms.TextBox calle_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fecha_nac_textbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox localidad_textbox;
        private System.Windows.Forms.Label label9;
        protected internal System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tipo_doc_textbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Generar;

    }
}
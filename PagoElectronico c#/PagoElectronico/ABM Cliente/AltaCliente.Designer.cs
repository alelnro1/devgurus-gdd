namespace PagoElectronico
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
            this.Generar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_nacionalidad = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_nroCalle = new System.Windows.Forms.TextBox();
            this.dateTimePicker_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.comboBox_tipoDoc = new System.Windows.Forms.ComboBox();
            this.comboBox_depto = new System.Windows.Forms.ComboBox();
            this.comboBox_piso = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.localidad_textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.Cancelar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Generar
            // 
            this.Generar.Location = new System.Drawing.Point(375, 350);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(75, 23);
            this.Generar.TabIndex = 29;
            this.Generar.Text = "Generar";
            this.Generar.UseVisualStyleBackColor = true;
            this.Generar.Click += new System.EventHandler(this.Generar_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(14, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 63);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Usuario";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_nacionalidad);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox_nroCalle);
            this.groupBox1.Controls.Add(this.dateTimePicker_nacimiento);
            this.groupBox1.Controls.Add(this.comboBox_tipoDoc);
            this.groupBox1.Controls.Add(this.comboBox_depto);
            this.groupBox1.Controls.Add(this.comboBox_piso);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.localidad_textbox);
            this.groupBox1.Controls.Add(this.label9);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 243);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox_nacionalidad
            // 
            this.comboBox_nacionalidad.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBox_nacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_nacionalidad.FormattingEnabled = true;
            this.comboBox_nacionalidad.Location = new System.Drawing.Point(318, 146);
            this.comboBox_nacionalidad.Name = "comboBox_nacionalidad";
            this.comboBox_nacionalidad.Size = new System.Drawing.Size(121, 21);
            this.comboBox_nacionalidad.TabIndex = 223314;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(45, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 223313;
            this.label14.Text = "Nro Calle";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(238, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 223312;
            this.label13.Text = "Nacionalidad";
            // 
            // textBox_nroCalle
            // 
            this.textBox_nroCalle.Location = new System.Drawing.Point(100, 140);
            this.textBox_nroCalle.Name = "textBox_nroCalle";
            this.textBox_nroCalle.Size = new System.Drawing.Size(121, 20);
            this.textBox_nroCalle.TabIndex = 223311;
            // 
            // dateTimePicker_nacimiento
            // 
            this.dateTimePicker_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_nacimiento.Location = new System.Drawing.Point(98, 208);
            this.dateTimePicker_nacimiento.Name = "dateTimePicker_nacimiento";
            this.dateTimePicker_nacimiento.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker_nacimiento.TabIndex = 223309;
            this.dateTimePicker_nacimiento.ValueChanged += new System.EventHandler(this.dateTimePicker_nacimiento_ValueChanged);
            // 
            // comboBox_tipoDoc
            // 
            this.comboBox_tipoDoc.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBox_tipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipoDoc.FormattingEnabled = true;
            this.comboBox_tipoDoc.Location = new System.Drawing.Point(101, 50);
            this.comboBox_tipoDoc.Name = "comboBox_tipoDoc";
            this.comboBox_tipoDoc.Size = new System.Drawing.Size(121, 21);
            this.comboBox_tipoDoc.TabIndex = 28;
            // 
            // comboBox_depto
            // 
            this.comboBox_depto.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBox_depto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_depto.FormattingEnabled = true;
            this.comboBox_depto.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R"});
            this.comboBox_depto.Location = new System.Drawing.Point(103, 177);
            this.comboBox_depto.Name = "comboBox_depto";
            this.comboBox_depto.Size = new System.Drawing.Size(61, 21);
            this.comboBox_depto.TabIndex = 27;
            // 
            // comboBox_piso
            // 
            this.comboBox_piso.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBox_piso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_piso.FormattingEnabled = true;
            this.comboBox_piso.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.comboBox_piso.Location = new System.Drawing.Point(318, 175);
            this.comboBox_piso.Name = "comboBox_piso";
            this.comboBox_piso.Size = new System.Drawing.Size(56, 21);
            this.comboBox_piso.TabIndex = 26;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Fecha de Nac";
            // 
            // localidad_textbox
            // 
            this.localidad_textbox.Location = new System.Drawing.Point(315, 113);
            this.localidad_textbox.Name = "localidad_textbox";
            this.localidad_textbox.Size = new System.Drawing.Size(121, 20);
            this.localidad_textbox.TabIndex = 19;
            this.localidad_textbox.TextChanged += new System.EventHandler(this.localidad_textbox_TextChanged);
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
            // calle_textbox
            // 
            this.calle_textbox.Location = new System.Drawing.Point(100, 108);
            this.calle_textbox.Name = "calle_textbox";
            this.calle_textbox.Size = new System.Drawing.Size(121, 20);
            this.calle_textbox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Depto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Piso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Calle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pais Domicilio";
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
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(50, 350);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 30;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 448);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Generar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaCliente";
            this.Text = "AltaCliente";
            this.Load += new System.EventHandler(this.AltaCliente_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Generar;
        protected internal System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox localidad_textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox calle_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_pais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mail_textbox;
        private System.Windows.Forms.TextBox num_doc_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox apellido_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.ComboBox comboBox_depto;
        private System.Windows.Forms.ComboBox comboBox_piso;
        private System.Windows.Forms.ComboBox comboBox_tipoDoc;
        private System.Windows.Forms.DateTimePicker dateTimePicker_nacimiento;
        private System.Windows.Forms.ComboBox comboBox_nacionalidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_nroCalle;
        private System.Windows.Forms.ComboBox comboBox1;


    }
}
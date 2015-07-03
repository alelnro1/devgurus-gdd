namespace PagoElectronico
{
    partial class Menu_Listados
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
            this.boton_Inhabilitadas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boton_mayor_Comisiones = new System.Windows.Forms.Button();
            this.boton_Mayor_transacciones = new System.Windows.Forms.Button();
            this.boton_Paises_Mayor_Mov = new System.Windows.Forms.Button();
            this.boton_totales_fact = new System.Windows.Forms.Button();
            this.boton_Volver = new System.Windows.Forms.Button();
            this.combo_anio = new System.Windows.Forms.ComboBox();
            this.combo_trimestre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // boton_Inhabilitadas
            // 
            this.boton_Inhabilitadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_Inhabilitadas.Location = new System.Drawing.Point(58, 94);
            this.boton_Inhabilitadas.Name = "boton_Inhabilitadas";
            this.boton_Inhabilitadas.Size = new System.Drawing.Size(268, 39);
            this.boton_Inhabilitadas.TabIndex = 0;
            this.boton_Inhabilitadas.Text = "Clientes con Cuentas Inhabilitadas por falta de Pago";
            this.boton_Inhabilitadas.UseVisualStyleBackColor = true;
            this.boton_Inhabilitadas.Click += new System.EventHandler(this.boton_Inhabilitadas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Año a consultar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trimestre a consultar:";
            // 
            // boton_mayor_Comisiones
            // 
            this.boton_mayor_Comisiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_mayor_Comisiones.Location = new System.Drawing.Point(58, 139);
            this.boton_mayor_Comisiones.Name = "boton_mayor_Comisiones";
            this.boton_mayor_Comisiones.Size = new System.Drawing.Size(268, 39);
            this.boton_mayor_Comisiones.TabIndex = 6;
            this.boton_mayor_Comisiones.Text = "Clientes con mayor cantidad de comisiones facturadas";
            this.boton_mayor_Comisiones.UseVisualStyleBackColor = true;
            this.boton_mayor_Comisiones.Click += new System.EventHandler(this.boton_mayor_Comisiones_Click);
            // 
            // boton_Mayor_transacciones
            // 
            this.boton_Mayor_transacciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_Mayor_transacciones.Location = new System.Drawing.Point(58, 184);
            this.boton_Mayor_transacciones.Name = "boton_Mayor_transacciones";
            this.boton_Mayor_transacciones.Size = new System.Drawing.Size(268, 39);
            this.boton_Mayor_transacciones.TabIndex = 7;
            this.boton_Mayor_transacciones.Text = "Clientes con mayor cantidad de transacciones realizadas entre cuentas propias";
            this.boton_Mayor_transacciones.UseVisualStyleBackColor = true;
            this.boton_Mayor_transacciones.Click += new System.EventHandler(this.boton_Mayor_transacciones_Click);
            // 
            // boton_Paises_Mayor_Mov
            // 
            this.boton_Paises_Mayor_Mov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_Paises_Mayor_Mov.Location = new System.Drawing.Point(58, 229);
            this.boton_Paises_Mayor_Mov.Name = "boton_Paises_Mayor_Mov";
            this.boton_Paises_Mayor_Mov.Size = new System.Drawing.Size(268, 39);
            this.boton_Paises_Mayor_Mov.TabIndex = 8;
            this.boton_Paises_Mayor_Mov.Text = "Países con mayor cantidad de movimientos tanto ingresos como egresos";
            this.boton_Paises_Mayor_Mov.UseVisualStyleBackColor = true;
            this.boton_Paises_Mayor_Mov.Click += new System.EventHandler(this.boton_Paises_Mayor_Mov_Click);
            // 
            // boton_totales_fact
            // 
            this.boton_totales_fact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_totales_fact.Location = new System.Drawing.Point(58, 274);
            this.boton_totales_fact.Name = "boton_totales_fact";
            this.boton_totales_fact.Size = new System.Drawing.Size(268, 39);
            this.boton_totales_fact.TabIndex = 9;
            this.boton_totales_fact.Text = "Total facturado para los distintos tipos de cuentas";
            this.boton_totales_fact.UseVisualStyleBackColor = true;
            this.boton_totales_fact.Click += new System.EventHandler(this.boton_totales_fact_Click);
            // 
            // boton_Volver
            // 
            this.boton_Volver.Location = new System.Drawing.Point(26, 331);
            this.boton_Volver.Name = "boton_Volver";
            this.boton_Volver.Size = new System.Drawing.Size(124, 27);
            this.boton_Volver.TabIndex = 223287;
            this.boton_Volver.Text = "Volver";
            this.boton_Volver.UseVisualStyleBackColor = true;
            this.boton_Volver.Click += new System.EventHandler(this.boton_Volver_Click);
            // 
            // combo_anio
            // 
            this.combo_anio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_anio.FormattingEnabled = true;
            this.combo_anio.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.combo_anio.Location = new System.Drawing.Point(169, 17);
            this.combo_anio.Name = "combo_anio";
            this.combo_anio.Size = new System.Drawing.Size(120, 21);
            this.combo_anio.TabIndex = 223288;
            // 
            // combo_trimestre
            // 
            this.combo_trimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_trimestre.FormattingEnabled = true;
            this.combo_trimestre.Items.AddRange(new object[] {
            "Ene - Mar",
            "Abr - Jun",
            "Jul - Sep",
            "Oct - Dic"});
            this.combo_trimestre.Location = new System.Drawing.Point(169, 49);
            this.combo_trimestre.Name = "combo_trimestre";
            this.combo_trimestre.Size = new System.Drawing.Size(120, 21);
            this.combo_trimestre.TabIndex = 223289;
            // 
            // Menu_Listados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 370);
            this.Controls.Add(this.combo_trimestre);
            this.Controls.Add(this.combo_anio);
            this.Controls.Add(this.boton_Volver);
            this.Controls.Add(this.boton_totales_fact);
            this.Controls.Add(this.boton_Paises_Mayor_Mov);
            this.Controls.Add(this.boton_Mayor_transacciones);
            this.Controls.Add(this.boton_mayor_Comisiones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_Inhabilitadas);
            this.Name = "Menu_Listados";
            this.Text = "Listado Estadístico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton_Inhabilitadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boton_mayor_Comisiones;
        private System.Windows.Forms.Button boton_Mayor_transacciones;
        private System.Windows.Forms.Button boton_Paises_Mayor_Mov;
        private System.Windows.Forms.Button boton_totales_fact;
        private System.Windows.Forms.Button boton_Volver;
        private System.Windows.Forms.ComboBox combo_anio;
        private System.Windows.Forms.ComboBox combo_trimestre;
    }
}
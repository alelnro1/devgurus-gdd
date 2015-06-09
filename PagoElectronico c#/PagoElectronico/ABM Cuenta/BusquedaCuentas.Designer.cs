namespace PagoElectronico.ABM_Cuenta
{
    partial class BusquedaCuentas
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
            this.combo_Nro_Cuenta = new System.Windows.Forms.ComboBox();
            this.combo_tipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_Tipo_Cuenta = new System.Windows.Forms.Label();
            this.boton_Reestablecer = new System.Windows.Forms.Button();
            this.boton_Limpiar = new System.Windows.Forms.Button();
            this.boton_Buscar = new System.Windows.Forms.Button();
            this.boton_Eliminar = new System.Windows.Forms.Button();
            this.boton_Editar = new System.Windows.Forms.Button();
            this.boton_Volver = new System.Windows.Forms.Button();
            this.label_estado = new System.Windows.Forms.Label();
            this.combo_Tipo_Moneda = new System.Windows.Forms.Label();
            this.combo_moneda = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais_asignado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_cierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combo_pais_origen2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pais_asignado_combo = new System.Windows.Forms.ComboBox();
            this.combo_pais_origen = new System.Windows.Forms.ComboBox();
            this.combo_estado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_Nro_Cuenta
            // 
            this.combo_Nro_Cuenta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_Nro_Cuenta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_Nro_Cuenta.FormattingEnabled = true;
            this.combo_Nro_Cuenta.Location = new System.Drawing.Point(176, 30);
            this.combo_Nro_Cuenta.Name = "combo_Nro_Cuenta";
            this.combo_Nro_Cuenta.Size = new System.Drawing.Size(121, 21);
            this.combo_Nro_Cuenta.TabIndex = 1;
            this.combo_Nro_Cuenta.SelectedIndexChanged += new System.EventHandler(this.combo_Nro_Cuenta_SelectedIndexChanged);
            // 
            // combo_tipo
            // 
            this.combo_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_tipo.FormattingEnabled = true;
            this.combo_tipo.Location = new System.Drawing.Point(175, 137);
            this.combo_tipo.Name = "combo_tipo";
            this.combo_tipo.Size = new System.Drawing.Size(121, 21);
            this.combo_tipo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero Cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pais Origen";
            // 
            // combo_Tipo_Cuenta
            // 
            this.combo_Tipo_Cuenta.AutoSize = true;
            this.combo_Tipo_Cuenta.Location = new System.Drawing.Point(73, 145);
            this.combo_Tipo_Cuenta.Name = "combo_Tipo_Cuenta";
            this.combo_Tipo_Cuenta.Size = new System.Drawing.Size(65, 13);
            this.combo_Tipo_Cuenta.TabIndex = 5;
            this.combo_Tipo_Cuenta.Text = "Tipo Cuenta";
            // 
            // boton_Reestablecer
            // 
            this.boton_Reestablecer.Location = new System.Drawing.Point(318, 239);
            this.boton_Reestablecer.Name = "boton_Reestablecer";
            this.boton_Reestablecer.Size = new System.Drawing.Size(128, 23);
            this.boton_Reestablecer.TabIndex = 223283;
            this.boton_Reestablecer.Text = "Reestablecer";
            this.boton_Reestablecer.UseVisualStyleBackColor = true;
            this.boton_Reestablecer.Click += new System.EventHandler(this.boton_Reestablecer_Click);
            // 
            // boton_Limpiar
            // 
            this.boton_Limpiar.Location = new System.Drawing.Point(451, 145);
            this.boton_Limpiar.Name = "boton_Limpiar";
            this.boton_Limpiar.Size = new System.Drawing.Size(128, 23);
            this.boton_Limpiar.TabIndex = 223282;
            this.boton_Limpiar.Text = "Limpiar busqueda";
            this.boton_Limpiar.UseVisualStyleBackColor = true;
            this.boton_Limpiar.Click += new System.EventHandler(this.boton_Limpiar_Click);
            // 
            // boton_Buscar
            // 
            this.boton_Buscar.Location = new System.Drawing.Point(175, 239);
            this.boton_Buscar.Name = "boton_Buscar";
            this.boton_Buscar.Size = new System.Drawing.Size(128, 23);
            this.boton_Buscar.TabIndex = 223281;
            this.boton_Buscar.Text = "Buscar";
            this.boton_Buscar.UseVisualStyleBackColor = true;
            this.boton_Buscar.Click += new System.EventHandler(this.boton_Buscar_Click);
            // 
            // boton_Eliminar
            // 
            this.boton_Eliminar.Location = new System.Drawing.Point(327, 460);
            this.boton_Eliminar.Name = "boton_Eliminar";
            this.boton_Eliminar.Size = new System.Drawing.Size(128, 23);
            this.boton_Eliminar.TabIndex = 223286;
            this.boton_Eliminar.Text = "Eliminar";
            this.boton_Eliminar.UseVisualStyleBackColor = true;
            this.boton_Eliminar.Click += new System.EventHandler(this.boton_Eliminar_Click);
            // 
            // boton_Editar
            // 
            this.boton_Editar.Location = new System.Drawing.Point(470, 460);
            this.boton_Editar.Name = "boton_Editar";
            this.boton_Editar.Size = new System.Drawing.Size(128, 23);
            this.boton_Editar.TabIndex = 223285;
            this.boton_Editar.Text = "Editar";
            this.boton_Editar.UseVisualStyleBackColor = true;
            this.boton_Editar.Click += new System.EventHandler(this.boton_Editar_Click);
            // 
            // boton_Volver
            // 
            this.boton_Volver.Location = new System.Drawing.Point(184, 460);
            this.boton_Volver.Name = "boton_Volver";
            this.boton_Volver.Size = new System.Drawing.Size(128, 23);
            this.boton_Volver.TabIndex = 223284;
            this.boton_Volver.Text = "Volver";
            this.boton_Volver.UseVisualStyleBackColor = true;
            // 
            // label_estado
            // 
            this.label_estado.AutoSize = true;
            this.label_estado.Location = new System.Drawing.Point(411, 54);
            this.label_estado.Name = "label_estado";
            this.label_estado.Size = new System.Drawing.Size(40, 13);
            this.label_estado.TabIndex = 223287;
            this.label_estado.Text = "Estado";
            // 
            // combo_Tipo_Moneda
            // 
            this.combo_Tipo_Moneda.AutoSize = true;
            this.combo_Tipo_Moneda.Location = new System.Drawing.Point(76, 187);
            this.combo_Tipo_Moneda.Name = "combo_Tipo_Moneda";
            this.combo_Tipo_Moneda.Size = new System.Drawing.Size(46, 13);
            this.combo_Tipo_Moneda.TabIndex = 223289;
            this.combo_Tipo_Moneda.Text = "Moneda";
            // 
            // combo_moneda
            // 
            this.combo_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_moneda.FormattingEnabled = true;
            this.combo_moneda.Location = new System.Drawing.Point(175, 187);
            this.combo_moneda.Name = "combo_moneda";
            this.combo_moneda.Size = new System.Drawing.Size(121, 21);
            this.combo_moneda.TabIndex = 223290;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCuenta,
            this.Estado,
            this.Moneda,
            this.TipoCuenta,
            this.p,
            this.Pais_asignado,
            this.FechaCreacion,
            this.fecha_cierre,
            this.IdCliente,
            this.Tarjeta,
            this.Saldo});
            this.dataGridView1.Location = new System.Drawing.Point(12, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 150);
            this.dataGridView1.TabIndex = 223291;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IdCuenta
            // 
            this.IdCuenta.HeaderText = "Id Cuenta";
            this.IdCuenta.Name = "IdCuenta";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Moneda
            // 
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            // 
            // TipoCuenta
            // 
            this.TipoCuenta.HeaderText = "Tipo Cuenta";
            this.TipoCuenta.Name = "TipoCuenta";
            // 
            // p
            // 
            this.p.HeaderText = "Pais Origen";
            this.p.Name = "p";
            // 
            // Pais_asignado
            // 
            this.Pais_asignado.HeaderText = "Pais Asignado";
            this.Pais_asignado.Name = "Pais_asignado";
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.HeaderText = "Fecha Creacion";
            this.FechaCreacion.Name = "FechaCreacion";
            // 
            // fecha_cierre
            // 
            this.fecha_cierre.HeaderText = "Fecha Cierre";
            this.fecha_cierre.Name = "fecha_cierre";
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "Cliente";
            this.IdCliente.Name = "IdCliente";
            // 
            // Tarjeta
            // 
            this.Tarjeta.HeaderText = "Tarjeta";
            this.Tarjeta.Name = "Tarjeta";
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            // 
            // combo_pais_origen2
            // 
            this.combo_pais_origen2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_pais_origen2.FormattingEnabled = true;
            this.combo_pais_origen2.Location = new System.Drawing.Point(176, 64);
            this.combo_pais_origen2.Name = "combo_pais_origen2";
            this.combo_pais_origen2.Size = new System.Drawing.Size(121, 21);
            this.combo_pais_origen2.TabIndex = 223292;
            this.combo_pais_origen2.SelectedIndexChanged += new System.EventHandler(this.combo_pais_origen2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 223293;
            this.label3.Text = "Pais Asignado";
            // 
            // pais_asignado_combo
            // 
            this.pais_asignado_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pais_asignado_combo.FormattingEnabled = true;
            this.pais_asignado_combo.Location = new System.Drawing.Point(175, 99);
            this.pais_asignado_combo.Name = "pais_asignado_combo";
            this.pais_asignado_combo.Size = new System.Drawing.Size(121, 21);
            this.pais_asignado_combo.TabIndex = 223294;
            this.pais_asignado_combo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // combo_pais_origen
            // 
            this.combo_pais_origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_pais_origen.FormattingEnabled = true;
            this.combo_pais_origen.Location = new System.Drawing.Point(175, 240);
            this.combo_pais_origen.Name = "combo_pais_origen";
            this.combo_pais_origen.Size = new System.Drawing.Size(121, 21);
            this.combo_pais_origen.TabIndex = 0;
            // 
            // combo_estado
            // 
            this.combo_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_estado.FormattingEnabled = true;
            this.combo_estado.Items.AddRange(new object[] {
            "Habilitado",
            "Deshabilitado",
            "Cerrado",
            "Pendiente"});
            this.combo_estado.Location = new System.Drawing.Point(521, 54);
            this.combo_estado.Name = "combo_estado";
            this.combo_estado.Size = new System.Drawing.Size(121, 21);
            this.combo_estado.TabIndex = 223295;
            // 
            // BusquedaCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 500);
            this.Controls.Add(this.combo_estado);
            this.Controls.Add(this.pais_asignado_combo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_pais_origen2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.combo_moneda);
            this.Controls.Add(this.combo_Tipo_Moneda);
            this.Controls.Add(this.label_estado);
            this.Controls.Add(this.boton_Eliminar);
            this.Controls.Add(this.boton_Editar);
            this.Controls.Add(this.boton_Volver);
            this.Controls.Add(this.boton_Reestablecer);
            this.Controls.Add(this.boton_Limpiar);
            this.Controls.Add(this.boton_Buscar);
            this.Controls.Add(this.combo_Tipo_Cuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_tipo);
            this.Controls.Add(this.combo_Nro_Cuenta);
            this.Controls.Add(this.combo_pais_origen);
            this.Name = "BusquedaCuentas";
            this.Text = "Busqueda Cuentas";
            this.Load += new System.EventHandler(this.BusquedaCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_Nro_Cuenta;
        private System.Windows.Forms.ComboBox combo_tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label combo_Tipo_Cuenta;
        private System.Windows.Forms.Button boton_Reestablecer;
        private System.Windows.Forms.Button boton_Limpiar;
        private System.Windows.Forms.Button boton_Buscar;
        private System.Windows.Forms.Button boton_Eliminar;
        private System.Windows.Forms.Button boton_Editar;
        private System.Windows.Forms.Button boton_Volver;
        private System.Windows.Forms.Label label_estado;
        private System.Windows.Forms.Label combo_Tipo_Moneda;
        private System.Windows.Forms.ComboBox combo_moneda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combo_pais_origen2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn p;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais_asignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_cierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox pais_asignado_combo;
        private System.Windows.Forms.ComboBox combo_pais_origen;
        private System.Windows.Forms.ComboBox combo_estado;
    }
}
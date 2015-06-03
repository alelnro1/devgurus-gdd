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
            this.combo_pais_origen = new System.Windows.Forms.ComboBox();
            this.combo_Nro_Cuenta = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_Tipo_Cuenta = new System.Windows.Forms.Label();
            this.check_Habilitado = new System.Windows.Forms.CheckBox();
            this.check_Deshabilitado = new System.Windows.Forms.CheckBox();
            this.check_Pendiente = new System.Windows.Forms.CheckBox();
            this.check_Cerrada = new System.Windows.Forms.CheckBox();
            this.boton_Reestablecer = new System.Windows.Forms.Button();
            this.boton_Limpiar = new System.Windows.Forms.Button();
            this.boton_Buscar = new System.Windows.Forms.Button();
            this.boton_Eliminar = new System.Windows.Forms.Button();
            this.boton_Editar = new System.Windows.Forms.Button();
            this.boton_Volver = new System.Windows.Forms.Button();
            this.label_estado = new System.Windows.Forms.Label();
            this.lista_cuentas = new System.Windows.Forms.DataGridView();
            this.combo_Tipo_Moneda = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.ID_Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais_Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunciónExtraer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunciónTransferir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lista_cuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_pais_origen
            // 
            this.combo_pais_origen.FormattingEnabled = true;
            this.combo_pais_origen.Location = new System.Drawing.Point(175, 83);
            this.combo_pais_origen.Name = "combo_pais_origen";
            this.combo_pais_origen.Size = new System.Drawing.Size(121, 21);
            this.combo_pais_origen.TabIndex = 0;
            // 
            // combo_Nro_Cuenta
            // 
            this.combo_Nro_Cuenta.FormattingEnabled = true;
            this.combo_Nro_Cuenta.Location = new System.Drawing.Point(175, 37);
            this.combo_Nro_Cuenta.Name = "combo_Nro_Cuenta";
            this.combo_Nro_Cuenta.Size = new System.Drawing.Size(121, 21);
            this.combo_Nro_Cuenta.TabIndex = 1;
            this.combo_Nro_Cuenta.SelectedIndexChanged += new System.EventHandler(this.combo_Nro_Cuenta_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(175, 132);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero Cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pais Origen";
            // 
            // combo_Tipo_Cuenta
            // 
            this.combo_Tipo_Cuenta.AutoSize = true;
            this.combo_Tipo_Cuenta.Location = new System.Drawing.Point(73, 140);
            this.combo_Tipo_Cuenta.Name = "combo_Tipo_Cuenta";
            this.combo_Tipo_Cuenta.Size = new System.Drawing.Size(65, 13);
            this.combo_Tipo_Cuenta.TabIndex = 5;
            this.combo_Tipo_Cuenta.Text = "Tipo Cuenta";
            // 
            // check_Habilitado
            // 
            this.check_Habilitado.AutoSize = true;
            this.check_Habilitado.Location = new System.Drawing.Point(548, 56);
            this.check_Habilitado.Name = "check_Habilitado";
            this.check_Habilitado.Size = new System.Drawing.Size(73, 17);
            this.check_Habilitado.TabIndex = 7;
            this.check_Habilitado.Text = "Habilitado";
            this.check_Habilitado.UseVisualStyleBackColor = true;
            this.check_Habilitado.CheckedChanged += new System.EventHandler(this.check_Habilitado_CheckedChanged);
            // 
            // check_Deshabilitado
            // 
            this.check_Deshabilitado.AutoSize = true;
            this.check_Deshabilitado.Location = new System.Drawing.Point(548, 94);
            this.check_Deshabilitado.Name = "check_Deshabilitado";
            this.check_Deshabilitado.Size = new System.Drawing.Size(90, 17);
            this.check_Deshabilitado.TabIndex = 8;
            this.check_Deshabilitado.Text = "Deshabilitado";
            this.check_Deshabilitado.UseVisualStyleBackColor = true;
            this.check_Deshabilitado.CheckedChanged += new System.EventHandler(this.check_Deshabilitado_CheckedChanged);
            // 
            // check_Pendiente
            // 
            this.check_Pendiente.AutoSize = true;
            this.check_Pendiente.Location = new System.Drawing.Point(548, 132);
            this.check_Pendiente.Name = "check_Pendiente";
            this.check_Pendiente.Size = new System.Drawing.Size(74, 17);
            this.check_Pendiente.TabIndex = 9;
            this.check_Pendiente.Text = "Pendiente";
            this.check_Pendiente.UseVisualStyleBackColor = true;
            // 
            // check_Cerrada
            // 
            this.check_Cerrada.AutoSize = true;
            this.check_Cerrada.Location = new System.Drawing.Point(548, 170);
            this.check_Cerrada.Name = "check_Cerrada";
            this.check_Cerrada.Size = new System.Drawing.Size(63, 17);
            this.check_Cerrada.TabIndex = 10;
            this.check_Cerrada.Text = "Cerrada";
            this.check_Cerrada.UseVisualStyleBackColor = true;
            // 
            // boton_Reestablecer
            // 
            this.boton_Reestablecer.Location = new System.Drawing.Point(318, 239);
            this.boton_Reestablecer.Name = "boton_Reestablecer";
            this.boton_Reestablecer.Size = new System.Drawing.Size(128, 23);
            this.boton_Reestablecer.TabIndex = 223283;
            this.boton_Reestablecer.Text = "Reestablecer";
            this.boton_Reestablecer.UseVisualStyleBackColor = true;
            // 
            // boton_Limpiar
            // 
            this.boton_Limpiar.Location = new System.Drawing.Point(461, 239);
            this.boton_Limpiar.Name = "boton_Limpiar";
            this.boton_Limpiar.Size = new System.Drawing.Size(128, 23);
            this.boton_Limpiar.TabIndex = 223282;
            this.boton_Limpiar.Text = "Limpiar busqueda";
            this.boton_Limpiar.UseVisualStyleBackColor = true;
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
            // 
            // boton_Editar
            // 
            this.boton_Editar.Location = new System.Drawing.Point(470, 460);
            this.boton_Editar.Name = "boton_Editar";
            this.boton_Editar.Size = new System.Drawing.Size(128, 23);
            this.boton_Editar.TabIndex = 223285;
            this.boton_Editar.Text = "Editar";
            this.boton_Editar.UseVisualStyleBackColor = true;
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
            this.label_estado.Location = new System.Drawing.Point(467, 57);
            this.label_estado.Name = "label_estado";
            this.label_estado.Size = new System.Drawing.Size(40, 13);
            this.label_estado.TabIndex = 223287;
            this.label_estado.Text = "Estado";
            // 
            // lista_cuentas
            // 
            this.lista_cuentas.AllowUserToAddRows = false;
            this.lista_cuentas.AllowUserToDeleteRows = false;
            this.lista_cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista_cuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Cuenta,
            this.Pais_Origen,
            this.FunciónExtraer,
            this.Estado,
            this.FunciónTransferir});
            this.lista_cuentas.Location = new System.Drawing.Point(161, 305);
            this.lista_cuentas.Name = "lista_cuentas";
            this.lista_cuentas.Size = new System.Drawing.Size(450, 117);
            this.lista_cuentas.TabIndex = 223288;
            this.lista_cuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lista_cuentas_CellContentClick);
            // 
            // combo_Tipo_Moneda
            // 
            this.combo_Tipo_Moneda.AutoSize = true;
            this.combo_Tipo_Moneda.Location = new System.Drawing.Point(76, 182);
            this.combo_Tipo_Moneda.Name = "combo_Tipo_Moneda";
            this.combo_Tipo_Moneda.Size = new System.Drawing.Size(46, 13);
            this.combo_Tipo_Moneda.TabIndex = 223289;
            this.combo_Tipo_Moneda.Text = "Moneda";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(175, 182);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 223290;
            // 
            // ID_Cuenta
            // 
            this.ID_Cuenta.HeaderText = "ID_Cuenta";
            this.ID_Cuenta.Name = "ID_Cuenta";
            this.ID_Cuenta.ReadOnly = true;
            this.ID_Cuenta.Visible = false;
            // 
            // Pais_Origen
            // 
            this.Pais_Origen.HeaderText = "Pais_Origen";
            this.Pais_Origen.Name = "Pais_Origen";
            // 
            // FunciónExtraer
            // 
            this.FunciónExtraer.HeaderText = "Tipo Cuenta";
            this.FunciónExtraer.Name = "FunciónExtraer";
            this.FunciónExtraer.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Moneda";
            this.Estado.Name = "Estado";
            // 
            // FunciónTransferir
            // 
            this.FunciónTransferir.HeaderText = "Estado";
            this.FunciónTransferir.Name = "FunciónTransferir";
            this.FunciónTransferir.ReadOnly = true;
            // 
            // BusquedaCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 500);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.combo_Tipo_Moneda);
            this.Controls.Add(this.lista_cuentas);
            this.Controls.Add(this.label_estado);
            this.Controls.Add(this.boton_Eliminar);
            this.Controls.Add(this.boton_Editar);
            this.Controls.Add(this.boton_Volver);
            this.Controls.Add(this.boton_Reestablecer);
            this.Controls.Add(this.boton_Limpiar);
            this.Controls.Add(this.boton_Buscar);
            this.Controls.Add(this.check_Cerrada);
            this.Controls.Add(this.check_Pendiente);
            this.Controls.Add(this.check_Deshabilitado);
            this.Controls.Add(this.check_Habilitado);
            this.Controls.Add(this.combo_Tipo_Cuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.combo_Nro_Cuenta);
            this.Controls.Add(this.combo_pais_origen);
            this.Name = "BusquedaCuentas";
            this.Text = "BusquedaCuentas";
            ((System.ComponentModel.ISupportInitialize)(this.lista_cuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_pais_origen;
        private System.Windows.Forms.ComboBox combo_Nro_Cuenta;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label combo_Tipo_Cuenta;
        private System.Windows.Forms.CheckBox check_Habilitado;
        private System.Windows.Forms.CheckBox check_Deshabilitado;
        private System.Windows.Forms.CheckBox check_Pendiente;
        private System.Windows.Forms.CheckBox check_Cerrada;
        private System.Windows.Forms.Button boton_Reestablecer;
        private System.Windows.Forms.Button boton_Limpiar;
        private System.Windows.Forms.Button boton_Buscar;
        private System.Windows.Forms.Button boton_Eliminar;
        private System.Windows.Forms.Button boton_Editar;
        private System.Windows.Forms.Button boton_Volver;
        private System.Windows.Forms.Label label_estado;
        private System.Windows.Forms.DataGridView lista_cuentas;
        private System.Windows.Forms.Label combo_Tipo_Moneda;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais_Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunciónExtraer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunciónTransferir;
    }
}
namespace PagoElectronico.ABM_Cliente
{
    partial class BusquedaClientes
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
            this.combo_nombre = new System.Windows.Forms.ComboBox();
            this.combo_apellido = new System.Windows.Forms.ComboBox();
            this.combo_tipo_doc = new System.Windows.Forms.ComboBox();
            this.combo_nro_doc = new System.Windows.Forms.ComboBox();
            this.combo_email = new System.Windows.Forms.ComboBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boton_Eliminar = new System.Windows.Forms.Button();
            this.boton_Reestablecer = new System.Windows.Forms.Button();
            this.boton_Editar = new System.Windows.Forms.Button();
            this.boton_Volver = new System.Windows.Forms.Button();
            this.lista_clientes = new System.Windows.Forms.DataGridView();
            this.boton_Limpiar = new System.Windows.Forms.Button();
            this.boton_Buscar = new System.Windows.Forms.Button();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_identificacion_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pais_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piso_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depto_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalidad_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nac_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lista_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_nombre
            // 
            this.combo_nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_nombre.FormattingEnabled = true;
            this.combo_nombre.Location = new System.Drawing.Point(609, 40);
            this.combo_nombre.Name = "combo_nombre";
            this.combo_nombre.Size = new System.Drawing.Size(135, 21);
            this.combo_nombre.TabIndex = 0;
            // 
            // combo_apellido
            // 
            this.combo_apellido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_apellido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_apellido.FormattingEnabled = true;
            this.combo_apellido.Location = new System.Drawing.Point(609, 94);
            this.combo_apellido.Name = "combo_apellido";
            this.combo_apellido.Size = new System.Drawing.Size(135, 21);
            this.combo_apellido.TabIndex = 1;
            // 
            // combo_tipo_doc
            // 
            this.combo_tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_tipo_doc.FormattingEnabled = true;
            this.combo_tipo_doc.Location = new System.Drawing.Point(609, 145);
            this.combo_tipo_doc.Name = "combo_tipo_doc";
            this.combo_tipo_doc.Size = new System.Drawing.Size(135, 21);
            this.combo_tipo_doc.TabIndex = 2;
            // 
            // combo_nro_doc
            // 
            this.combo_nro_doc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_nro_doc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_nro_doc.FormattingEnabled = true;
            this.combo_nro_doc.Location = new System.Drawing.Point(609, 192);
            this.combo_nro_doc.Name = "combo_nro_doc";
            this.combo_nro_doc.Size = new System.Drawing.Size(135, 21);
            this.combo_nro_doc.TabIndex = 3;
            // 
            // combo_email
            // 
            this.combo_email.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_email.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_email.FormattingEnabled = true;
            this.combo_email.Location = new System.Drawing.Point(609, 234);
            this.combo_email.Name = "combo_email";
            this.combo_email.Size = new System.Drawing.Size(218, 21);
            this.combo_email.TabIndex = 4;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(479, 40);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 5;
            this.Nombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo de Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nro De Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Apellido";
            // 
            // boton_Eliminar
            // 
            this.boton_Eliminar.Location = new System.Drawing.Point(851, 125);
            this.boton_Eliminar.Name = "boton_Eliminar";
            this.boton_Eliminar.Size = new System.Drawing.Size(147, 35);
            this.boton_Eliminar.TabIndex = 223288;
            this.boton_Eliminar.Text = "Eliminar";
            this.boton_Eliminar.UseVisualStyleBackColor = true;
            this.boton_Eliminar.Click += new System.EventHandler(this.boton_Eliminar_Click);
            // 
            // boton_Reestablecer
            // 
            this.boton_Reestablecer.Location = new System.Drawing.Point(219, 115);
            this.boton_Reestablecer.Name = "boton_Reestablecer";
            this.boton_Reestablecer.Size = new System.Drawing.Size(147, 35);
            this.boton_Reestablecer.TabIndex = 223287;
            this.boton_Reestablecer.Text = "Reestablecer";
            this.boton_Reestablecer.UseVisualStyleBackColor = true;
            this.boton_Reestablecer.Click += new System.EventHandler(this.boton_Reestablecer_Click);
            // 
            // boton_Editar
            // 
            this.boton_Editar.Location = new System.Drawing.Point(851, 25);
            this.boton_Editar.Name = "boton_Editar";
            this.boton_Editar.Size = new System.Drawing.Size(147, 35);
            this.boton_Editar.TabIndex = 223286;
            this.boton_Editar.Text = "Editar";
            this.boton_Editar.UseVisualStyleBackColor = true;
            this.boton_Editar.Click += new System.EventHandler(this.boton_Editar_Click);
            // 
            // boton_Volver
            // 
            this.boton_Volver.Location = new System.Drawing.Point(851, 217);
            this.boton_Volver.Name = "boton_Volver";
            this.boton_Volver.Size = new System.Drawing.Size(147, 35);
            this.boton_Volver.TabIndex = 223285;
            this.boton_Volver.Text = "Volver";
            this.boton_Volver.UseVisualStyleBackColor = true;
            // 
            // lista_clientes
            // 
            this.lista_clientes.AllowUserToAddRows = false;
            this.lista_clientes.AllowUserToDeleteRows = false;
            this.lista_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.nombre_cliente,
            this.apellido_cliente,
            this.tipo_doc,
            this.nro_identificacion_cliente,
            this.pais_cliente,
            this.localidad_cliente,
            this.calle_cliente,
            this.domicilio_num,
            this.piso_cliente,
            this.depto_cliente,
            this.nacionalidad_cliente,
            this.fecha_nac_cliente,
            this.mail,
            this.cliente_usuario});
            this.lista_clientes.Location = new System.Drawing.Point(12, 318);
            this.lista_clientes.Name = "lista_clientes";
            this.lista_clientes.Size = new System.Drawing.Size(1490, 189);
            this.lista_clientes.TabIndex = 223284;
            // 
            // boton_Limpiar
            // 
            this.boton_Limpiar.Location = new System.Drawing.Point(219, 220);
            this.boton_Limpiar.Name = "boton_Limpiar";
            this.boton_Limpiar.Size = new System.Drawing.Size(147, 35);
            this.boton_Limpiar.TabIndex = 223283;
            this.boton_Limpiar.Text = "Limpiar busqueda";
            this.boton_Limpiar.UseVisualStyleBackColor = true;
            this.boton_Limpiar.Click += new System.EventHandler(this.boton_Limpiar_Click);
            // 
            // boton_Buscar
            // 
            this.boton_Buscar.Location = new System.Drawing.Point(219, 25);
            this.boton_Buscar.Name = "boton_Buscar";
            this.boton_Buscar.Size = new System.Drawing.Size(147, 35);
            this.boton_Buscar.TabIndex = 223282;
            this.boton_Buscar.Text = "Buscar";
            this.boton_Buscar.UseVisualStyleBackColor = true;
            this.boton_Buscar.Click += new System.EventHandler(this.boton_Buscar_Click);
            // 
            // id_cliente
            // 
            this.id_cliente.HeaderText = "Cliente Id";
            this.id_cliente.Name = "id_cliente";
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.HeaderText = "Nombre";
            this.nombre_cliente.Name = "nombre_cliente";
            // 
            // apellido_cliente
            // 
            this.apellido_cliente.HeaderText = "Apellido";
            this.apellido_cliente.Name = "apellido_cliente";
            // 
            // tipo_doc
            // 
            this.tipo_doc.HeaderText = "Tipo Documento";
            this.tipo_doc.Name = "tipo_doc";
            // 
            // nro_identificacion_cliente
            // 
            this.nro_identificacion_cliente.HeaderText = "Nro Identificacion";
            this.nro_identificacion_cliente.Name = "nro_identificacion_cliente";
            // 
            // pais_cliente
            // 
            this.pais_cliente.HeaderText = "Pais";
            this.pais_cliente.Name = "pais_cliente";
            // 
            // localidad_cliente
            // 
            this.localidad_cliente.HeaderText = "Localidad";
            this.localidad_cliente.Name = "localidad_cliente";
            // 
            // calle_cliente
            // 
            this.calle_cliente.HeaderText = "Calle";
            this.calle_cliente.Name = "calle_cliente";
            // 
            // domicilio_num
            // 
            this.domicilio_num.HeaderText = "Nro Domicilio";
            this.domicilio_num.Name = "domicilio_num";
            // 
            // piso_cliente
            // 
            this.piso_cliente.HeaderText = "Piso";
            this.piso_cliente.Name = "piso_cliente";
            // 
            // depto_cliente
            // 
            this.depto_cliente.HeaderText = "Depto";
            this.depto_cliente.Name = "depto_cliente";
            // 
            // nacionalidad_cliente
            // 
            this.nacionalidad_cliente.HeaderText = "Nacionalidad";
            this.nacionalidad_cliente.Name = "nacionalidad_cliente";
            // 
            // fecha_nac_cliente
            // 
            this.fecha_nac_cliente.HeaderText = "Fecha Nacimiento";
            this.fecha_nac_cliente.Name = "fecha_nac_cliente";
            // 
            // mail
            // 
            this.mail.HeaderText = "Email";
            this.mail.Name = "mail";
            // 
            // cliente_usuario
            // 
            this.cliente_usuario.HeaderText = "Usuario";
            this.cliente_usuario.Name = "cliente_usuario";
            // 
            // BusquedaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 535);
            this.Controls.Add(this.boton_Eliminar);
            this.Controls.Add(this.boton_Reestablecer);
            this.Controls.Add(this.boton_Editar);
            this.Controls.Add(this.boton_Volver);
            this.Controls.Add(this.lista_clientes);
            this.Controls.Add(this.boton_Limpiar);
            this.Controls.Add(this.boton_Buscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.combo_email);
            this.Controls.Add(this.combo_nro_doc);
            this.Controls.Add(this.combo_tipo_doc);
            this.Controls.Add(this.combo_apellido);
            this.Controls.Add(this.combo_nombre);
            this.Name = "BusquedaClientes";
            this.Text = "BusquedaClientes";
            this.Load += new System.EventHandler(this.BusquedaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lista_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_nombre;
        private System.Windows.Forms.ComboBox combo_apellido;
        private System.Windows.Forms.ComboBox combo_tipo_doc;
        private System.Windows.Forms.ComboBox combo_nro_doc;
        private System.Windows.Forms.ComboBox combo_email;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button boton_Eliminar;
        private System.Windows.Forms.Button boton_Reestablecer;
        private System.Windows.Forms.Button boton_Editar;
        private System.Windows.Forms.Button boton_Volver;
        private System.Windows.Forms.DataGridView lista_clientes;
        private System.Windows.Forms.Button boton_Limpiar;
        private System.Windows.Forms.Button boton_Buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_identificacion_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn piso_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn depto_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacionalidad_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nac_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente_usuario;
    }
}
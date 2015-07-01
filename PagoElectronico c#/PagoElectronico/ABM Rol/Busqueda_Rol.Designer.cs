namespace PagoElectronico
{
    partial class Busqueda_Rol
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
            this.group_Datos = new System.Windows.Forms.GroupBox();
            this.rol_Name = new System.Windows.Forms.ComboBox();
            this.check_Func_Estadisticas = new System.Windows.Forms.CheckBox();
            this.check_Func_Saldo = new System.Windows.Forms.CheckBox();
            this.check_asociar_tarjeta = new System.Windows.Forms.CheckBox();
            this.check_ABM_Cuentas = new System.Windows.Forms.CheckBox();
            this.check_ABM_Client = new System.Windows.Forms.CheckBox();
            this.check_ABM_User = new System.Windows.Forms.CheckBox();
            this.check_ABM_Roles = new System.Windows.Forms.CheckBox();
            this.check_Depos = new System.Windows.Forms.CheckBox();
            this.check_Transf = new System.Windows.Forms.CheckBox();
            this.check_Extraer = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.check_No_Activo = new System.Windows.Forms.CheckBox();
            this.check_Activo = new System.Windows.Forms.CheckBox();
            this.L_Nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boton_Buscar = new System.Windows.Forms.Button();
            this.boton_Limpiar = new System.Windows.Forms.Button();
            this.lista_Roles = new System.Windows.Forms.DataGridView();
            this.ID_Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunciónExtraer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunciónTransferir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunciónDepositar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionABMRoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionABMCuentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionABMClientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionABMUsuarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionAsociarTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boton_Editar = new System.Windows.Forms.Button();
            this.boton_Volver = new System.Windows.Forms.Button();
            this.boton_Reestablecer = new System.Windows.Forms.Button();
            this.boton_Eliminar = new System.Windows.Forms.Button();
            this.group_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista_Roles)).BeginInit();
            this.SuspendLayout();
            // 
            // group_Datos
            // 
            this.group_Datos.Controls.Add(this.rol_Name);
            this.group_Datos.Controls.Add(this.check_Func_Estadisticas);
            this.group_Datos.Controls.Add(this.check_Func_Saldo);
            this.group_Datos.Controls.Add(this.check_asociar_tarjeta);
            this.group_Datos.Controls.Add(this.check_ABM_Cuentas);
            this.group_Datos.Controls.Add(this.check_ABM_Client);
            this.group_Datos.Controls.Add(this.check_ABM_User);
            this.group_Datos.Controls.Add(this.check_ABM_Roles);
            this.group_Datos.Controls.Add(this.check_Depos);
            this.group_Datos.Controls.Add(this.check_Transf);
            this.group_Datos.Controls.Add(this.check_Extraer);
            this.group_Datos.Controls.Add(this.label2);
            this.group_Datos.Controls.Add(this.check_No_Activo);
            this.group_Datos.Controls.Add(this.check_Activo);
            this.group_Datos.Controls.Add(this.L_Nombre);
            this.group_Datos.Controls.Add(this.label1);
            this.group_Datos.Location = new System.Drawing.Point(22, 13);
            this.group_Datos.Name = "group_Datos";
            this.group_Datos.Size = new System.Drawing.Size(676, 252);
            this.group_Datos.TabIndex = 223274;
            this.group_Datos.TabStop = false;
            this.group_Datos.Text = "Filtros de busqueda";
            this.group_Datos.Enter += new System.EventHandler(this.group_Datos_Enter);
            // 
            // rol_Name
            // 
            this.rol_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rol_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rol_Name.FormattingEnabled = true;
            this.rol_Name.Location = new System.Drawing.Point(111, 30);
            this.rol_Name.MaxLength = 100;
            this.rol_Name.Name = "rol_Name";
            this.rol_Name.Size = new System.Drawing.Size(194, 21);
            this.rol_Name.TabIndex = 223303;
            // 
            // check_Func_Estadisticas
            // 
            this.check_Func_Estadisticas.AutoSize = true;
            this.check_Func_Estadisticas.Location = new System.Drawing.Point(126, 199);
            this.check_Func_Estadisticas.Name = "check_Func_Estadisticas";
            this.check_Func_Estadisticas.Size = new System.Drawing.Size(123, 17);
            this.check_Func_Estadisticas.TabIndex = 223302;
            this.check_Func_Estadisticas.Text = "Generar Estadisticas";
            this.check_Func_Estadisticas.UseVisualStyleBackColor = true;
            // 
            // check_Func_Saldo
            // 
            this.check_Func_Saldo.AutoSize = true;
            this.check_Func_Saldo.Location = new System.Drawing.Point(278, 199);
            this.check_Func_Saldo.Name = "check_Func_Saldo";
            this.check_Func_Saldo.Size = new System.Drawing.Size(100, 17);
            this.check_Func_Saldo.TabIndex = 223301;
            this.check_Func_Saldo.Text = "Consultar Saldo";
            this.check_Func_Saldo.UseVisualStyleBackColor = true;
            // 
            // check_asociar_tarjeta
            // 
            this.check_asociar_tarjeta.AutoSize = true;
            this.check_asociar_tarjeta.Location = new System.Drawing.Point(278, 176);
            this.check_asociar_tarjeta.Name = "check_asociar_tarjeta";
            this.check_asociar_tarjeta.Size = new System.Drawing.Size(97, 17);
            this.check_asociar_tarjeta.TabIndex = 223300;
            this.check_asociar_tarjeta.Text = "Asociar Tarjeta";
            this.check_asociar_tarjeta.UseVisualStyleBackColor = true;
            // 
            // check_ABM_Cuentas
            // 
            this.check_ABM_Cuentas.AutoSize = true;
            this.check_ABM_Cuentas.Location = new System.Drawing.Point(553, 176);
            this.check_ABM_Cuentas.Name = "check_ABM_Cuentas";
            this.check_ABM_Cuentas.Size = new System.Drawing.Size(91, 17);
            this.check_ABM_Cuentas.TabIndex = 223283;
            this.check_ABM_Cuentas.Text = "ABM Cuentas";
            this.check_ABM_Cuentas.UseVisualStyleBackColor = true;
            // 
            // check_ABM_Client
            // 
            this.check_ABM_Client.AutoSize = true;
            this.check_ABM_Client.Location = new System.Drawing.Point(423, 199);
            this.check_ABM_Client.Name = "check_ABM_Client";
            this.check_ABM_Client.Size = new System.Drawing.Size(89, 17);
            this.check_ABM_Client.TabIndex = 223282;
            this.check_ABM_Client.Text = "ABM Clientes";
            this.check_ABM_Client.UseVisualStyleBackColor = true;
            // 
            // check_ABM_User
            // 
            this.check_ABM_User.AutoSize = true;
            this.check_ABM_User.Location = new System.Drawing.Point(423, 176);
            this.check_ABM_User.Name = "check_ABM_User";
            this.check_ABM_User.Size = new System.Drawing.Size(93, 17);
            this.check_ABM_User.TabIndex = 223281;
            this.check_ABM_User.Text = "ABM Usuarios";
            this.check_ABM_User.UseVisualStyleBackColor = true;
            // 
            // check_ABM_Roles
            // 
            this.check_ABM_Roles.AutoSize = true;
            this.check_ABM_Roles.Location = new System.Drawing.Point(553, 199);
            this.check_ABM_Roles.Name = "check_ABM_Roles";
            this.check_ABM_Roles.Size = new System.Drawing.Size(79, 17);
            this.check_ABM_Roles.TabIndex = 223280;
            this.check_ABM_Roles.Text = "ABM Roles";
            this.check_ABM_Roles.UseVisualStyleBackColor = true;
            // 
            // check_Depos
            // 
            this.check_Depos.AutoSize = true;
            this.check_Depos.Location = new System.Drawing.Point(126, 176);
            this.check_Depos.Name = "check_Depos";
            this.check_Depos.Size = new System.Drawing.Size(71, 17);
            this.check_Depos.TabIndex = 223279;
            this.check_Depos.Text = "Depositar";
            this.check_Depos.UseVisualStyleBackColor = true;
            // 
            // check_Transf
            // 
            this.check_Transf.AutoSize = true;
            this.check_Transf.Location = new System.Drawing.Point(37, 199);
            this.check_Transf.Name = "check_Transf";
            this.check_Transf.Size = new System.Drawing.Size(70, 17);
            this.check_Transf.TabIndex = 223278;
            this.check_Transf.Text = "Transferir";
            this.check_Transf.UseVisualStyleBackColor = true;
            // 
            // check_Extraer
            // 
            this.check_Extraer.AutoSize = true;
            this.check_Extraer.Location = new System.Drawing.Point(38, 176);
            this.check_Extraer.Name = "check_Extraer";
            this.check_Extraer.Size = new System.Drawing.Size(59, 17);
            this.check_Extraer.TabIndex = 223277;
            this.check_Extraer.Text = "Extraer";
            this.check_Extraer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 223276;
            this.label2.Text = "Filtro por función";
            // 
            // check_No_Activo
            // 
            this.check_No_Activo.AutoSize = true;
            this.check_No_Activo.Location = new System.Drawing.Point(37, 105);
            this.check_No_Activo.Name = "check_No_Activo";
            this.check_No_Activo.Size = new System.Drawing.Size(73, 17);
            this.check_No_Activo.TabIndex = 223274;
            this.check_No_Activo.Text = "No Activo";
            this.check_No_Activo.UseVisualStyleBackColor = true;
            // 
            // check_Activo
            // 
            this.check_Activo.AutoSize = true;
            this.check_Activo.Location = new System.Drawing.Point(126, 105);
            this.check_Activo.Name = "check_Activo";
            this.check_Activo.Size = new System.Drawing.Size(56, 17);
            this.check_Activo.TabIndex = 223273;
            this.check_Activo.Text = "Activo";
            this.check_Activo.UseVisualStyleBackColor = true;
            // 
            // L_Nombre
            // 
            this.L_Nombre.AutoSize = true;
            this.L_Nombre.ForeColor = System.Drawing.Color.Black;
            this.L_Nombre.Location = new System.Drawing.Point(24, 33);
            this.L_Nombre.Name = "L_Nombre";
            this.L_Nombre.Size = new System.Drawing.Size(81, 13);
            this.L_Nombre.TabIndex = 223269;
            this.L_Nombre.Text = "Nombre de Rol:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 223272;
            this.label1.Text = "Filtro por estado";
            // 
            // boton_Buscar
            // 
            this.boton_Buscar.Location = new System.Drawing.Point(722, 55);
            this.boton_Buscar.Name = "boton_Buscar";
            this.boton_Buscar.Size = new System.Drawing.Size(159, 37);
            this.boton_Buscar.TabIndex = 223275;
            this.boton_Buscar.Text = "Buscar";
            this.boton_Buscar.UseVisualStyleBackColor = true;
            this.boton_Buscar.Click += new System.EventHandler(this.boton_Buscar_Click);
            // 
            // boton_Limpiar
            // 
            this.boton_Limpiar.Location = new System.Drawing.Point(901, 208);
            this.boton_Limpiar.Name = "boton_Limpiar";
            this.boton_Limpiar.Size = new System.Drawing.Size(139, 29);
            this.boton_Limpiar.TabIndex = 223276;
            this.boton_Limpiar.Text = "Limpiar busqueda";
            this.boton_Limpiar.UseVisualStyleBackColor = true;
            this.boton_Limpiar.Click += new System.EventHandler(this.boton_Limpiar_Click);
            // 
            // lista_Roles
            // 
            this.lista_Roles.AllowUserToAddRows = false;
            this.lista_Roles.AllowUserToDeleteRows = false;
            this.lista_Roles.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lista_Roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista_Roles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Rol,
            this.Nombre,
            this.Estado,
            this.FunciónExtraer,
            this.FunciónTransferir,
            this.FunciónDepositar,
            this.FuncionABMRoles,
            this.FuncionABMCuentas,
            this.FuncionABMClientes,
            this.FuncionABMUsuarios,
            this.FuncionAsociarTarjeta});
            this.lista_Roles.Location = new System.Drawing.Point(30, 293);
            this.lista_Roles.Name = "lista_Roles";
            this.lista_Roles.Size = new System.Drawing.Size(1044, 198);
            this.lista_Roles.TabIndex = 223277;
            this.lista_Roles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lista_Roles_CellContentClick);
            // 
            // ID_Rol
            // 
            this.ID_Rol.HeaderText = "ID_Rol";
            this.ID_Rol.Name = "ID_Rol";
            this.ID_Rol.ReadOnly = true;
            this.ID_Rol.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // FunciónExtraer
            // 
            this.FunciónExtraer.HeaderText = "Función Extraer";
            this.FunciónExtraer.Name = "FunciónExtraer";
            this.FunciónExtraer.ReadOnly = true;
            // 
            // FunciónTransferir
            // 
            this.FunciónTransferir.HeaderText = "Función Transferir";
            this.FunciónTransferir.Name = "FunciónTransferir";
            this.FunciónTransferir.ReadOnly = true;
            // 
            // FunciónDepositar
            // 
            this.FunciónDepositar.HeaderText = "Función Depositar";
            this.FunciónDepositar.Name = "FunciónDepositar";
            this.FunciónDepositar.ReadOnly = true;
            // 
            // FuncionABMRoles
            // 
            this.FuncionABMRoles.HeaderText = "ABM Roles";
            this.FuncionABMRoles.Name = "FuncionABMRoles";
            this.FuncionABMRoles.ReadOnly = true;
            // 
            // FuncionABMCuentas
            // 
            this.FuncionABMCuentas.HeaderText = "ABM Cuentas";
            this.FuncionABMCuentas.Name = "FuncionABMCuentas";
            this.FuncionABMCuentas.ReadOnly = true;
            // 
            // FuncionABMClientes
            // 
            this.FuncionABMClientes.HeaderText = "ABM Clientes";
            this.FuncionABMClientes.Name = "FuncionABMClientes";
            this.FuncionABMClientes.ReadOnly = true;
            // 
            // FuncionABMUsuarios
            // 
            this.FuncionABMUsuarios.HeaderText = "ABM Usuarios";
            this.FuncionABMUsuarios.Name = "FuncionABMUsuarios";
            // 
            // FuncionAsociarTarjeta
            // 
            this.FuncionAsociarTarjeta.HeaderText = "Función Asociar Tarjeta";
            this.FuncionAsociarTarjeta.Name = "FuncionAsociarTarjeta";
            // 
            // boton_Editar
            // 
            this.boton_Editar.Location = new System.Drawing.Point(722, 126);
            this.boton_Editar.Name = "boton_Editar";
            this.boton_Editar.Size = new System.Drawing.Size(159, 37);
            this.boton_Editar.TabIndex = 223279;
            this.boton_Editar.Text = "Editar";
            this.boton_Editar.UseVisualStyleBackColor = true;
            this.boton_Editar.Click += new System.EventHandler(this.boton_Editar_Click);
            // 
            // boton_Volver
            // 
            this.boton_Volver.Location = new System.Drawing.Point(950, 12);
            this.boton_Volver.Name = "boton_Volver";
            this.boton_Volver.Size = new System.Drawing.Size(139, 29);
            this.boton_Volver.TabIndex = 223278;
            this.boton_Volver.Text = "Volver";
            this.boton_Volver.UseVisualStyleBackColor = true;
            this.boton_Volver.Click += new System.EventHandler(this.boton_Volver_Click);
            // 
            // boton_Reestablecer
            // 
            this.boton_Reestablecer.Location = new System.Drawing.Point(901, 137);
            this.boton_Reestablecer.Name = "boton_Reestablecer";
            this.boton_Reestablecer.Size = new System.Drawing.Size(139, 29);
            this.boton_Reestablecer.TabIndex = 223280;
            this.boton_Reestablecer.Text = "Reestablecer Filtros";
            this.boton_Reestablecer.UseVisualStyleBackColor = true;
            this.boton_Reestablecer.Click += new System.EventHandler(this.boton_Reestablecer_Click);
            // 
            // boton_Eliminar
            // 
            this.boton_Eliminar.Location = new System.Drawing.Point(722, 208);
            this.boton_Eliminar.Name = "boton_Eliminar";
            this.boton_Eliminar.Size = new System.Drawing.Size(159, 37);
            this.boton_Eliminar.TabIndex = 223281;
            this.boton_Eliminar.Text = "Dar de Baja";
            this.boton_Eliminar.UseVisualStyleBackColor = true;
            this.boton_Eliminar.Click += new System.EventHandler(this.boton_Eliminar_Click);
            // 
            // Busqueda_Rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 511);
            this.Controls.Add(this.boton_Eliminar);
            this.Controls.Add(this.boton_Reestablecer);
            this.Controls.Add(this.boton_Editar);
            this.Controls.Add(this.boton_Volver);
            this.Controls.Add(this.lista_Roles);
            this.Controls.Add(this.boton_Limpiar);
            this.Controls.Add(this.boton_Buscar);
            this.Controls.Add(this.group_Datos);
            this.Name = "Busqueda_Rol";
            this.Text = "Busqueda de Roles";
            this.group_Datos.ResumeLayout(false);
            this.group_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista_Roles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_Datos;
        private System.Windows.Forms.Label L_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox check_No_Activo;
        private System.Windows.Forms.CheckBox check_Activo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boton_Buscar;
        private System.Windows.Forms.Button boton_Limpiar;
        private System.Windows.Forms.DataGridView lista_Roles;
        private System.Windows.Forms.Button boton_Editar;
        private System.Windows.Forms.Button boton_Volver;
        private System.Windows.Forms.Button boton_Reestablecer;
        private System.Windows.Forms.CheckBox check_ABM_Cuentas;
        private System.Windows.Forms.CheckBox check_ABM_Client;
        private System.Windows.Forms.CheckBox check_ABM_User;
        private System.Windows.Forms.CheckBox check_ABM_Roles;
        private System.Windows.Forms.CheckBox check_Depos;
        private System.Windows.Forms.CheckBox check_Transf;
        private System.Windows.Forms.CheckBox check_Extraer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunciónExtraer;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunciónTransferir;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunciónDepositar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncionABMRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncionABMCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncionABMClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncionABMUsuarios;
        private System.Windows.Forms.Button boton_Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncionAsociarTarjeta;
        private System.Windows.Forms.CheckBox check_asociar_tarjeta;
        private System.Windows.Forms.CheckBox check_Func_Estadisticas;
        private System.Windows.Forms.CheckBox check_Func_Saldo;
        private System.Windows.Forms.ComboBox rol_Name;
    }
}
namespace PagoElectronico
{
    partial class EditarRol
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
            this.boton_Crear = new System.Windows.Forms.Button();
            this.boton_Cancelar = new System.Windows.Forms.Button();
            this.group_Datos = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.combo_Estado = new System.Windows.Forms.ComboBox();
            this.L_Nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.group_Func = new System.Windows.Forms.GroupBox();
            this.check_asociar_tarjeta = new System.Windows.Forms.CheckBox();
            this.check_ABM_Cuentas = new System.Windows.Forms.CheckBox();
            this.check_ABM_Client = new System.Windows.Forms.CheckBox();
            this.check_ABM_User = new System.Windows.Forms.CheckBox();
            this.check_ABM_Roles = new System.Windows.Forms.CheckBox();
            this.check_Depos = new System.Windows.Forms.CheckBox();
            this.check_Transf = new System.Windows.Forms.CheckBox();
            this.check_Extraer = new System.Windows.Forms.CheckBox();
            this.check_Func_Saldo = new System.Windows.Forms.CheckBox();
            this.check_Func_Estadisticas = new System.Windows.Forms.CheckBox();
            this.boton_Eliminar = new System.Windows.Forms.Button();
            this.group_Datos.SuspendLayout();
            this.group_Func.SuspendLayout();
            this.SuspendLayout();
            // 
            // boton_Crear
            // 
            this.boton_Crear.Location = new System.Drawing.Point(297, 343);
            this.boton_Crear.Name = "boton_Crear";
            this.boton_Crear.Size = new System.Drawing.Size(101, 28);
            this.boton_Crear.TabIndex = 223279;
            this.boton_Crear.Text = "Guardar cambios";
            this.boton_Crear.UseVisualStyleBackColor = true;
            this.boton_Crear.Click += new System.EventHandler(this.boton_Crear_Click);
            // 
            // boton_Cancelar
            // 
            this.boton_Cancelar.Location = new System.Drawing.Point(55, 343);
            this.boton_Cancelar.Name = "boton_Cancelar";
            this.boton_Cancelar.Size = new System.Drawing.Size(101, 28);
            this.boton_Cancelar.TabIndex = 223278;
            this.boton_Cancelar.Text = "Cancelar edición";
            this.boton_Cancelar.UseVisualStyleBackColor = true;
            this.boton_Cancelar.Click += new System.EventHandler(this.boton_Cancelar_Click);
            // 
            // group_Datos
            // 
            this.group_Datos.Controls.Add(this.comboBox1);
            this.group_Datos.Controls.Add(this.combo_Estado);
            this.group_Datos.Controls.Add(this.L_Nombre);
            this.group_Datos.Controls.Add(this.label1);
            this.group_Datos.Location = new System.Drawing.Point(37, 13);
            this.group_Datos.Name = "group_Datos";
            this.group_Datos.Size = new System.Drawing.Size(385, 110);
            this.group_Datos.TabIndex = 223277;
            this.group_Datos.TabStop = false;
            this.group_Datos.Text = "Datos del Rol";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Activo",
            "No activo"});
            this.comboBox1.Location = new System.Drawing.Point(137, 30);
            this.comboBox1.MaxLength = 100;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 21);
            this.comboBox1.TabIndex = 223274;
            // 
            // combo_Estado
            // 
            this.combo_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Estado.FormattingEnabled = true;
            this.combo_Estado.Items.AddRange(new object[] {
            "Activo",
            "No activo"});
            this.combo_Estado.Location = new System.Drawing.Point(137, 65);
            this.combo_Estado.MaxLength = 100;
            this.combo_Estado.Name = "combo_Estado";
            this.combo_Estado.Size = new System.Drawing.Size(194, 21);
            this.combo_Estado.TabIndex = 223273;
            this.combo_Estado.SelectedIndexChanged += new System.EventHandler(this.combo_Estado_SelectedIndexChanged);
            // 
            // L_Nombre
            // 
            this.L_Nombre.AutoSize = true;
            this.L_Nombre.ForeColor = System.Drawing.Color.Black;
            this.L_Nombre.Location = new System.Drawing.Point(38, 33);
            this.L_Nombre.Name = "L_Nombre";
            this.L_Nombre.Size = new System.Drawing.Size(81, 13);
            this.L_Nombre.TabIndex = 223269;
            this.L_Nombre.Text = "Nombre de Rol:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 223272;
            this.label1.Text = "Estado del Rol:";
            // 
            // group_Func
            // 
            this.group_Func.Controls.Add(this.boton_Eliminar);
            this.group_Func.Controls.Add(this.check_Func_Estadisticas);
            this.group_Func.Controls.Add(this.check_Func_Saldo);
            this.group_Func.Controls.Add(this.check_asociar_tarjeta);
            this.group_Func.Controls.Add(this.check_ABM_Cuentas);
            this.group_Func.Controls.Add(this.check_ABM_Client);
            this.group_Func.Controls.Add(this.check_ABM_User);
            this.group_Func.Controls.Add(this.check_ABM_Roles);
            this.group_Func.Controls.Add(this.check_Depos);
            this.group_Func.Controls.Add(this.check_Transf);
            this.group_Func.Controls.Add(this.check_Extraer);
            this.group_Func.Location = new System.Drawing.Point(37, 141);
            this.group_Func.Margin = new System.Windows.Forms.Padding(2);
            this.group_Func.Name = "group_Func";
            this.group_Func.Padding = new System.Windows.Forms.Padding(2);
            this.group_Func.Size = new System.Drawing.Size(385, 182);
            this.group_Func.TabIndex = 223276;
            this.group_Func.TabStop = false;
            this.group_Func.Text = "Funciones del Rol";
            this.group_Func.Enter += new System.EventHandler(this.group_Func_Enter);
            // 
            // check_asociar_tarjeta
            // 
            this.check_asociar_tarjeta.AutoSize = true;
            this.check_asociar_tarjeta.Location = new System.Drawing.Point(41, 157);
            this.check_asociar_tarjeta.Name = "check_asociar_tarjeta";
            this.check_asociar_tarjeta.Size = new System.Drawing.Size(97, 17);
            this.check_asociar_tarjeta.TabIndex = 223299;
            this.check_asociar_tarjeta.Text = "Asociar Tarjeta";
            this.check_asociar_tarjeta.UseVisualStyleBackColor = true;
            // 
            // check_ABM_Cuentas
            // 
            this.check_ABM_Cuentas.AutoSize = true;
            this.check_ABM_Cuentas.Location = new System.Drawing.Point(41, 138);
            this.check_ABM_Cuentas.Name = "check_ABM_Cuentas";
            this.check_ABM_Cuentas.Size = new System.Drawing.Size(91, 17);
            this.check_ABM_Cuentas.TabIndex = 223290;
            this.check_ABM_Cuentas.Text = "ABM Cuentas";
            this.check_ABM_Cuentas.UseVisualStyleBackColor = true;
            // 
            // check_ABM_Client
            // 
            this.check_ABM_Client.AutoSize = true;
            this.check_ABM_Client.Location = new System.Drawing.Point(41, 118);
            this.check_ABM_Client.Name = "check_ABM_Client";
            this.check_ABM_Client.Size = new System.Drawing.Size(89, 17);
            this.check_ABM_Client.TabIndex = 223289;
            this.check_ABM_Client.Text = "ABM Clientes";
            this.check_ABM_Client.UseVisualStyleBackColor = true;
            // 
            // check_ABM_User
            // 
            this.check_ABM_User.AutoSize = true;
            this.check_ABM_User.Location = new System.Drawing.Point(41, 98);
            this.check_ABM_User.Name = "check_ABM_User";
            this.check_ABM_User.Size = new System.Drawing.Size(93, 17);
            this.check_ABM_User.TabIndex = 223288;
            this.check_ABM_User.Text = "ABM Usuarios";
            this.check_ABM_User.UseVisualStyleBackColor = true;
            // 
            // check_ABM_Roles
            // 
            this.check_ABM_Roles.AutoSize = true;
            this.check_ABM_Roles.Location = new System.Drawing.Point(41, 78);
            this.check_ABM_Roles.Name = "check_ABM_Roles";
            this.check_ABM_Roles.Size = new System.Drawing.Size(79, 17);
            this.check_ABM_Roles.TabIndex = 223287;
            this.check_ABM_Roles.Text = "ABM Roles";
            this.check_ABM_Roles.UseVisualStyleBackColor = true;
            // 
            // check_Depos
            // 
            this.check_Depos.AutoSize = true;
            this.check_Depos.Location = new System.Drawing.Point(41, 58);
            this.check_Depos.Name = "check_Depos";
            this.check_Depos.Size = new System.Drawing.Size(71, 17);
            this.check_Depos.TabIndex = 223286;
            this.check_Depos.Text = "Depositar";
            this.check_Depos.UseVisualStyleBackColor = true;
            // 
            // check_Transf
            // 
            this.check_Transf.AutoSize = true;
            this.check_Transf.Location = new System.Drawing.Point(41, 38);
            this.check_Transf.Name = "check_Transf";
            this.check_Transf.Size = new System.Drawing.Size(70, 17);
            this.check_Transf.TabIndex = 223285;
            this.check_Transf.Text = "Transferir";
            this.check_Transf.UseVisualStyleBackColor = true;
            // 
            // check_Extraer
            // 
            this.check_Extraer.AutoSize = true;
            this.check_Extraer.Location = new System.Drawing.Point(41, 18);
            this.check_Extraer.Name = "check_Extraer";
            this.check_Extraer.Size = new System.Drawing.Size(59, 17);
            this.check_Extraer.TabIndex = 223284;
            this.check_Extraer.Text = "Extraer";
            this.check_Extraer.UseVisualStyleBackColor = true;
            // 
            // check_Func_Saldo
            // 
            this.check_Func_Saldo.AutoSize = true;
            this.check_Func_Saldo.Location = new System.Drawing.Point(183, 18);
            this.check_Func_Saldo.Name = "check_Func_Saldo";
            this.check_Func_Saldo.Size = new System.Drawing.Size(100, 17);
            this.check_Func_Saldo.TabIndex = 223304;
            this.check_Func_Saldo.Text = "Consultar Saldo";
            this.check_Func_Saldo.UseVisualStyleBackColor = true;
            // 
            // check_Func_Estadisticas
            // 
            this.check_Func_Estadisticas.AutoSize = true;
            this.check_Func_Estadisticas.Location = new System.Drawing.Point(183, 38);
            this.check_Func_Estadisticas.Name = "check_Func_Estadisticas";
            this.check_Func_Estadisticas.Size = new System.Drawing.Size(123, 17);
            this.check_Func_Estadisticas.TabIndex = 223305;
            this.check_Func_Estadisticas.Text = "Generar Estadisticas";
            this.check_Func_Estadisticas.UseVisualStyleBackColor = true;
            // 
            // boton_Eliminar
            // 
            this.boton_Eliminar.Location = new System.Drawing.Point(743, 67);
            this.boton_Eliminar.Name = "boton_Eliminar";
            this.boton_Eliminar.Size = new System.Drawing.Size(159, 37);
            this.boton_Eliminar.TabIndex = 223303;
            this.boton_Eliminar.Text = "Dar de Baja";
            this.boton_Eliminar.UseVisualStyleBackColor = true;
            // 
            // EditarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 385);
            this.Controls.Add(this.boton_Crear);
            this.Controls.Add(this.boton_Cancelar);
            this.Controls.Add(this.group_Datos);
            this.Controls.Add(this.group_Func);
            this.Name = "EditarRol";
            this.Text = "Editar Rol";
            this.group_Datos.ResumeLayout(false);
            this.group_Datos.PerformLayout();
            this.group_Func.ResumeLayout(false);
            this.group_Func.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_Crear;
        private System.Windows.Forms.Button boton_Cancelar;
        private System.Windows.Forms.GroupBox group_Datos;
        private System.Windows.Forms.ComboBox combo_Estado;
        private System.Windows.Forms.Label L_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox group_Func;
        private System.Windows.Forms.CheckBox check_ABM_Cuentas;
        private System.Windows.Forms.CheckBox check_ABM_Client;
        private System.Windows.Forms.CheckBox check_ABM_User;
        private System.Windows.Forms.CheckBox check_ABM_Roles;
        private System.Windows.Forms.CheckBox check_Depos;
        private System.Windows.Forms.CheckBox check_Transf;
        private System.Windows.Forms.CheckBox check_Extraer;
        private System.Windows.Forms.CheckBox check_asociar_tarjeta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button boton_Eliminar;
        private System.Windows.Forms.CheckBox check_Func_Estadisticas;
        private System.Windows.Forms.CheckBox check_Func_Saldo;
    }
}
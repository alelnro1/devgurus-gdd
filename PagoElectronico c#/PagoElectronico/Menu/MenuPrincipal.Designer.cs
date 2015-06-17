namespace PagoElectronico
{
    partial class MenuPrincipal
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
            this.boton_Salir = new System.Windows.Forms.Button();
            this.boton_Nuevo_Rol = new System.Windows.Forms.Button();
            this.boton_Editar_rol = new System.Windows.Forms.Button();
            this.groupABMroles = new System.Windows.Forms.GroupBox();
            this.user_Info = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cliente_Info = new System.Windows.Forms.TextBox();
            this.rol_Info = new System.Windows.Forms.TextBox();
            this.groupABMCuentas = new System.Windows.Forms.GroupBox();
            this.boton_Editar_cuenta = new System.Windows.Forms.Button();
            this.boton_Nueva_Cuenta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boton_eliminar_cliente = new System.Windows.Forms.Button();
            this.boton_Editar_Cliente = new System.Windows.Forms.Button();
            this.boton_Crear_Cliente = new System.Windows.Forms.Button();
            this.boton_trans = new System.Windows.Forms.Button();
            this.boton_Extraer = new System.Windows.Forms.Button();
            this.boton_Depositar = new System.Windows.Forms.Button();
            this.boton_Asoc_Tarj = new System.Windows.Forms.Button();
            this.boton_Consul = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.boton_facturar = new System.Windows.Forms.Button();
            this.groupABMroles.SuspendLayout();
            this.groupABMCuentas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // boton_Salir
            // 
            this.boton_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_Salir.ForeColor = System.Drawing.Color.Maroon;
            this.boton_Salir.Location = new System.Drawing.Point(452, 374);
            this.boton_Salir.Name = "boton_Salir";
            this.boton_Salir.Size = new System.Drawing.Size(141, 34);
            this.boton_Salir.TabIndex = 5;
            this.boton_Salir.Text = "Cerrar sesion";
            this.boton_Salir.UseVisualStyleBackColor = true;
            this.boton_Salir.Click += new System.EventHandler(this.boton_Salir_Click);
            // 
            // boton_Nuevo_Rol
            // 
            this.boton_Nuevo_Rol.Location = new System.Drawing.Point(18, 29);
            this.boton_Nuevo_Rol.Name = "boton_Nuevo_Rol";
            this.boton_Nuevo_Rol.Size = new System.Drawing.Size(171, 28);
            this.boton_Nuevo_Rol.TabIndex = 6;
            this.boton_Nuevo_Rol.Text = "Crear nuevo Rol";
            this.boton_Nuevo_Rol.UseVisualStyleBackColor = true;
            this.boton_Nuevo_Rol.Click += new System.EventHandler(this.button1_Click);
            // 
            // boton_Editar_rol
            // 
            this.boton_Editar_rol.Location = new System.Drawing.Point(18, 67);
            this.boton_Editar_rol.Name = "boton_Editar_rol";
            this.boton_Editar_rol.Size = new System.Drawing.Size(171, 28);
            this.boton_Editar_rol.TabIndex = 7;
            this.boton_Editar_rol.Text = "Eliminar/Editar Rol";
            this.boton_Editar_rol.UseVisualStyleBackColor = true;
            this.boton_Editar_rol.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupABMroles
            // 
            this.groupABMroles.Controls.Add(this.boton_Editar_rol);
            this.groupABMroles.Controls.Add(this.boton_Nuevo_Rol);
            this.groupABMroles.Location = new System.Drawing.Point(43, 60);
            this.groupABMroles.Name = "groupABMroles";
            this.groupABMroles.Size = new System.Drawing.Size(205, 133);
            this.groupABMroles.TabIndex = 8;
            this.groupABMroles.TabStop = false;
            this.groupABMroles.Text = "Menu Roles";
            // 
            // user_Info
            // 
            this.user_Info.BackColor = System.Drawing.SystemColors.Control;
            this.user_Info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_Info.ForeColor = System.Drawing.Color.DarkRed;
            this.user_Info.Location = new System.Drawing.Point(90, 9);
            this.user_Info.Name = "user_Info";
            this.user_Info.ReadOnly = true;
            this.user_Info.Size = new System.Drawing.Size(116, 15);
            this.user_Info.TabIndex = 46;
            this.user_Info.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(21, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(376, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Rol:";
            // 
            // cliente_Info
            // 
            this.cliente_Info.BackColor = System.Drawing.SystemColors.Control;
            this.cliente_Info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cliente_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente_Info.ForeColor = System.Drawing.Color.DarkRed;
            this.cliente_Info.Location = new System.Drawing.Point(442, 10);
            this.cliente_Info.Name = "cliente_Info";
            this.cliente_Info.ReadOnly = true;
            this.cliente_Info.Size = new System.Drawing.Size(202, 15);
            this.cliente_Info.TabIndex = 51;
            this.cliente_Info.TabStop = false;
            // 
            // rol_Info
            // 
            this.rol_Info.BackColor = System.Drawing.SystemColors.Control;
            this.rol_Info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rol_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rol_Info.ForeColor = System.Drawing.Color.DarkRed;
            this.rol_Info.Location = new System.Drawing.Point(254, 9);
            this.rol_Info.Name = "rol_Info";
            this.rol_Info.ReadOnly = true;
            this.rol_Info.Size = new System.Drawing.Size(116, 15);
            this.rol_Info.TabIndex = 52;
            this.rol_Info.TabStop = false;
            // 
            // groupABMCuentas
            // 
            this.groupABMCuentas.Controls.Add(this.boton_Editar_cuenta);
            this.groupABMCuentas.Controls.Add(this.boton_Nueva_Cuenta);
            this.groupABMCuentas.Location = new System.Drawing.Point(321, 234);
            this.groupABMCuentas.Name = "groupABMCuentas";
            this.groupABMCuentas.Size = new System.Drawing.Size(205, 112);
            this.groupABMCuentas.TabIndex = 9;
            this.groupABMCuentas.TabStop = false;
            this.groupABMCuentas.Text = "Menu Cuentas";
            // 
            // boton_Editar_cuenta
            // 
            this.boton_Editar_cuenta.Location = new System.Drawing.Point(18, 67);
            this.boton_Editar_cuenta.Name = "boton_Editar_cuenta";
            this.boton_Editar_cuenta.Size = new System.Drawing.Size(171, 28);
            this.boton_Editar_cuenta.TabIndex = 7;
            this.boton_Editar_cuenta.Text = "Eliminar/Editar Cuenta";
            this.boton_Editar_cuenta.UseVisualStyleBackColor = true;
            this.boton_Editar_cuenta.Click += new System.EventHandler(this.boton_Editar_cuenta_Click);
            // 
            // boton_Nueva_Cuenta
            // 
            this.boton_Nueva_Cuenta.Location = new System.Drawing.Point(18, 29);
            this.boton_Nueva_Cuenta.Name = "boton_Nueva_Cuenta";
            this.boton_Nueva_Cuenta.Size = new System.Drawing.Size(171, 28);
            this.boton_Nueva_Cuenta.TabIndex = 6;
            this.boton_Nueva_Cuenta.Text = "Crear nueva Cuenta";
            this.boton_Nueva_Cuenta.UseVisualStyleBackColor = true;
            this.boton_Nueva_Cuenta.Click += new System.EventHandler(this.boton_Nueva_Cuenta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boton_eliminar_cliente);
            this.groupBox1.Controls.Add(this.boton_Editar_Cliente);
            this.groupBox1.Controls.Add(this.boton_Crear_Cliente);
            this.groupBox1.Location = new System.Drawing.Point(43, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 142);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Clientes";
            // 
            // boton_eliminar_cliente
            // 
            this.boton_eliminar_cliente.Location = new System.Drawing.Point(18, 108);
            this.boton_eliminar_cliente.Name = "boton_eliminar_cliente";
            this.boton_eliminar_cliente.Size = new System.Drawing.Size(171, 28);
            this.boton_eliminar_cliente.TabIndex = 8;
            this.boton_eliminar_cliente.Text = "Eliminar Cliente";
            this.boton_eliminar_cliente.UseVisualStyleBackColor = true;
            this.boton_eliminar_cliente.Click += new System.EventHandler(this.boton_eliminar_cliente_Click);
            // 
            // boton_Editar_Cliente
            // 
            this.boton_Editar_Cliente.Location = new System.Drawing.Point(18, 67);
            this.boton_Editar_Cliente.Name = "boton_Editar_Cliente";
            this.boton_Editar_Cliente.Size = new System.Drawing.Size(171, 28);
            this.boton_Editar_Cliente.TabIndex = 7;
            this.boton_Editar_Cliente.Text = "Editar Cliente";
            this.boton_Editar_Cliente.UseVisualStyleBackColor = true;
            this.boton_Editar_Cliente.Click += new System.EventHandler(this.boton_Editar_Cliente_Click);
            // 
            // boton_Crear_Cliente
            // 
            this.boton_Crear_Cliente.Location = new System.Drawing.Point(18, 29);
            this.boton_Crear_Cliente.Name = "boton_Crear_Cliente";
            this.boton_Crear_Cliente.Size = new System.Drawing.Size(171, 28);
            this.boton_Crear_Cliente.TabIndex = 6;
            this.boton_Crear_Cliente.Text = "Crear nuevo Cliente";
            this.boton_Crear_Cliente.UseVisualStyleBackColor = true;
            this.boton_Crear_Cliente.Click += new System.EventHandler(this.boton_Crear_Cliente_Click);
            // 
            // boton_trans
            // 
            this.boton_trans.Location = new System.Drawing.Point(321, 72);
            this.boton_trans.Name = "boton_trans";
            this.boton_trans.Size = new System.Drawing.Size(126, 28);
            this.boton_trans.TabIndex = 9;
            this.boton_trans.Text = "Transeferir";
            this.boton_trans.UseVisualStyleBackColor = true;
            this.boton_trans.Click += new System.EventHandler(this.boton_trans_Click);
            // 
            // boton_Extraer
            // 
            this.boton_Extraer.Location = new System.Drawing.Point(321, 116);
            this.boton_Extraer.Name = "boton_Extraer";
            this.boton_Extraer.Size = new System.Drawing.Size(126, 28);
            this.boton_Extraer.TabIndex = 53;
            this.boton_Extraer.Text = "Extraer";
            this.boton_Extraer.UseVisualStyleBackColor = true;
            this.boton_Extraer.Click += new System.EventHandler(this.boton_Extraer_Click);
            // 
            // boton_Depositar
            // 
            this.boton_Depositar.Location = new System.Drawing.Point(478, 72);
            this.boton_Depositar.Name = "boton_Depositar";
            this.boton_Depositar.Size = new System.Drawing.Size(126, 28);
            this.boton_Depositar.TabIndex = 54;
            this.boton_Depositar.Text = "Depositar";
            this.boton_Depositar.UseVisualStyleBackColor = true;
            this.boton_Depositar.Click += new System.EventHandler(this.boton_Depositar_Click);
            // 
            // boton_Asoc_Tarj
            // 
            this.boton_Asoc_Tarj.Location = new System.Drawing.Point(478, 116);
            this.boton_Asoc_Tarj.Name = "boton_Asoc_Tarj";
            this.boton_Asoc_Tarj.Size = new System.Drawing.Size(126, 28);
            this.boton_Asoc_Tarj.TabIndex = 55;
            this.boton_Asoc_Tarj.Text = "Asociar Tarjeta";
            this.boton_Asoc_Tarj.UseVisualStyleBackColor = true;
            this.boton_Asoc_Tarj.Click += new System.EventHandler(this.boton_Asoc_Tarj_Click);
            // 
            // boton_Consul
            // 
            this.boton_Consul.Location = new System.Drawing.Point(321, 160);
            this.boton_Consul.Name = "boton_Consul";
            this.boton_Consul.Size = new System.Drawing.Size(126, 28);
            this.boton_Consul.TabIndex = 56;
            this.boton_Consul.Text = "Consultar Saldo";
            this.boton_Consul.UseVisualStyleBackColor = true;
            this.boton_Consul.Click += new System.EventHandler(this.boton_Consul_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.boton_facturar);
            this.groupBox2.Location = new System.Drawing.Point(570, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 112);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Facturacion de Costos";
            // 
            // boton_facturar
            // 
            this.boton_facturar.Location = new System.Drawing.Point(6, 29);
            this.boton_facturar.Name = "boton_facturar";
            this.boton_facturar.Size = new System.Drawing.Size(171, 28);
            this.boton_facturar.TabIndex = 7;
            this.boton_facturar.Text = "Facturacion De Costos";
            this.boton_facturar.UseVisualStyleBackColor = true;
            this.boton_facturar.Click += new System.EventHandler(this.boton_facturar_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 429);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.boton_Consul);
            this.Controls.Add(this.boton_Asoc_Tarj);
            this.Controls.Add(this.boton_Depositar);
            this.Controls.Add(this.boton_Extraer);
            this.Controls.Add(this.boton_trans);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupABMCuentas);
            this.Controls.Add(this.rol_Info);
            this.Controls.Add(this.cliente_Info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user_Info);
            this.Controls.Add(this.groupABMroles);
            this.Controls.Add(this.boton_Salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.groupABMroles.ResumeLayout(false);
            this.groupABMCuentas.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton_Salir;
        private System.Windows.Forms.Button boton_Nuevo_Rol;
        private System.Windows.Forms.Button boton_Editar_rol;
        private System.Windows.Forms.GroupBox groupABMroles;
        private System.Windows.Forms.TextBox user_Info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cliente_Info;
        private System.Windows.Forms.TextBox rol_Info;
        private System.Windows.Forms.GroupBox groupABMCuentas;
        private System.Windows.Forms.Button boton_Editar_cuenta;
        private System.Windows.Forms.Button boton_Nueva_Cuenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button boton_Editar_Cliente;
        private System.Windows.Forms.Button boton_Crear_Cliente;
        private System.Windows.Forms.Button boton_eliminar_cliente;
        private System.Windows.Forms.Button boton_trans;
        private System.Windows.Forms.Button boton_Extraer;
        private System.Windows.Forms.Button boton_Depositar;
        private System.Windows.Forms.Button boton_Asoc_Tarj;
        private System.Windows.Forms.Button boton_Consul;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button boton_facturar;
    }
}
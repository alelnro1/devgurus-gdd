namespace PagoElectronico.ABM_Cliente
{
    partial class MenuABMClientes
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
            this.button_alta = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_modificar_cliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_alta
            // 
            this.button_alta.Location = new System.Drawing.Point(115, 43);
            this.button_alta.Name = "button_alta";
            this.button_alta.Size = new System.Drawing.Size(129, 46);
            this.button_alta.TabIndex = 0;
            this.button_alta.Text = "Alta Cliente";
            this.button_alta.UseVisualStyleBackColor = true;
            this.button_alta.Click += new System.EventHandler(this.button_alta_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(115, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Baja Cliente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_modificar_cliente
            // 
            this.button_modificar_cliente.Location = new System.Drawing.Point(115, 118);
            this.button_modificar_cliente.Name = "button_modificar_cliente";
            this.button_modificar_cliente.Size = new System.Drawing.Size(129, 46);
            this.button_modificar_cliente.TabIndex = 3;
            this.button_modificar_cliente.Text = "Modificar Cliente";
            this.button_modificar_cliente.UseVisualStyleBackColor = true;
            this.button_modificar_cliente.Click += new System.EventHandler(this.button_modificar_cliente_Click);
            // 
            // MenuABMClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 295);
            this.Controls.Add(this.button_modificar_cliente);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_alta);
            this.Name = "MenuABMClientes";
            this.Text = "MenuABMCuentas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_alta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_modificar_cliente;
    }
}
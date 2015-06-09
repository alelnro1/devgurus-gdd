namespace PagoElectronico.ABM_Cliente
{
    partial class EditarCliente
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
            this.boton_desasociar_tarjeta = new System.Windows.Forms.Button();
            this.boton_asociar_tarjeta = new System.Windows.Forms.Button();
            this.boton_modificar_tarjeta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boton_desasociar_tarjeta
            // 
            this.boton_desasociar_tarjeta.Location = new System.Drawing.Point(168, 157);
            this.boton_desasociar_tarjeta.Name = "boton_desasociar_tarjeta";
            this.boton_desasociar_tarjeta.Size = new System.Drawing.Size(143, 23);
            this.boton_desasociar_tarjeta.TabIndex = 33;
            this.boton_desasociar_tarjeta.Text = "Desasociar Tarjeta";
            this.boton_desasociar_tarjeta.UseVisualStyleBackColor = true;
            this.boton_desasociar_tarjeta.Click += new System.EventHandler(this.boton_desasociar_tarjeta_Click);
            // 
            // boton_asociar_tarjeta
            // 
            this.boton_asociar_tarjeta.Location = new System.Drawing.Point(168, 88);
            this.boton_asociar_tarjeta.Name = "boton_asociar_tarjeta";
            this.boton_asociar_tarjeta.Size = new System.Drawing.Size(143, 23);
            this.boton_asociar_tarjeta.TabIndex = 34;
            this.boton_asociar_tarjeta.Text = "Asociar Tarjeta";
            this.boton_asociar_tarjeta.UseVisualStyleBackColor = true;
            this.boton_asociar_tarjeta.Click += new System.EventHandler(this.button2_Click);
            // 
            // boton_modificar_tarjeta
            // 
            this.boton_modificar_tarjeta.Location = new System.Drawing.Point(168, 224);
            this.boton_modificar_tarjeta.Name = "boton_modificar_tarjeta";
            this.boton_modificar_tarjeta.Size = new System.Drawing.Size(143, 23);
            this.boton_modificar_tarjeta.TabIndex = 35;
            this.boton_modificar_tarjeta.Text = "Modificar Tarjeta";
            this.boton_modificar_tarjeta.UseVisualStyleBackColor = true;
            this.boton_modificar_tarjeta.Click += new System.EventHandler(this.boton_modificar_tarjeta_Click);
            // 
            // EditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 301);
            this.Controls.Add(this.boton_modificar_tarjeta);
            this.Controls.Add(this.boton_asociar_tarjeta);
            this.Controls.Add(this.boton_desasociar_tarjeta);
            this.Name = "EditarCliente";
            this.Text = "EditarCliente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_desasociar_tarjeta;
        private System.Windows.Forms.Button boton_asociar_tarjeta;
        private System.Windows.Forms.Button boton_modificar_tarjeta;
    }
}
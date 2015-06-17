namespace PagoElectronico
{
    partial class EditarCuentas
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
            this.label4 = new System.Windows.Forms.Label();
            this.combo_tipo_cuenta = new System.Windows.Forms.ComboBox();
            this.boton_Crear = new System.Windows.Forms.Button();
            this.boton_Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nuevo Tipo de Cuenta:";
            // 
            // combo_tipo_cuenta
            // 
            this.combo_tipo_cuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_tipo_cuenta.FormattingEnabled = true;
            this.combo_tipo_cuenta.Location = new System.Drawing.Point(164, 78);
            this.combo_tipo_cuenta.Name = "combo_tipo_cuenta";
            this.combo_tipo_cuenta.Size = new System.Drawing.Size(121, 21);
            this.combo_tipo_cuenta.TabIndex = 31;
            // 
            // boton_Crear
            // 
            this.boton_Crear.Location = new System.Drawing.Point(216, 149);
            this.boton_Crear.Name = "boton_Crear";
            this.boton_Crear.Size = new System.Drawing.Size(101, 28);
            this.boton_Crear.TabIndex = 223281;
            this.boton_Crear.Text = "Guardar cambios";
            this.boton_Crear.UseVisualStyleBackColor = true;
            this.boton_Crear.Click += new System.EventHandler(this.boton_Crear_Click);
            // 
            // boton_Cancelar
            // 
            this.boton_Cancelar.Location = new System.Drawing.Point(12, 149);
            this.boton_Cancelar.Name = "boton_Cancelar";
            this.boton_Cancelar.Size = new System.Drawing.Size(101, 28);
            this.boton_Cancelar.TabIndex = 223280;
            this.boton_Cancelar.Text = "Cancelar edición";
            this.boton_Cancelar.UseVisualStyleBackColor = true;
            this.boton_Cancelar.Click += new System.EventHandler(this.boton_Cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 223282;
            this.label1.Text = "EDITAR CUENTA";
            // 
            // EditarCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(334, 195);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_Crear);
            this.Controls.Add(this.boton_Cancelar);
            this.Controls.Add(this.combo_tipo_cuenta);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditarCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Editar Cuentas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_tipo_cuenta;
        private System.Windows.Forms.Button boton_Crear;
        private System.Windows.Forms.Button boton_Cancelar;
        private System.Windows.Forms.Label label1;
    }
}
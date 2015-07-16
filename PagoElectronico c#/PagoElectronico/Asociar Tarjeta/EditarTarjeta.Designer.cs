namespace PagoElectronico
{
    partial class EditarTarjeta
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
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 223313;
            this.label11.Text = "Fecha Vencimiento";
            // 
            // dateTimePicker_vencimiento
            // 
            this.dateTimePicker_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_vencimiento.Location = new System.Drawing.Point(139, 42);
            this.dateTimePicker_vencimiento.Name = "dateTimePicker_vencimiento";
            this.dateTimePicker_vencimiento.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker_vencimiento.TabIndex = 223312;
            this.dateTimePicker_vencimiento.Value = new System.DateTime(2018, 2, 1, 0, 0, 0, 0);
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(94, 68);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 223314;
            this.guardar.Text = "Guardar ";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // EditarTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 100);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker_vencimiento);
            this.Name = "EditarTarjeta";
            this.Text = "EditarTarjeta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker_vencimiento;
        private System.Windows.Forms.Button guardar;
    }
}
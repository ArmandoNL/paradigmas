namespace IdentificacionPlantas
{
    partial class Pregunta2
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioEntero = new System.Windows.Forms.RadioButton();
            this.radioAserrado = new System.Windows.Forms.RadioButton();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Describa el borde de la hoja";
            // 
            // radioEntero
            // 
            this.radioEntero.AutoSize = true;
            this.radioEntero.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEntero.ForeColor = System.Drawing.Color.DarkGreen;
            this.radioEntero.Location = new System.Drawing.Point(92, 77);
            this.radioEntero.Name = "radioEntero";
            this.radioEntero.Size = new System.Drawing.Size(149, 25);
            this.radioEntero.TabIndex = 1;
            this.radioEntero.TabStop = true;
            this.radioEntero.Text = "Entero: borde liso";
            this.radioEntero.UseVisualStyleBackColor = true;
            // 
            // radioAserrado
            // 
            this.radioAserrado.AutoSize = true;
            this.radioAserrado.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAserrado.ForeColor = System.Drawing.Color.DarkGreen;
            this.radioAserrado.Location = new System.Drawing.Point(92, 122);
            this.radioAserrado.Name = "radioAserrado";
            this.radioAserrado.Size = new System.Drawing.Size(222, 25);
            this.radioAserrado.TabIndex = 2;
            this.radioAserrado.TabStop = true;
            this.radioAserrado.Text = "Aserrado: borde con dientes";
            this.radioAserrado.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(267, 177);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(106, 31);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente >>";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // Pregunta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 220);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.radioAserrado);
            this.Controls.Add(this.radioEntero);
            this.Controls.Add(this.label1);
            this.Name = "Pregunta2";
            this.Text = "Pregunta2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioEntero;
        private System.Windows.Forms.RadioButton radioAserrado;
        private System.Windows.Forms.Button btnSiguiente;
    }
}
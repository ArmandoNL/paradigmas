namespace IdentificacionPlantas
{
    partial class Pregunta4
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
            this.radioAncha = new System.Windows.Forms.RadioButton();
            this.radioAngosta = new System.Windows.Forms.RadioButton();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Describa el ancho de la hoja";
            // 
            // radioAncha
            // 
            this.radioAncha.AutoSize = true;
            this.radioAncha.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAncha.ForeColor = System.Drawing.Color.DarkGreen;
            this.radioAncha.Location = new System.Drawing.Point(86, 93);
            this.radioAncha.Name = "radioAncha";
            this.radioAncha.Size = new System.Drawing.Size(162, 25);
            this.radioAncha.TabIndex = 1;
            this.radioAncha.TabStop = true;
            this.radioAncha.Text = "Ancha: más de 8cm";
            this.radioAncha.UseVisualStyleBackColor = true;
            // 
            // radioAngosta
            // 
            this.radioAngosta.AutoSize = true;
            this.radioAngosta.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAngosta.ForeColor = System.Drawing.Color.DarkGreen;
            this.radioAngosta.Location = new System.Drawing.Point(86, 147);
            this.radioAngosta.Name = "radioAngosta";
            this.radioAngosta.Size = new System.Drawing.Size(194, 25);
            this.radioAngosta.TabIndex = 2;
            this.radioAngosta.TabStop = true;
            this.radioAngosta.Text = "Angosta: menos de 8cm";
            this.radioAngosta.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(263, 198);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(94, 32);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente >>";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // Pregunta4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 242);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.radioAngosta);
            this.Controls.Add(this.radioAncha);
            this.Controls.Add(this.label1);
            this.Name = "Pregunta4";
            this.Text = "Pregunta4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioAncha;
        private System.Windows.Forms.RadioButton radioAngosta;
        private System.Windows.Forms.Button btnSiguiente;
    }
}
namespace IdentificacionPlantas
{
    partial class Pregunta5
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
            this.radioLargo = new System.Windows.Forms.RadioButton();
            this.radioCorto = new System.Windows.Forms.RadioButton();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(27, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Describa el largo del ápice (punta)";
            // 
            // radioLargo
            // 
            this.radioLargo.AutoSize = true;
            this.radioLargo.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLargo.ForeColor = System.Drawing.Color.DarkGreen;
            this.radioLargo.Location = new System.Drawing.Point(95, 110);
            this.radioLargo.Name = "radioLargo";
            this.radioLargo.Size = new System.Drawing.Size(159, 25);
            this.radioLargo.TabIndex = 1;
            this.radioLargo.TabStop = true;
            this.radioLargo.Text = "Largo: más de 2cm";
            this.radioLargo.UseVisualStyleBackColor = true;
            // 
            // radioCorto
            // 
            this.radioCorto.AutoSize = true;
            this.radioCorto.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCorto.ForeColor = System.Drawing.Color.DarkGreen;
            this.radioCorto.Location = new System.Drawing.Point(95, 161);
            this.radioCorto.Name = "radioCorto";
            this.radioCorto.Size = new System.Drawing.Size(176, 25);
            this.radioCorto.TabIndex = 2;
            this.radioCorto.TabStop = true;
            this.radioCorto.Text = "Corto: menos de 2cm";
            this.radioCorto.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(299, 189);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(88, 32);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente >>";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // Pregunta5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 233);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.radioCorto);
            this.Controls.Add(this.radioLargo);
            this.Controls.Add(this.label1);
            this.Name = "Pregunta5";
            this.Text = "Pregunta5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioLargo;
        private System.Windows.Forms.RadioButton radioCorto;
        private System.Windows.Forms.Button btnSiguiente;
    }
}
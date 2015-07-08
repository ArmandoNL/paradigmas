namespace IdentificacionPlantas
{
    partial class Pregunta7
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
            this.radioGlabro = new System.Windows.Forms.RadioButton();
            this.radioPubescente = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Describa la pubescencia del envés (cara inferior)";
            // 
            // radioGlabro
            // 
            this.radioGlabro.AutoSize = true;
            this.radioGlabro.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGlabro.ForeColor = System.Drawing.Color.DarkGreen;
            this.radioGlabro.Location = new System.Drawing.Point(154, 107);
            this.radioGlabro.Name = "radioGlabro";
            this.radioGlabro.Size = new System.Drawing.Size(143, 25);
            this.radioGlabro.TabIndex = 1;
            this.radioGlabro.TabStop = true;
            this.radioGlabro.Text = "Glabro: sin pelos";
            this.radioGlabro.UseVisualStyleBackColor = true;
            // 
            // radioPubescente
            // 
            this.radioPubescente.AutoSize = true;
            this.radioPubescente.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPubescente.ForeColor = System.Drawing.Color.DarkGreen;
            this.radioPubescente.Location = new System.Drawing.Point(154, 157);
            this.radioPubescente.Name = "radioPubescente";
            this.radioPubescente.Size = new System.Drawing.Size(180, 25);
            this.radioPubescente.TabIndex = 2;
            this.radioPubescente.TabStop = true;
            this.radioPubescente.Text = "Pubescente: con pelos";
            this.radioPubescente.UseVisualStyleBackColor = true;
            // 
            // Pregunta7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 244);
            this.Controls.Add(this.radioPubescente);
            this.Controls.Add(this.radioGlabro);
            this.Controls.Add(this.label1);
            this.Name = "Pregunta7";
            this.Text = "Pregunta7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioGlabro;
        private System.Windows.Forms.RadioButton radioPubescente;
    }
}
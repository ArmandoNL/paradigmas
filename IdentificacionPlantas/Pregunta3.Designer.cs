namespace IdentificacionPlantas
{
    partial class Pregunta3
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
            this.radioCorta = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Describa el largo de la hoja";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioLargo
            // 
            this.radioLargo.AutoSize = true;
            this.radioLargo.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLargo.ForeColor = System.Drawing.Color.DarkGreen;
            this.radioLargo.Location = new System.Drawing.Point(100, 84);
            this.radioLargo.Name = "radioLargo";
            this.radioLargo.Size = new System.Drawing.Size(168, 25);
            this.radioLargo.TabIndex = 1;
            this.radioLargo.TabStop = true;
            this.radioLargo.Text = "Largo: más de 15cm";
            this.radioLargo.UseVisualStyleBackColor = true;
            // 
            // radioCorta
            // 
            this.radioCorta.AutoSize = true;
            this.radioCorta.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCorta.ForeColor = System.Drawing.Color.DarkGreen;
            this.radioCorta.Location = new System.Drawing.Point(100, 133);
            this.radioCorta.Name = "radioCorta";
            this.radioCorta.Size = new System.Drawing.Size(184, 25);
            this.radioCorta.TabIndex = 2;
            this.radioCorta.TabStop = true;
            this.radioCorta.Text = "Corta: menos de 15cm";
            this.radioCorta.UseVisualStyleBackColor = true;
            // 
            // Pregunta3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 193);
            this.Controls.Add(this.radioCorta);
            this.Controls.Add(this.radioLargo);
            this.Controls.Add(this.label1);
            this.Name = "Pregunta3";
            this.Text = "Pregunta3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioLargo;
        private System.Windows.Forms.RadioButton radioCorta;
    }
}
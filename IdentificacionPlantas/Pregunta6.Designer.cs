namespace IdentificacionPlantas
{
    partial class Pregunta6
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
            this.radioBrillante = new System.Windows.Forms.RadioButton();
            this.radioOpaco = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Describa la apariencia del haz (cara superior)";
            // 
            // radioBrillante
            // 
            this.radioBrillante.AutoSize = true;
            this.radioBrillante.BackColor = System.Drawing.SystemColors.Control;
            this.radioBrillante.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBrillante.ForeColor = System.Drawing.Color.DarkGreen;
            this.radioBrillante.Location = new System.Drawing.Point(145, 95);
            this.radioBrillante.Name = "radioBrillante";
            this.radioBrillante.Size = new System.Drawing.Size(157, 25);
            this.radioBrillante.TabIndex = 1;
            this.radioBrillante.TabStop = true;
            this.radioBrillante.Text = "Brillante: con brillo";
            this.radioBrillante.UseVisualStyleBackColor = false;
            // 
            // radioOpaco
            // 
            this.radioOpaco.AutoSize = true;
            this.radioOpaco.BackColor = System.Drawing.SystemColors.Control;
            this.radioOpaco.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOpaco.ForeColor = System.Drawing.Color.DarkGreen;
            this.radioOpaco.Location = new System.Drawing.Point(145, 141);
            this.radioOpaco.Name = "radioOpaco";
            this.radioOpaco.Size = new System.Drawing.Size(140, 25);
            this.radioOpaco.TabIndex = 2;
            this.radioOpaco.TabStop = true;
            this.radioOpaco.Text = "Opaco: sin brillo";
            this.radioOpaco.UseVisualStyleBackColor = false;
            // 
            // Pregunta6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 198);
            this.Controls.Add(this.radioOpaco);
            this.Controls.Add(this.radioBrillante);
            this.Controls.Add(this.label1);
            this.Name = "Pregunta6";
            this.Text = "Pregunta6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBrillante;
        private System.Windows.Forms.RadioButton radioOpaco;
    }
}
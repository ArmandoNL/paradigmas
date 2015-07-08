namespace IdentificacionPlantas
{
    partial class Pregunta8
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
            this.radioPocas = new System.Windows.Forms.RadioButton();
            this.radioMuchas = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Describa el número de venas por lado";
            // 
            // radioPocas
            // 
            this.radioPocas.AutoSize = true;
            this.radioPocas.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPocas.ForeColor = System.Drawing.Color.DarkGreen;
            this.radioPocas.Location = new System.Drawing.Point(124, 104);
            this.radioPocas.Name = "radioPocas";
            this.radioPocas.Size = new System.Drawing.Size(165, 25);
            this.radioPocas.TabIndex = 1;
            this.radioPocas.TabStop = true;
            this.radioPocas.Text = "Pocas: menos de 10";
            this.radioPocas.UseVisualStyleBackColor = true;
            // 
            // radioMuchas
            // 
            this.radioMuchas.AutoSize = true;
            this.radioMuchas.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMuchas.ForeColor = System.Drawing.Color.DarkGreen;
            this.radioMuchas.Location = new System.Drawing.Point(124, 156);
            this.radioMuchas.Name = "radioMuchas";
            this.radioMuchas.Size = new System.Drawing.Size(161, 25);
            this.radioMuchas.TabIndex = 2;
            this.radioMuchas.TabStop = true;
            this.radioMuchas.Text = "Muchas: más de 10";
            this.radioMuchas.UseVisualStyleBackColor = true;
            // 
            // Pregunta8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 220);
            this.Controls.Add(this.radioMuchas);
            this.Controls.Add(this.radioPocas);
            this.Controls.Add(this.label1);
            this.Name = "Pregunta8";
            this.Text = "Pregunta8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioPocas;
        private System.Windows.Forms.RadioButton radioMuchas;
    }
}
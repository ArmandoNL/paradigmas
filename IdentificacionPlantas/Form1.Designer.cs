namespace IdentificacionPlantas
{
    partial class FormInicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOvada = new System.Windows.Forms.Button();
            this.btnLanceolada = new System.Windows.Forms.Button();
            this.btnOblonga = new System.Windows.Forms.Button();
            this.btnObovada = new System.Windows.Forms.Button();
            this.btnRomboidal = new System.Windows.Forms.Button();
            this.btnEliptica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Green;
            this.lblTitulo.Location = new System.Drawing.Point(109, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(839, 50);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Reconocimiento de plantas de la familia Moraceae";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(48, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Escoja forma de la hoja:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnOvada
            // 
            this.btnOvada.BackgroundImage = global::IdentificacionPlantas.Properties.Resources.ovada;
            this.btnOvada.Location = new System.Drawing.Point(997, 327);
            this.btnOvada.Name = "btnOvada";
            this.btnOvada.Size = new System.Drawing.Size(96, 208);
            this.btnOvada.TabIndex = 14;
            this.btnOvada.UseVisualStyleBackColor = true;
            this.btnOvada.Click += new System.EventHandler(this.btnOvada_Click);
            // 
            // btnLanceolada
            // 
            this.btnLanceolada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLanceolada.BackgroundImage")));
            this.btnLanceolada.Location = new System.Drawing.Point(816, 327);
            this.btnLanceolada.Name = "btnLanceolada";
            this.btnLanceolada.Size = new System.Drawing.Size(132, 208);
            this.btnLanceolada.TabIndex = 13;
            this.btnLanceolada.UseVisualStyleBackColor = true;
            this.btnLanceolada.Click += new System.EventHandler(this.btnLanceolada_Click);
            // 
            // btnOblonga
            // 
            this.btnOblonga.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOblonga.BackgroundImage")));
            this.btnOblonga.Location = new System.Drawing.Point(651, 327);
            this.btnOblonga.Name = "btnOblonga";
            this.btnOblonga.Size = new System.Drawing.Size(125, 208);
            this.btnOblonga.TabIndex = 12;
            this.btnOblonga.UseVisualStyleBackColor = true;
            this.btnOblonga.Click += new System.EventHandler(this.btnOblonga_Click);
            // 
            // btnObovada
            // 
            this.btnObovada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnObovada.BackgroundImage")));
            this.btnObovada.Location = new System.Drawing.Point(469, 327);
            this.btnObovada.Name = "btnObovada";
            this.btnObovada.Size = new System.Drawing.Size(121, 208);
            this.btnObovada.TabIndex = 11;
            this.btnObovada.UseVisualStyleBackColor = true;
            this.btnObovada.Click += new System.EventHandler(this.btnObovada_Click);
            // 
            // btnRomboidal
            // 
            this.btnRomboidal.BackgroundImage = global::IdentificacionPlantas.Properties.Resources.romboiadal;
            this.btnRomboidal.Location = new System.Drawing.Point(292, 327);
            this.btnRomboidal.Name = "btnRomboidal";
            this.btnRomboidal.Size = new System.Drawing.Size(119, 208);
            this.btnRomboidal.TabIndex = 10;
            this.btnRomboidal.UseVisualStyleBackColor = true;
            this.btnRomboidal.Click += new System.EventHandler(this.btnRomboidal_Click);
            // 
            // btnEliptica
            // 
            this.btnEliptica.BackgroundImage = global::IdentificacionPlantas.Properties.Resources.eliptica1;
            this.btnEliptica.Location = new System.Drawing.Point(109, 327);
            this.btnEliptica.Name = "btnEliptica";
            this.btnEliptica.Size = new System.Drawing.Size(118, 208);
            this.btnEliptica.TabIndex = 9;
            this.btnEliptica.UseVisualStyleBackColor = true;
            this.btnEliptica.Click += new System.EventHandler(this.btnEliptica_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1211, 754);
            this.Controls.Add(this.btnOvada);
            this.Controls.Add(this.btnLanceolada);
            this.Controls.Add(this.btnOblonga);
            this.Controls.Add(this.btnObovada);
            this.Controls.Add(this.btnRomboidal);
            this.Controls.Add(this.btnEliptica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliptica;
        private System.Windows.Forms.Button btnRomboidal;
        private System.Windows.Forms.Button btnObovada;
        private System.Windows.Forms.Button btnOblonga;
        private System.Windows.Forms.Button btnLanceolada;
        private System.Windows.Forms.Button btnOvada;

    }
}


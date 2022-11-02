namespace WindowsPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnViolin = new System.Windows.Forms.Button();
            this.btnGuitarra = new System.Windows.Forms.Button();
            this.btnPiano = new System.Windows.Forms.Button();
            this.lblMensagge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnViolin
            // 
            this.btnViolin.Location = new System.Drawing.Point(86, 211);
            this.btnViolin.Name = "btnViolin";
            this.btnViolin.Size = new System.Drawing.Size(106, 49);
            this.btnViolin.TabIndex = 2;
            this.btnViolin.Text = "Violin";
            this.btnViolin.UseVisualStyleBackColor = true;
            this.btnViolin.Click += new System.EventHandler(this.btnViolin_Click);
            // 
            // btnGuitarra
            // 
            this.btnGuitarra.Location = new System.Drawing.Point(239, 211);
            this.btnGuitarra.Name = "btnGuitarra";
            this.btnGuitarra.Size = new System.Drawing.Size(106, 49);
            this.btnGuitarra.TabIndex = 3;
            this.btnGuitarra.Text = "Guitarra";
            this.btnGuitarra.UseVisualStyleBackColor = true;
            this.btnGuitarra.Click += new System.EventHandler(this.btnGuitarra_Click);
            // 
            // btnPiano
            // 
            this.btnPiano.Location = new System.Drawing.Point(409, 211);
            this.btnPiano.Name = "btnPiano";
            this.btnPiano.Size = new System.Drawing.Size(106, 49);
            this.btnPiano.TabIndex = 4;
            this.btnPiano.Text = "Piano";
            this.btnPiano.UseVisualStyleBackColor = true;
            this.btnPiano.Click += new System.EventHandler(this.btnPiano_Click);
            // 
            // lblMensagge
            // 
            this.lblMensagge.AutoSize = true;
            this.lblMensagge.Location = new System.Drawing.Point(213, 111);
            this.lblMensagge.Name = "lblMensagge";
            this.lblMensagge.Size = new System.Drawing.Size(228, 20);
            this.lblMensagge.TabIndex = 5;
            this.lblMensagge.Text = "Elije un instrumento para afinar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMensagge);
            this.Controls.Add(this.btnPiano);
            this.Controls.Add(this.btnGuitarra);
            this.Controls.Add(this.btnViolin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViolin;
        private System.Windows.Forms.Button btnGuitarra;
        private System.Windows.Forms.Button btnPiano;
        private System.Windows.Forms.Label lblMensagge;
    }
}


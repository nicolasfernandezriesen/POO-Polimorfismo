namespace WindowsPresentacion
{
    partial class Caso2
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
            this.btnMover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(259, 178);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(180, 86);
            this.btnMover.TabIndex = 1;
            this.btnMover.Text = "Mover piezas";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // Caso2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMover);
            this.Name = "Caso2";
            this.Text = "Caso2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMover;
    }
}
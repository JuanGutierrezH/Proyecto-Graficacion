namespace Proyecto_Graficacion.Unidad2
{
    partial class Escalamiento
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
            this.btnDibujar = new System.Windows.Forms.Button();
            this.btnEscalar = new System.Windows.Forms.Button();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(12, 12);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(75, 23);
            this.btnDibujar.TabIndex = 0;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // btnEscalar
            // 
            this.btnEscalar.Location = new System.Drawing.Point(103, 12);
            this.btnEscalar.Name = "btnEscalar";
            this.btnEscalar.Size = new System.Drawing.Size(75, 23);
            this.btnEscalar.TabIndex = 1;
            this.btnEscalar.Text = "Escalar";
            this.btnEscalar.UseVisualStyleBackColor = true;
            this.btnEscalar.Click += new System.EventHandler(this.btnEscalar_Click);
            // 
            // nud1
            // 
            this.nud1.Location = new System.Drawing.Point(197, 15);
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(62, 20);
            this.nud1.TabIndex = 2;
            // 
            // Escalamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1236, 808);
            this.Controls.Add(this.nud1);
            this.Controls.Add(this.btnEscalar);
            this.Controls.Add(this.btnDibujar);
            this.Name = "Escalamiento";
            this.Text = "Escalamiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Escalamiento_FormClosing);
            this.Load += new System.EventHandler(this.Escalamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Button btnEscalar;
        private System.Windows.Forms.NumericUpDown nud1;
    }
}
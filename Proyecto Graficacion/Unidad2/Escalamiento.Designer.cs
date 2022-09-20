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
            this.btnEscalar = new System.Windows.Forms.Button();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEscalar
            // 
            this.btnEscalar.Location = new System.Drawing.Point(29, 15);
            this.btnEscalar.Name = "btnEscalar";
            this.btnEscalar.Size = new System.Drawing.Size(100, 30);
            this.btnEscalar.TabIndex = 1;
            this.btnEscalar.Text = "Escalar";
            this.btnEscalar.UseVisualStyleBackColor = true;
            this.btnEscalar.Click += new System.EventHandler(this.btnEscalar_Click);
            // 
            // nud1
            // 
            this.nud1.Location = new System.Drawing.Point(147, 22);
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(65, 20);
            this.nud1.TabIndex = 2;
            this.nud1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Escalamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(876, 708);
            this.Controls.Add(this.nud1);
            this.Controls.Add(this.btnEscalar);
            this.Name = "Escalamiento";
            this.Text = "Escalamiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Escalamiento_FormClosing);
            this.Load += new System.EventHandler(this.Escalamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEscalar;
        private System.Windows.Forms.NumericUpDown nud1;
    }
}
namespace Proyecto_Graficacion.Unidad2
{
    partial class DosCuadros
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
            this.btnPruebas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(27, 24);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(75, 23);
            this.btnDibujar.TabIndex = 0;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // btnPruebas
            // 
            this.btnPruebas.Location = new System.Drawing.Point(135, 24);
            this.btnPruebas.Name = "btnPruebas";
            this.btnPruebas.Size = new System.Drawing.Size(75, 23);
            this.btnPruebas.TabIndex = 1;
            this.btnPruebas.Text = "button1";
            this.btnPruebas.UseVisualStyleBackColor = true;
            this.btnPruebas.Click += new System.EventHandler(this.btnPruebas_Click);
            // 
            // DosCuadros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(585, 562);
            this.Controls.Add(this.btnPruebas);
            this.Controls.Add(this.btnDibujar);
            this.Name = "DosCuadros";
            this.Text = "DosCuadros";
            this.Load += new System.EventHandler(this.DosCuadros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Button btnPruebas;
    }
}
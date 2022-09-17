using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Graficacion
{
    public partial class Sierpinsky : Form
    {
        public Sierpinsky()
        {
            InitializeComponent();
        }

        Graphics dibujo;
        Pen pluma = new Pen(Color.Black, 2);
        Brush brush = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#7A3EB1"));

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            Point A, B, C;
            B = new Point(500, 38);
            C = new Point(64, 878);
            A = new Point(936, 878);
            int numIteraciones = Decimal.ToInt32(numericUpDown1.Value);

            DibujarSierpinsky(A, B, C, numIteraciones);
        }

        private void DibujarSierpinsky(Point A, Point B, Point C, int NumIteraciones)
        {
            if (NumIteraciones == 0)
            {
                DibujarTriangulo(A, B, C);
            }
            else
            {
                Point AB = new Point((B.X + A.X) / 2, (B.Y + A.Y) / 2);
                Point AC = new Point((C.X + A.X) / 2, (C.Y + A.Y) / 2);
                Point BC = new Point((C.X + B.X) / 2, (C.Y + B.Y) / 2);

                DibujarSierpinsky(A, AB, AC, NumIteraciones - 1);
                DibujarSierpinsky(AB, B, BC, NumIteraciones - 1);
                DibujarSierpinsky(AC, BC, C, NumIteraciones - 1);
            }
        }

        private void DibujarTriangulo(Point A, Point B, Point C)
        {
            Point[] Triangulo = { A, B, C};
            dibujo.DrawPolygon(pluma, Triangulo);
            dibujo.FillPolygon(brush, Triangulo);
        }

        private void Sierpinsky_Load(object sender, EventArgs e)
        {
            dibujo = this.CreateGraphics();
        }

        private void Sierpinsky_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            dibujo.Clear(System.Drawing.ColorTranslator.FromHtml("#404040"));
        }
    }
}

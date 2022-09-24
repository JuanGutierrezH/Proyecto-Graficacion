using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Proyecto_Graficacion.Unidad2
{
    public partial class DosCuadros : Form
    {
        public DosCuadros()
        {
            InitializeComponent();
        }

        Graphics dibujo;
        Graphics dibujoGraficacion;
        Pen pluma = new Pen(Color.Black, 3);
        Pen pluma2 = new Pen(Color.Black, 3);
        Brush brush = new SolidBrush(ColorTranslator.FromHtml("#7A3EB1"));
        //Brush 

        private void DosCuadros_Load(object sender, EventArgs e)
        {
            dibujo = this.CreateGraphics();
            dibujoGraficacion = this.CreateGraphics();

            //dibujo.TranslateTransform(301, 301);
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(DibujarCuadros);
            t.Start();
            Thread y = new Thread(DibujarCuadros2);
            y.Start();
        }

        private int formulaX(int numX, int numY, int angle, int xF, int yF)
        {
            float Cos = (float)Math.Cos(angle);
            float Sen = (float)Math.Sin(angle);
            float newCoord = (xF + (numX - xF) * Cos - (numY - yF) * Sen);

            return Convert.ToInt32(newCoord);
        }

        private int formulaY(int numX, int numY, int angle, int xF, int yF)
        {
            float Cos = (float)Math.Cos(angle);
            float Sen = (float)Math.Sin(angle);
            float newCoord = (yF + (numY - yF) * Cos + (numX - xF) * Sen);

            return Convert.ToInt32(newCoord);
        }
        
        private void DibujarCuadros()
        {
            Point cuadro11 = new Point(161, 186);
            Point cuadro12 = new Point(425, 186);
            Point cuadro13 = new Point(425, 452);
            Point cuadro14 = new Point(161, 452);
            Point[] cuadro1 = { cuadro11, cuadro12, cuadro13, cuadro14 };

            

            int yF = ((cuadro14.Y - cuadro11.Y) / 2) + cuadro11.Y;
            int xF = ((cuadro12.X - cuadro11.X) / 2) + cuadro11.X;

            

            int angle = 20;
            dibujo.DrawPolygon(pluma, cuadro1);
            bool rotar = true;

            for (int i = 1; i < 360; i++)
            {
                dibujo.Clear(ColorTranslator.FromHtml("#404040"));
                cuadro11 = new Point(formulaX(cuadro11.X, cuadro11.Y, angle, xF, yF), formulaY(cuadro11.X, cuadro11.Y, angle, xF, yF));
                cuadro12 = new Point(formulaX(cuadro12.X, cuadro12.Y, angle, xF, yF), formulaY(cuadro12.X, cuadro12.Y, angle, xF, yF));
                cuadro13 = new Point(formulaX(cuadro13.X, cuadro13.Y, angle, xF, yF), formulaY(cuadro13.X, cuadro13.Y, angle, xF, yF));
                cuadro14 = new Point(formulaX(cuadro14.X, cuadro14.Y, angle, xF, yF), formulaY(cuadro14.X, cuadro14.Y, angle, xF, yF));
                cuadro1[0] = cuadro11;
                cuadro1[1] = cuadro12;
                cuadro1[2] = cuadro13;
                cuadro1[3] = cuadro14;
                dibujo.FillPolygon(brush, cuadro1);
                dibujo.DrawEllipse(pluma, 2 + i, 2, 1, 1);
                
                Thread.Sleep(500);
            }
        }

        private void DibujarCuadros2()
        {
            Point cuadro21 = new Point(161, 186);
            Point cuadro22 = new Point(425, 186);
            Point cuadro23 = new Point(425, 452);
            Point cuadro24 = new Point(161, 452);
            Point[] cuadro2 = { cuadro21, cuadro22, cuadro23, cuadro24 };

            int yF = ((cuadro24.Y - cuadro21.Y) / 2) + cuadro21.Y;
            int xF = ((cuadro22.X - cuadro21.X) / 2) + cuadro21.X;

            int angle = -20;
            dibujoGraficacion.DrawPolygon(pluma2, cuadro2);
            bool rotar = true;

            for (int i = 1; i < 360; i++)
            {
                dibujoGraficacion.Clear(ColorTranslator.FromHtml("#404040"));
                cuadro21 = new Point(formulaX(cuadro21.X, cuadro21.Y, angle, xF, yF), formulaY(cuadro21.X, cuadro21.Y, angle, xF, yF));
                cuadro22 = new Point(formulaX(cuadro22.X, cuadro22.Y, angle, xF, yF), formulaY(cuadro22.X, cuadro22.Y, angle, xF, yF));
                cuadro23 = new Point(formulaX(cuadro23.X, cuadro23.Y, angle, xF, yF), formulaY(cuadro23.X, cuadro23.Y, angle, xF, yF));
                cuadro24 = new Point(formulaX(cuadro24.X, cuadro24.Y, angle, xF, yF), formulaY(cuadro24.X, cuadro24.Y, angle, xF, yF));
                cuadro2[0] = cuadro21;
                cuadro2[1] = cuadro22;
                cuadro2[2] = cuadro23;
                cuadro2[3] = cuadro24;
                
                dibujoGraficacion.DrawPolygon(pluma2, cuadro2);
                dibujoGraficacion.DrawEllipse(pluma2, 2 + i, 2, 1, 1);
                Thread.Sleep(500);
            }
        }

        //private void DibujoFantasma(int x)
        //{
        //    dibujoGraficacion.DrawEllipse(pluma2, 2+x, 2, 1, 1);
        //}

        private void btnPruebas_Click(object sender, EventArgs e)
        {
            //Rectangle cuadro1 = new Rectangle(-150, -150, 300, 300);
            //int x = formulaX(cuadro1.X, cuadro1.Y,5 );
            //int y = formulaY(cuadro1.X, cuadro1.Y, 5);

            //MessageBox.Show($"{x} + {y}");

        }
    }
}

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

        private float formulaX(float numX, float numY, int angle, float xF, float yF)
        {
            float Cos = (float)Math.Cos(angle);
            float Sen = (float)Math.Sin(angle);
            float newCoord = (xF + (numX - xF) * Cos - (numY - yF) * Sen);

            return newCoord;
        }

        private float formulaY(float numX, float numY, int angle, float xF, float yF)
        {
            float Cos = (float)Math.Cos(angle);
            float Sen = (float)Math.Sin(angle);
            float newCoord = (yF + (numY - yF) * Cos + (numX - xF) * Sen);

            return newCoord;
        }
        
        private void DibujarCuadros()
        {
            PointF cuadro11 = new Point(161, 186);
            PointF cuadro12 = new Point(425, 186);
            PointF cuadro13 = new Point(425, 452);
            PointF cuadro14 = new Point(161, 452);
            PointF[] cuadro1 = { cuadro11, cuadro12, cuadro13, cuadro14 };

            float yF = ((cuadro14.Y - cuadro11.Y) / 2) + cuadro11.Y;
            float xF = ((cuadro12.X - cuadro11.X) / 2) + cuadro11.X;

            int angle = 360;
            dibujo.DrawPolygon(pluma, cuadro1);
            bool rotar = true;

            for (int i = 1; i < 360; i++)
            {
                dibujo.Clear(ColorTranslator.FromHtml("#404040"));
                cuadro11 = new PointF(formulaX(cuadro11.X, cuadro11.Y, angle, xF, yF), formulaY(cuadro11.X, cuadro11.Y, angle, xF, yF));
                cuadro12 = new PointF(formulaX(cuadro12.X, cuadro12.Y, angle, xF, yF), formulaY(cuadro12.X, cuadro12.Y, angle, xF, yF));
                cuadro13 = new PointF(formulaX(cuadro13.X, cuadro13.Y, angle, xF, yF), formulaY(cuadro13.X, cuadro13.Y, angle, xF, yF));
                cuadro14 = new PointF(formulaX(cuadro14.X, cuadro14.Y, angle, xF, yF), formulaY(cuadro14.X, cuadro14.Y, angle, xF, yF));
                cuadro1[0] = cuadro11;
                cuadro1[1] = cuadro12;
                cuadro1[2] = cuadro13;
                cuadro1[3] = cuadro14;

                
                dibujo.FillPolygon(brush, cuadro1);
                dibujo.DrawEllipse(pluma, 2 + i, 2, 1, 1);

                Thread.Sleep(100);
            }
        }

        private void DibujarCuadros2()
        {
            PointF cuadro21 = new Point(161, 186);
            PointF cuadro22 = new Point(425, 186);
            PointF cuadro23 = new Point(425, 452);
            PointF cuadro24 = new Point(161, 452);
            PointF[] cuadro2 = { cuadro21, cuadro22, cuadro23, cuadro24 };

            float yF = ((cuadro24.Y - cuadro21.Y) / 2) + cuadro21.Y;
            float xF = ((cuadro22.X - cuadro21.X) / 2) + cuadro21.X;

            int angle = -360;
            dibujoGraficacion.DrawPolygon(pluma2, cuadro2);
            bool rotar = true;

            for (int i = 1; i < 360; i++)
            {
                dibujoGraficacion.Clear(ColorTranslator.FromHtml("#404040"));
                cuadro21 = new PointF(formulaX(cuadro21.X, cuadro21.Y, angle, xF, yF), formulaY(cuadro21.X, cuadro21.Y, angle, xF, yF));
                cuadro22 = new PointF(formulaX(cuadro22.X, cuadro22.Y, angle, xF, yF), formulaY(cuadro22.X, cuadro22.Y, angle, xF, yF));
                cuadro23 = new PointF(formulaX(cuadro23.X, cuadro23.Y, angle, xF, yF), formulaY(cuadro23.X, cuadro23.Y, angle, xF, yF));
                cuadro24 = new PointF(formulaX(cuadro24.X, cuadro24.Y, angle, xF, yF), formulaY(cuadro24.X, cuadro24.Y, angle, xF, yF));
                cuadro2[0] = cuadro21;
                cuadro2[1] = cuadro22;
                cuadro2[2] = cuadro23;
                cuadro2[3] = cuadro24;
                dibujoGraficacion.DrawPolygon(pluma2, cuadro2);

                dibujoGraficacion.DrawEllipse(pluma2, 2 + i, 2, 1, 1);
                Thread.Sleep(100);
            }
        }

        //private void DibujoFantasma(int x)
        //{
        //    dibujoGraficacion.DrawEllipse(pluma2, 2+x, 2, 1, 1);
        //}


        private void DosCuadros_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu mainMenu = new Menu();
            mainMenu.Show();
        }
    }
}

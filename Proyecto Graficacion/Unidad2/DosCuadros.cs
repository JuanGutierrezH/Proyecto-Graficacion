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
        Pen pluma = new Pen(Color.Black, 3);
        Brush brush = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#7A3EB1"));

        private void DosCuadros_Load(object sender, EventArgs e)
        {
            dibujo = this.CreateGraphics();
            //dibujo.TranslateTransform(301, 301);
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            Point cuadro11 = new Point(161, 186);
            Point cuadro12 = new Point(425, 186);
            Point cuadro13 = new Point(425, 452);
            Point cuadro14 = new Point(161, 452);
            Point[] cuadro1 = { cuadro11, cuadro12, cuadro13, cuadro14 };

            Point cuadro21 = new Point(161, 186);
            Point cuadro22 = new Point(425, 186);
            Point cuadro23 = new Point(425, 452);
            Point cuadro24 = new Point(161, 452);
            Point[] cuadro2 = { cuadro21, cuadro22, cuadro23, cuadro24 };

            //Point cuadro21 = new Point(161, 186);
            //Rectangle cuadro1 = new Rectangle(-150, -150, 300, 300);
            //Rectangle cuadro1 = new Rectangle(-150, -150, 300, 300);

            int angle = 5;
            dibujo.DrawPolygon(pluma, cuadro1);
            Thread.Sleep(20);
            for (int i = 1; i < 30; i++)
            {
                dibujo.Clear(System.Drawing.ColorTranslator.FromHtml("#404040"));
                cuadro11 = new Point(formulaX(cuadro11.X, cuadro11.Y, angle * i), formulaY(cuadro11.X, cuadro11.Y, angle * i));
                cuadro12 = new Point(formulaX(cuadro12.X, cuadro12.Y, angle*i), formulaY(cuadro12.X, cuadro12.Y, angle * i));
                cuadro13 = new Point(formulaX(cuadro13.X, cuadro13.Y, angle * i), formulaY(cuadro13.X, cuadro13.Y, angle * i));
                cuadro14 = new Point(formulaX(cuadro14.X, cuadro14.Y, angle * i), formulaY(cuadro14.X, cuadro14.Y, angle * i));
                cuadro1[0] = cuadro11;
                cuadro1[1] = cuadro12;
                cuadro1[2] = cuadro13;
                cuadro1[3] = cuadro14;
                //cuadro1 = new Rectangle(formulaX(cuadro1.X, cuadro1.Y), formulaX(cuadro1.X, cuadro1.Y), 300, 300);
                dibujo.DrawPolygon(pluma, cuadro1);
                Thread.Sleep(2000);
            }
        }


        private int formulaX(int numX, int numY, int angle)
        {
            double Cos = Math.Cos(angle);
            double Sen = Math.Sin(angle);
            double xF = 301;
            double yF = 301;
            double newCoord = (xF + ((numX - xF) * Cos)) + ((numY - yF) * Sen);

            return Convert.ToInt32(newCoord);
        }

        private int formulaY(int numX, int numY, int angle)
        {
            double Cos = Math.Cos(angle);
            double Sen = Math.Sin(angle);
            double xF = 301;
            double yF = 301;
            double newCoord = (yF + ((numY - yF) * Cos)) + ((numX - xF) * Sen);

            return Convert.ToInt32(newCoord);
        }

        private void btnPruebas_Click(object sender, EventArgs e)
        {
            //Rectangle cuadro1 = new Rectangle(-150, -150, 300, 300);
            //int x = formulaX(cuadro1.X, cuadro1.Y, );
            //int y = formulaY(cuadro1.X, cuadro1.Y);

            //MessageBox.Show($"{x} + {y}");

        }
    }
}

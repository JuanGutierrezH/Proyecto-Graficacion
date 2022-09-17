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
    public partial class TrackBar : Form
    {
        public TrackBar()
        {
            InitializeComponent();
        }

        Graphics dibujo;
        Pen pluma = new Pen(Color.Black, 3);
        Brush brush = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#7A3EB1"));

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            dibujo.Clear(System.Drawing.ColorTranslator.FromHtml("#404040"));
            int scroll = trackBar1.Value;
            switch (scroll)
            {
                case 0:
                    dibujo.DrawEllipse(pluma, 100, 170, 100, 100 );
                    dibujo.FillEllipse(brush, 100, 170, 100, 100 );
                    break;
                case 1:
                    dibujo.DrawLine(pluma, 230, 250, 300, 250);

                    break;
                case 2:
                    Point Linea1 = new Point(330, 250);
                    Point Linea2 = new Point(400, 250);
                    Point Linea3 = new Point(400, 180);
                    PointF[] b = { Linea1, Linea2, Linea3 };
                    dibujo.DrawLines(pluma, b);
                    break;
                case 3:
                    Point Triangulo1 = new Point(446, 277);
                    Point Triangulo2 = new Point(492, 190);
                    Point Triangulo3 = new Point(539, 277);
                    Point[] Triangulo = { Triangulo1, Triangulo2, Triangulo3 };
                    dibujo.DrawPolygon(pluma, Triangulo);
                    dibujo.FillPolygon(brush, Triangulo);
                    break;
                case 4:
                    Point Cuadrado1 = new Point(554, 203);
                    Point Cuadrado2 = new Point(634, 203);
                    Point Cuadrado3 = new Point(634, 283);
                    Point Cuadrado4 = new Point(554, 283);
                    Point[] Cuadrado = { Cuadrado1, Cuadrado2, Cuadrado3, Cuadrado4 };
                    dibujo.DrawPolygon(pluma, Cuadrado);
                    dibujo.FillPolygon(brush, Cuadrado);
                    break;
                case 5:
                    Point Penta1 = new Point(655, 213);
                    Point Penta2 = new Point(706, 175);
                    Point Penta3 = new Point(757, 213);
                    Point Penta4 = new Point(739, 273);
                    Point Penta5 = new Point(674, 273);
                    Point[] Penta = { Penta1, Penta2, Penta3, Penta4, Penta5 };
                    dibujo.DrawPolygon(pluma, Penta);
                    dibujo.FillPolygon(brush, Penta);
                    break;
                case 6:
                    Point Hexa1 = new Point(754, 201);
                    Point Hexa2 = new Point(804, 174);
                    Point Hexa3 = new Point(852, 201);
                    Point Hexa4 = new Point(852, 255);
                    Point Hexa5 = new Point(804, 282);
                    Point Hexa6 = new Point(754, 255);
                    Point[] Hexa = { Hexa1, Hexa2, Hexa3, Hexa4, Hexa5, Hexa6 };
                    dibujo.DrawPolygon(pluma, Hexa);
                    dibujo.FillPolygon(brush, Hexa);
                    break;
                case 7:
                    Point Hepta1 = new Point(854, 244);
                    Point Hepta2 = new Point(868, 201);
                    Point Hepta3 = new Point(909, 181);
                    Point Hepta4 = new Point(950, 201);
                    Point Hepta5 = new Point(960, 244);
                    Point Hepta6 = new Point(931, 280);
                    Point Hepta7 = new Point(886, 280);
                    Point[] Hepta = { Hepta1, Hepta2, Hepta3, Hepta4, Hepta5, Hepta6, Hepta7 };
                    dibujo.DrawPolygon(pluma, Hepta);
                    dibujo.FillPolygon(brush, Hepta);
                    break;
                case 8:
                    Point Octa1 = new Point(955, 223);
                    Point Octa2 = new Point(980, 197);
                    Point Octa3 = new Point(1017, 197);
                    Point Octa4 = new Point(1043, 223);
                    Point Octa5 = new Point(1043, 260);
                    Point Octa6 = new Point(1017, 286);
                    Point Octa7 = new Point(980, 286);
                    Point Octa8 = new Point(955, 260);
                    Point[] Octa = {Octa1, Octa2, Octa3, Octa4, Octa5, Octa6, Octa7, Octa8 };
                    dibujo.DrawPolygon(pluma, Octa);
                    dibujo.FillPolygon(brush, Octa);
                    break;
                case 9:
                    Point Enea1 = new Point(1055, 234);
                    Point Enea2 = new Point(1070, 198);
                    Point Enea3 = new Point(1105, 183);
                    Point Enea4 = new Point(1141, 198);
                    Point Enea5 = new Point(1156, 234);
                    Point Enea6 = new Point(1141, 269);
                    Point Enea7 = new Point(1105, 284);
                    Point Enea8 = new Point(1082, 279);
                    Point Enea9 = new Point(1070, 269);
                    Point[] Enea = { Enea1, Enea2, Enea3, Enea4, Enea5, Enea6, Enea7, Enea9 };
                    dibujo.DrawPolygon(pluma, Enea);
                    dibujo.FillPolygon(brush, Enea);
                    break;
                case 10:
                    Point Deca1 = new Point(1160, 212);
                    Point Deca2 = new Point(1180, 186);
                    Point Deca3 = new Point(1211, 175);
                    Point Deca4 = new Point(1243, 186);
                    Point Deca5 = new Point(1263, 212);
                    Point Deca6 = new Point(1263, 246);
                    Point Deca7 = new Point(1243, 273);
                    Point Deca8 = new Point(1211, 283);
                    Point Deca9 = new Point(1180, 273);
                    Point Deca10 = new Point(1160, 246);
                    Point[] Deca = { Deca1, Deca2, Deca3, Deca4, Deca5, Deca6, Deca7, Deca8, Deca9, Deca10 };
                    dibujo.DrawPolygon(pluma, Deca);
                    dibujo.FillPolygon(brush, Deca);
                    break;

                default:
                    break;
            }
        }

        private void TrackBar_Load(object sender, EventArgs e)
        {
            dibujo = this.CreateGraphics();
            dibujo.DrawEllipse(pluma, 100, 170, 100, 100);
            dibujo.FillEllipse(brush, 100, 170, 100, 100);
        }

        private void TrackBar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }

    }
}

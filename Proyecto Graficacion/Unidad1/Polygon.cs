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
    public partial class Polygon : Form
    {
        public Polygon()
        {
            InitializeComponent();
        }
   
        private void Polygon_Load(object sender, EventArgs e)
        {
             dibujo1 = this.CreateGraphics();
        }
        
        Graphics dibujo1;
        Pen pluma1 = new Pen(Color.Black, 3);
        SolidBrush brushCafe = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#E0AF76"));
        SolidBrush brushAmarilloBoca = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#FFFBC4"));
        SolidBrush brushOjos = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#000000"));
        SolidBrush brushOrejas = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#463625"));
        SolidBrush brushPatas = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#A47E56"));

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            // Cuerpo
            Point cuerpo1 = new Point(150, 200);
            Point cuerpo2 = new Point(110, 400);
            Point cuerpo3 = new Point(190, 400);
            Point[] cuerpo = { cuerpo1, cuerpo2, cuerpo3 };
            dibujo1.DrawPolygon(pluma1, cuerpo);
            dibujo1.FillPolygon(brushCafe, cuerpo);

            // Boca
            dibujo1.DrawRectangle(pluma1, 100, 150, 50, 50);
            dibujo1.FillRectangle(brushAmarilloBoca, 100, 150, 50, 50);
            dibujo1.DrawRectangle(pluma1, 150, 150, 50, 50);
            dibujo1.FillRectangle(brushAmarilloBoca, 150, 150, 50, 50);

            dibujo1.FillRectangle(brushOjos, 141, 164, 20, 16);

            // Cabeza
            dibujo1.DrawRectangle(pluma1, 120, 100, 60, 50);
            dibujo1.FillRectangle(brushCafe, 120, 100, 60, 50);

            // Patas traseras
            dibujo1.DrawRectangle(pluma1, 110, 400, 25, 10);
            dibujo1.FillRectangle(brushCafe, 110, 400, 25, 10);
            dibujo1.DrawRectangle(pluma1, 165, 400, 25, 10);
            dibujo1.FillRectangle(brushCafe, 165, 400, 25, 10);

            // Patas delanteras
            Point pataderecha1 = new Point(168, 285);
            Point pataderecha2 = new Point(250, 350);
            Point pataderecha3 = new Point(190, 395);
            Point[] pataDerecha = { pataderecha1, pataderecha2, pataderecha3 };
            dibujo1.DrawPolygon(pluma1, pataDerecha);
            dibujo1.FillPolygon(brushPatas, pataDerecha);

            Point pataIzquierda1 = new Point(132, 284);
            Point pataIzquierda2 = new Point(54, 350);
            Point pataIzquierda3 = new Point(110, 395);
            Point[] pataIzquierda = { pataIzquierda1, pataIzquierda2, pataIzquierda3 };
            dibujo1.DrawPolygon(pluma1, pataIzquierda);
            dibujo1.FillPolygon(brushPatas, pataIzquierda);

            Point pataChicaDerecha1 = new Point(90, 380);
            Point pataChicaDerecha2 = new Point(95, 410);
            Point pataChicaDerecha3 = new Point(65, 410);
            Point[] pataChicaDerecha = { pataChicaDerecha1, pataChicaDerecha2, pataChicaDerecha3 };
            dibujo1.DrawPolygon(pluma1, pataChicaDerecha);
            dibujo1.FillPolygon(brushCafe, pataChicaDerecha);

            Point pataChicaIzquierda1 = new Point(214, 380);
            Point pataChicaIzquierda2 = new Point(209, 410);
            Point pataChicaIzquierda3 = new Point(239, 410);
            Point[] pataChicaIzquierda = { pataChicaIzquierda1, pataChicaIzquierda2, pataChicaIzquierda3 };
            dibujo1.DrawPolygon(pluma1, pataChicaIzquierda);
            dibujo1.FillPolygon(brushCafe, pataChicaIzquierda);

            // Ojos
            dibujo1.FillEllipse(brushOjos, 130, 140, 7, 7);
            dibujo1.FillEllipse(brushOjos, 160, 140, 7, 7);


            // Oreja derecha
            Point OrejaDerecha1 = new Point(180, 100);
            Point OrejaDerecha2 = new Point(195, 85);
            Point OrejaDerecha3 = new Point(235, 180);
            Point OrejaDerecha4 = new Point(250, 170);
            Point[] OrejaDerecha = { OrejaDerecha1, OrejaDerecha2, OrejaDerecha4, OrejaDerecha3 };
            dibujo1.DrawPolygon(pluma1, OrejaDerecha);
            dibujo1.FillPolygon(brushOrejas, OrejaDerecha);

            // Oreja izquierda
            Point OrejaIzquierda1 = new Point(120, 100);
            Point OrejaIzquierda2 = new Point(108, 83);
            Point OrejaIzquierda3 = new Point(55, 170);
            Point OrejaIzquierda4 = new Point(67, 180);
            Point[] OrejaIzquierda = { OrejaIzquierda1, OrejaIzquierda2, OrejaIzquierda3, OrejaIzquierda4 };
            dibujo1.DrawPolygon(pluma1, OrejaIzquierda);
            dibujo1.FillPolygon(brushOrejas, OrejaIzquierda);

        }

        private void Polygon_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }
    }
}

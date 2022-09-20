using DevExpress.Data.Filtering.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraBars.Docking2010.Views.BaseRegistrator;

namespace Proyecto_Graficacion.Unidad2
{
    public partial class Escalamiento : Form
    {
        public Escalamiento()
        {
            InitializeComponent();
        }

        Graphics dibujo;
        Pen pluma = new Pen(Color.Black, 4);
        Brush brush = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#7A3EB1"));


        private void Escalamiento_Load(object sender, EventArgs e)
        {
            dibujo = this.CreateGraphics();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            dibujo.Clear(System.Drawing.ColorTranslator.FromHtml("#404040"));
            dibujo = this.CreateGraphics();
            int circleWH = 110;
            dibujo.TranslateTransform(100, 100);

            dibujo.FillEllipse(brush, 145, 245, circleWH, circleWH);
            dibujo.DrawEllipse(pluma, 90, 245, circleWH, circleWH);
            dibujo.DrawEllipse(pluma, 200, 245, circleWH, circleWH);

            dibujo.DrawEllipse(pluma, 90, 190, 220, 220);
            dibujo.DrawEllipse(pluma, 174, 198, circleWH, circleWH);
            dibujo.DrawEllipse(pluma, 115, 198, circleWH, circleWH);
            dibujo.DrawEllipse(pluma, 173, 290, circleWH, circleWH);
            dibujo.DrawEllipse(pluma, 116, 290, circleWH, circleWH);
            dibujo.DrawEllipse(pluma, 145, 245, circleWH, circleWH);
            dibujo.DrawEllipse(pluma, 103, 204, 190, 190);

            dibujo.DrawLine(pluma, 200, 300, 310, 300);
            dibujo.DrawLine(pluma, 200, 300, 200, 190);
            dibujo.DrawLine(pluma, 200, 300, 90, 300);
            dibujo.DrawLine(pluma, 200, 300, 200, 410);
            dibujo.DrawLine(pluma, 200, 300, 145, 396);
            dibujo.DrawLine(pluma, 200, 300, 255, 396);
            dibujo.DrawLine(pluma, 200, 300, 105, 356);
            dibujo.DrawLine(pluma, 200, 300, 105, 245);
            dibujo.DrawLine(pluma, 200, 300, 145, 203);
            dibujo.DrawLine(pluma, 200, 300, 255, 205);
            dibujo.DrawLine(pluma, 200, 300, 296, 245);
            dibujo.DrawLine(pluma, 200, 300, 296, 356);
        }

        private void btnEscalar_Click(object sender, EventArgs e)
        {
            dibujo.Clear(System.Drawing.ColorTranslator.FromHtml("#404040"));
            int fS = Decimal.ToInt32(nud1.Value);

            if (fS == 0)
            {
                return;
            }

            dibujo.FillEllipse(brush, (145 * fS) + (1 - fS) * 200, (245 * fS) + (1 - fS) * 300, 110 * fS, 110 * fS);
            dibujo.DrawEllipse(pluma, (90 * fS) + (1 - fS) * 200, (245 * fS) + (1 - fS) * 300, 110 * fS, 110 * fS);
            dibujo.DrawEllipse(pluma, (200 * fS) + (1 - fS) * 200, (245 * fS) + (1 - fS) * 300, 110 * fS, 110 * fS);
            dibujo.DrawEllipse(pluma, (174 * fS) + (1 - fS) * 200, (198 * fS) + (1 - fS) * 300, 110 * fS, 110 * fS);
            dibujo.DrawEllipse(pluma, (115 * fS) + (1 - fS) * 200, (198 * fS) + (1 - fS) * 300, 110 * fS, 110 * fS);
            dibujo.DrawEllipse(pluma, (173 * fS) + (1 - fS) * 200, (290 * fS) + (1 - fS) * 300, 110 * fS, 110 * fS);
            dibujo.DrawEllipse(pluma, (116 * fS) + (1 - fS) * 200, (290 * fS) + (1 - fS) * 300, 110 * fS, 110 * fS);
            dibujo.DrawEllipse(pluma, (145 * fS) + (1 - fS) * 200, (245 * fS) + (1 - fS) * 300, 110 * fS, 110 * fS);

            dibujo.DrawEllipse(pluma, (90 * fS) + (1 - fS) * 200, (190 * fS) + (1 - fS) * 300, 220 * fS, 220 * fS);
            dibujo.DrawEllipse(pluma, (103 * fS) + (1 - fS) * 200, (204 * fS) + (1 - fS) * 300, 190 * fS, 190 * fS);

            dibujo.DrawLine(pluma, 200, 300, (310 * fS) + (1 - fS) * 200, (300 * fS) + (1 - fS) * 300);
            dibujo.DrawLine(pluma, 200, 300, (200 * fS) + (1 - fS) * 200, (190 * fS) + (1 - fS) * 300);
            dibujo.DrawLine(pluma, 200, 300, (90 * fS) + (1 - fS) * 200, (300 * fS) + (1 - fS) * 300);
            dibujo.DrawLine(pluma, 200, 300, (200 * fS) + (1 - fS) * 200, (410 * fS) + (1 - fS) * 300);
            dibujo.DrawLine(pluma, 200, 300, (145 * fS) + (1 - fS) * 200, (396 * fS) + (1 - fS) * 300);
            dibujo.DrawLine(pluma, 200, 300, (255 * fS) + (1 - fS) * 200, (396 * fS) + (1 - fS) * 300);
            dibujo.DrawLine(pluma, 200, 300, (105 * fS) + (1 - fS) * 200, (356 * fS) + (1 - fS) * 300);
            dibujo.DrawLine(pluma, 200, 300, (105 * fS) + (1 - fS) * 200, (245 * fS) + (1 - fS) * 300);
            dibujo.DrawLine(pluma, 200, 300, (145 * fS) + (1 - fS) * 200, (203 * fS) + (1 - fS) * 300);
            dibujo.DrawLine(pluma, 200, 300, (255 * fS) + (1 - fS) * 200, (205 * fS) + (1 - fS) * 300);
            dibujo.DrawLine(pluma, 200, 300, (296 * fS) + (1 - fS) * 200, (245 * fS) + (1 - fS) * 300);
            dibujo.DrawLine(pluma, 200, 300, (296 * fS) + (1 - fS) * 200, (356 * fS) + (1 - fS) * 300);
        }

        private void Escalamiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }
    }
}

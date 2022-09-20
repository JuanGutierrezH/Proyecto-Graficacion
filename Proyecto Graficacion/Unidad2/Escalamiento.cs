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

        private void btnEscalar_Click(object sender, EventArgs e)
        {
            dibujo = this.CreateGraphics();
            dibujo.TranslateTransform(200, 100);
            dibujo.Clear(System.Drawing.ColorTranslator.FromHtml("#404040"));
            int fS = Decimal.ToInt32(nud1.Value);
            int circleWH = 110;

            //if (fS == 0)
            //{

            //}

            dibujo.FillEllipse(brush, FormulaCoordx(145), FormulaCoordy(245), circleWH * fS, circleWH * fS);
            dibujo.DrawEllipse(pluma, FormulaCoordx(90), FormulaCoordy(245), circleWH * fS, circleWH * fS);
            dibujo.DrawEllipse(pluma, FormulaCoordx(200), FormulaCoordy(245), circleWH * fS, circleWH * fS);
            dibujo.DrawEllipse(pluma, FormulaCoordx(174), FormulaCoordy(198), circleWH * fS, circleWH * fS);
            dibujo.DrawEllipse(pluma, FormulaCoordx(115), FormulaCoordy(198), circleWH * fS, circleWH * fS);
            dibujo.DrawEllipse(pluma, FormulaCoordx(173), FormulaCoordy(290), circleWH * fS, circleWH * fS);
            dibujo.DrawEllipse(pluma, FormulaCoordx(116), FormulaCoordy(290), circleWH * fS, circleWH * fS);
            dibujo.DrawEllipse(pluma, FormulaCoordx(145), FormulaCoordy(245), circleWH * fS, circleWH * fS);

            dibujo.DrawEllipse(pluma, FormulaCoordx(90), FormulaCoordy(190), 220 * fS, 220 * fS);
            dibujo.DrawEllipse(pluma, FormulaCoordx(103), FormulaCoordy(204), 190 * fS, 190 * fS);

            dibujo.DrawLine(pluma, 200, 300, FormulaCoordx(310), FormulaCoordy(300)); 
            dibujo.DrawLine(pluma, 200, 300, FormulaCoordx(200), FormulaCoordy(190));
            dibujo.DrawLine(pluma, 200, 300, FormulaCoordx(90), FormulaCoordy(300));
            dibujo.DrawLine(pluma, 200, 300, FormulaCoordx(200), FormulaCoordy(410));
            dibujo.DrawLine(pluma, 200, 300, FormulaCoordx(145), FormulaCoordy(396));
            dibujo.DrawLine(pluma, 200, 300, FormulaCoordx(255), FormulaCoordy(396));
            dibujo.DrawLine(pluma, 200, 300, FormulaCoordx(105), FormulaCoordy(356));
            dibujo.DrawLine(pluma, 200, 300, FormulaCoordx(105), FormulaCoordy(245));
            dibujo.DrawLine(pluma, 200, 300, FormulaCoordx(145), FormulaCoordy(203));
            dibujo.DrawLine(pluma, 200, 300, FormulaCoordx(255), FormulaCoordy(205));
            dibujo.DrawLine(pluma, 200, 300, FormulaCoordx(296), FormulaCoordy(245));
            dibujo.DrawLine(pluma, 200, 300, FormulaCoordx(296), FormulaCoordy(356));
        }

        private void Escalamiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }

        private int FormulaCoordx(int num)
        {
            int fS = Decimal.ToInt32(nud1.Value);
            int xF = 200;
            int nuevaCoord = (num * fS) + (1 - fS) * xF;

            return nuevaCoord;
        }

        private int FormulaCoordy(int num)
        {
            int fS = Decimal.ToInt32(nud1.Value);
            int yF = 300;
            int nuevaCoord = (num * fS) + (1 - fS) * yF;

            return nuevaCoord;
        }
    }
}

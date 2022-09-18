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

namespace Proyecto_Graficacion
{
    public partial class Traslacion : Form
    {
        public Traslacion()
        {
            InitializeComponent();
        }

        Graphics dibujo;
        Pen pluma = new Pen(Color.Black, 3);
        Brush brush = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#7A3EB1"));

        Rectangle cuadro1 = new Rectangle(300, 400, 100, 100);
        Rectangle cuadro2 = new Rectangle(450, 400, 100, 100);
        Rectangle cuadro3 = new Rectangle(600, 400, 100, 100);

        private void Traslacion_Load(object sender, EventArgs e)
        {
            dibujo = this.CreateGraphics();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(DibujarCuadros);
            t.Start();
        }

        private void DibujarCuadros()
        {
            int numIteraciones = 50;
            int dy = 2;
            int dx = 2;

            for (int i = 0; i < numIteraciones; i++)
            {
                dibujo.Clear(System.Drawing.ColorTranslator.FromHtml("#404040"));
                dibujo.DrawRectangle(pluma, cuadro1);
                dibujo.DrawRectangle(pluma, cuadro2);
                dibujo.DrawRectangle(pluma, cuadro3);
                Thread.Sleep(20);

                cuadro1 = new Rectangle(cuadro1.X - dx, cuadro1.Y - dy, 100, 100);
                cuadro2 = new Rectangle(cuadro2.X, cuadro2.Y - dy, 100, 100);
                cuadro3 = new Rectangle(cuadro3.X + dx, cuadro3.Y - dy, 100, 100);
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            dibujo.SetClip(new Rectangle(300, 400, 100, 100));
            dibujo.TranslateClip(100, 100);
        }
    }
}

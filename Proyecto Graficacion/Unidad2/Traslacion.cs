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
        Graphics dibujo2;
        Pen pluma = new Pen(Color.Black, 3);
        Brush brush = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#7A3EB1"));

        Rectangle cuadro1 = new Rectangle(300, 400, 100, 100);
        Rectangle cuadro2 = new Rectangle(450, 400, 100, 100);
        Rectangle cuadro3 = new Rectangle(600, 400, 100, 100);
        Rectangle ghostCuadro = new Rectangle(2, 2, 1, 1);

        private void Traslacion_Load(object sender, EventArgs e)
        {
            dibujo = this.CreateGraphics();
            dibujo2 = this.CreateGraphics();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(DibujarCuadros);
            t.Start();
        }

        private void DibujarCuadros()
        {
            int numIteraciones = 50;
            int dy = 4;
            int dx = 4;

            for (int i = 0; i < numIteraciones; i++)
            {
                dibujo.Clear(System.Drawing.ColorTranslator.FromHtml("#404040"));
                dibujo.DrawRectangle(pluma, cuadro1);
                dibujo.DrawRectangle(pluma, cuadro2);
                dibujo2.DrawRectangle(pluma, cuadro3);
                //dibujo.DrawRectangle(pluma, ghostCuadro);
                Thread.Sleep(50);

                cuadro1 = new Rectangle(cuadro1.X - dx, cuadro1.Y - dy, 100, 100);
                cuadro2 = new Rectangle(cuadro2.X, cuadro2.Y - dy, 100, 100);
                cuadro3 = new Rectangle(cuadro3.X + dx, cuadro3.Y - dy , 100, 100);
                //ghostCuadro = new Rectangle(ghostCuadro.X + dx, ghostCuadro.Y, 1, 1);
            }
            for (int j = 0; j < numIteraciones; j++)
            {
                dibujo.Clear(System.Drawing.ColorTranslator.FromHtml("#404040"));
                dibujo.DrawRectangle(pluma, cuadro1);
                dibujo.DrawRectangle(pluma, cuadro2);
                dibujo2.DrawRectangle(pluma, cuadro3);
                //dibujo.DrawRectangle(pluma, ghostCuadro);

                Thread.Sleep(50);

                cuadro1 = new Rectangle(cuadro1.X + dx, cuadro1.Y + dy, 100, 100);
                cuadro2 = new Rectangle(cuadro2.X, cuadro2.Y + dy, 100, 100);
                cuadro3 = new Rectangle(cuadro3.X - dx, cuadro3.Y + dy, 100, 100);
                //ghostCuadro = new Rectangle(ghostCuadro.X + dx, ghostCuadro.Y, 1, 1);
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
        }
    }
}

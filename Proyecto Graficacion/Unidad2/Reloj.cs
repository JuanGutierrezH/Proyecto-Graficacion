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
    public partial class Reloj : Form
    {
        public Reloj()
        {
            InitializeComponent();
        }
        
        Graphics dibujo;
        Graphics dibujo2;
        Graphics dibujo3;
        Pen plumaHora = new Pen(Color.Black, 8);
        Pen plumaMinutos = new Pen(Color.Black, 6);
        Pen plumaSegundos = new Pen(Color.Red, 2);
        Brush brush = new SolidBrush(ColorTranslator.FromHtml("#404040"));
        Brush brush2 = new SolidBrush(ColorTranslator.FromHtml("#404040"));
        Brush brush3 = new SolidBrush(ColorTranslator.FromHtml("#404040"));


        private void Reloj_Load(object sender, EventArgs e)
        {
            dibujo = pictureBox1.CreateGraphics();
            dibujo2 = pictureBox1.CreateGraphics();
            dibujo3 = pictureBox1.CreateGraphics();
            dibujo.TranslateTransform(290, 280);
            dibujo2.TranslateTransform(290, 280);
            dibujo3.TranslateTransform(290, 280);
        }

        private void Reloj_Click(object sender, EventArgs e)
        {
            

        }

        PointF hora = new PointF(0, 0);
        PointF hora2 = new PointF(0, 120);
        PointF minutero = new PointF(0, 0);
        PointF minutero2 = new PointF(150, 0);
        PointF segundero = new PointF(0, 0);
        PointF segundero2 = new PointF(0, -150);
        int xF = 0;
        int yF = 0;

        private void btnIniciar_Click(object sender, EventArgs e)
        {
          
            Thread t = new Thread(dibujarHoras);
            t.Start();
            Thread y = new Thread(dibujarMinutos);
            y.Start();
            Thread x = new Thread(dibujarSegundos);
            x.Start();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dibujarHoras()
        {
            float anguloHoras = 360 / 12;
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(3600000);
                //dibujo.Clear(ColorTranslator.FromHtml("#404040"));
                dibujo.FillEllipse(brush, -150, -150, 300, 300);
                hora = new PointF(formulaX(hora.X, hora.Y, anguloHoras), formulaY(hora.X, hora.Y, anguloHoras));
                hora2 = new PointF(formulaX(hora2.X, hora2.Y, anguloHoras), formulaY(hora2.X, hora2.Y, anguloHoras));
                dibujo.DrawLine(plumaHora, hora, hora2);
                
            }
            
        }
        private void dibujarSegundos()
        {
            float anguloSegundos = 360 / 60;
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(1000);
                //dibujo3.Clear(ColorTranslator.FromHtml("#404040"));
                dibujo3.FillEllipse(brush3, -150,-150, 300, 300);
                segundero = new PointF(formulaX(segundero.X, segundero.Y, anguloSegundos), formulaY(segundero.X, segundero.Y, anguloSegundos));
                segundero2 = new PointF(formulaX(segundero2.X, segundero2.Y, anguloSegundos), formulaY(segundero2.X, segundero2.Y, anguloSegundos));
                dibujo3.DrawLine(plumaSegundos, segundero, segundero2);
                
            }
            
        }

        private void dibujarMinutos()
        {
            float anguloMinutos = 360 / 60;
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(60000);
                //dibujo2.Clear(ColorTranslator.FromHtml("#404040"));
                dibujo2.FillEllipse(brush2, -150, -150, 300, 300);
                minutero = new PointF(formulaX(minutero.X, minutero.Y, anguloMinutos), formulaY(minutero.X, minutero.Y, anguloMinutos));
                minutero2 = new PointF(formulaX(minutero2.X, minutero2.Y, anguloMinutos), formulaY(minutero2.X, minutero2.Y, anguloMinutos));
                dibujo2.DrawLine(plumaMinutos, minutero, minutero2);
                
            }
            
        }

        private void Reloj_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu mainMenu = new Menu();
            mainMenu.Show();
        }

        private float formulaX(float numX, float numY, float angle)
        {
            float Cos = (float)Math.Cos(angle);
            float Sen = (float)Math.Sin(angle);
            float newCoord = (xF + (numX - xF) * Cos - (numY - yF) * Sen);

            return newCoord;
        }

        private float formulaY(float numX, float numY, float angle)
        {
            float Cos = (float)Math.Cos(angle);
            float Sen = (float)Math.Sin(angle);
            float newCoord = (yF + (numY - yF) * Cos + (numX - xF) * Sen);

            return newCoord;
        }
    }
}

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
using DevExpress.Utils;

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
        Pen plumaHora = new Pen(Color.Black, 6);
        Pen plumaMinutos = new Pen(Color.Black, 6);
        Pen plumaSegundos = new Pen(Color.Red, 6);
        Pen plumaClear = new Pen(ColorTranslator.FromHtml("#404040"), 6);

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
            float cosHoras = 0.978147f;
            float senHoras = 0.207911f;


            int j = 0;
            float anguloHoras = -360 / 12;
            for (int i = 0; i < 999999999; i++)
            {
                if (j != 360000)
                {
                    dibujo.DrawLine(plumaHora, hora, hora2);
                    Thread.Sleep(1000);
                    j = j + 1000;
                }
                else
                {
                    dibujo.DrawLine(plumaClear, hora, hora2);
                    hora = new PointF(formulaX(hora.X, hora.Y, cosHoras, senHoras), formulaY(hora.X, hora.Y, cosHoras, senHoras));
                    hora2 = new PointF(formulaX(hora2.X, hora2.Y, cosHoras, senHoras), formulaY(hora2.X, hora2.Y, cosHoras, senHoras));
                    j = 0;
                }

            }
            
        }
        private void dibujarSegundos()
        {
            float anguloSegundos = -360 / 60;
            float cosSegundo = 0.994521f;
            float senSegundo = 0.104528f;



            for (int i = 0; i < 999999999; i++)
            {
                dibujo3.DrawLine(plumaSegundos, segundero, segundero2);
                Thread.Sleep(1000);
                dibujo3.DrawLine(plumaClear, segundero, segundero2);

                segundero = new PointF(formulaX(segundero.X, segundero.Y, cosSegundo, senSegundo), formulaY(segundero.X, segundero.Y, cosSegundo, senSegundo));
                segundero2 = new PointF(formulaX(segundero2.X, segundero2.Y, cosSegundo, senSegundo), formulaY(segundero2.X, segundero2.Y, cosSegundo, senSegundo));
            }
        }

        private void dibujarMinutos()
        {
            float anguloMinutos = -360 / 60;
            float cosSegundo = 0.994521f;
            float senSegundo = 0.104528f;

            int j = 0;
            for (int i = 0; i < 999999999; i++)
            {
                if (j != 60000)
                {
                    Thread.Sleep(1000);

                    dibujo2.DrawLine(plumaMinutos, minutero, minutero2);
                    //var guardar = dibujo.Save();
                    j = j + 1000;
                }
                else
                {
                    dibujo2.DrawLine(plumaClear, minutero, minutero2);
                    minutero = new PointF(formulaX(minutero.X, minutero.Y, cosSegundo, senSegundo), formulaY(minutero.X, minutero.Y, cosSegundo, senSegundo));
                    minutero2 = new PointF(formulaX(minutero2.X, minutero2.Y, cosSegundo, senSegundo), formulaY(minutero2.X, minutero2.Y, cosSegundo, senSegundo));
                    j = 0;
                }
            }

        }

        private void Reloj_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu mainMenu = new Menu();
            mainMenu.Show();
        }

        private float formulaX(float numX, float numY, float angle, float angle2)
        {
            float Cos = angle;
            float Sen = angle2;
            float newCoord = (xF + (numX - xF) * Cos - (numY - yF) * Sen);

            return newCoord;
        }

        private float formulaY(float numX, float numY, float angle, float angle2)
        {
            float Cos = angle;
            float Sen = angle2;
            float newCoord = (yF + (numY - yF) * Cos + (numX - xF) * Sen);

            return newCoord;
        }
    }
}

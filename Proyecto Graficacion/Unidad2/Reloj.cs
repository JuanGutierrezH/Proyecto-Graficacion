using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Graficacion.Unidad2
{
    public partial class Reloj : Form
    {
        public Reloj()
        {
            InitializeComponent();
        }
        
        Graphics dibujo;
        Pen plumaHora = new Pen(Color.Black, 8);
        Pen plumaMinutos = new Pen(Color.Black, 6);
        Pen plumaSegundos = new Pen(Color.Red, 2);
        Brush brush = new SolidBrush(ColorTranslator.FromHtml("#404040"));



        private void Reloj_Load(object sender, EventArgs e)
        {
            dibujo = pictureBox1.CreateGraphics();
        }

        private void Reloj_Click(object sender, EventArgs e)
        {
            

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            PointF hora = new PointF(0, 0);
            PointF hora2 = new PointF(0, 120);
            PointF minutero = new PointF(0, 0);
            PointF minutero2 = new PointF(150, 0);
            dibujo.TranslateTransform(290, 280);
            dibujo.FillEllipse(brush, -100, -170, 200, 200);
            dibujo.DrawLine(plumaMinutos, minutero, minutero2);
            dibujo.DrawLine(plumaHora, hora, hora2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Reloj_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu mainMenu = new Menu();
            mainMenu.Show();
        }
    }
}

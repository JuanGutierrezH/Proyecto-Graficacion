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
    public partial class Pixe : Form
    {
        public Pixe()
        {
            InitializeComponent();
        }

        Graphics dibujo;
        System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#8C0128");
        Pen pluma = new Pen(System.Drawing.ColorTranslator.FromHtml("#EF1832"), 5);

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            Brush brushgrisOs = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#7B7474"));
            Brush brushgrisO = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#948F8B"));
            Brush brushgris = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#B5B5B3"));
            Brush brushgrishumilde = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#4B4B4B"));
            Brush brushblack = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#1E1E1E"));
            Brush brushgrey = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#41403E"));
            Brush brushgrey2 = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#2E2B29"));
            Brush brushgrey3 = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#625C5C"));
            Brush brushDetalles = new SolidBrush(Color.Pink);
            Brush brush = new SolidBrush(col);

            // lado derecho
            dibujo.FillRectangle(brush, 600, 50, 10, 10);
            dibujo.FillRectangle(brush, 610, 50, 10, 10);
            dibujo.FillRectangle(brush, 620, 60, 10, 10);
            dibujo.FillRectangle(brush, 620, 70, 10, 10);
            dibujo.FillRectangle(brush, 630, 80, 10, 70);
            dibujo.FillRectangle(brush, 620, 150, 10, 50);
            dibujo.FillRectangle(brush, 610, 200, 10, 40);
            dibujo.FillRectangle(brush, 600, 240, 10, 30);
            dibujo.FillRectangle(brush, 590, 270, 10, 30);
            dibujo.FillRectangle(brush, 580, 300, 10, 30);
            dibujo.FillRectangle(brush, 570, 330, 10, 30);
            dibujo.FillRectangle(brush, 560, 360, 10, 20);
            dibujo.FillRectangle(brush, 550, 380, 10, 20);
            dibujo.FillRectangle(brush, 540, 400, 10, 20);
            dibujo.FillRectangle(brush, 530, 420, 10, 20);
            dibujo.FillRectangle(brush, 520, 440, 10, 20);
            dibujo.FillRectangle(brush, 510, 460, 10, 20);
            dibujo.FillRectangle(brush, 500, 480, 10, 20);
            dibujo.FillRectangle(brush, 490, 500, 10, 20);
            col = System.Drawing.ColorTranslator.FromHtml("#1E1E1E");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 480, 520, 10, 10);
            dibujo.FillRectangle(brush, 490, 530, 10, 30);
            dibujo.FillRectangle(brush, 460, 550, 30, 10);
            dibujo.FillRectangle(brush, 460, 560, 10, 10);
            dibujo.FillRectangle(brush, 450, 570, 10, 20);
            dibujo.FillRectangle(brush, 440, 590, 10, 20);
            dibujo.FillRectangle(brush, 430, 610, 10, 20);
            dibujo.FillRectangle(brush, 420, 630, 10, 20);
            dibujo.FillRectangle(brush, 410, 650, 10, 20);


            // lado izquierdo
            col = System.Drawing.ColorTranslator.FromHtml("#8C0128");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 600, 50, 10, 70);
            dibujo.FillRectangle(brush, 590, 120, 10, 50);
            dibujo.FillRectangle(brush, 580, 170, 10, 40);
            dibujo.FillRectangle(brush, 570, 210, 10, 30);
            dibujo.FillRectangle(brush, 560, 240, 10, 30);
            dibujo.FillRectangle(brush, 550, 270, 10, 30);
            dibujo.FillRectangle(brush, 540, 300, 10, 30);
            dibujo.FillRectangle(brush, 530, 330, 10, 20);
            dibujo.FillRectangle(brush, 520, 350, 10, 20);
            dibujo.FillRectangle(brush, 510, 370, 10, 20);
            dibujo.FillRectangle(brush, 500, 390, 10, 20);
            dibujo.FillRectangle(brush, 490, 410, 10, 20);
            dibujo.FillRectangle(brush, 480, 430, 10, 20);
            dibujo.FillRectangle(brush, 470, 450, 10, 20);
            dibujo.FillRectangle(brush, 460, 470, 10, 20);
            dibujo.FillRectangle(brush, 450, 490, 10, 10);
            col = System.Drawing.ColorTranslator.FromHtml("#1E1E1E");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 420, 500, 40, 10);
            dibujo.FillRectangle(brush, 420, 500, 10, 30);
            dibujo.FillRectangle(brush, 430, 530, 10, 20);
            dibujo.FillRectangle(brush, 420, 550, 10, 30);
            dibujo.FillRectangle(brush, 410, 580, 10, 20);
            dibujo.FillRectangle(brush, 400, 600, 10, 20);
            dibujo.FillRectangle(brush, 390, 620, 10, 20);
            dibujo.FillRectangle(brush, 380, 640, 10, 20);
            dibujo.FillRectangle(brush, 380, 660, 30, 10);


            // filo katana
            col = System.Drawing.ColorTranslator.FromHtml("#EF002E");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 610, 60, 10, 140);
            dibujo.FillRectangle(brush, 620, 80, 10, 70);
            col = System.Drawing.ColorTranslator.FromHtml("#C40038");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 600, 110, 10, 10);
            col = System.Drawing.ColorTranslator.FromHtml("#EF002E");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 600, 120, 10, 120);
            dibujo.FillRectangle(brush, 590, 170, 10, 30);
            col = System.Drawing.ColorTranslator.FromHtml("#CC0022");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 590, 200, 10, 40);
            col = System.Drawing.ColorTranslator.FromHtml("#EF002E");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 590, 240, 10, 30);
            dibujo.FillRectangle(brush, 580, 210, 10, 30);
            col = System.Drawing.ColorTranslator.FromHtml("#CC0022");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 580, 240, 10, 30);
            col = System.Drawing.ColorTranslator.FromHtml("#EF002E");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 580, 270, 10, 30);
            dibujo.FillRectangle(brush, 570, 240, 10, 30);
            col = System.Drawing.ColorTranslator.FromHtml("#CC0022");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 570, 270, 10, 30);
            col = System.Drawing.ColorTranslator.FromHtml("#EF002E");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 570, 300, 10, 30);
            dibujo.FillRectangle(brush, 560, 270, 10, 30);
            col = System.Drawing.ColorTranslator.FromHtml("#CC0022");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 560, 300, 10, 30);
            col = System.Drawing.ColorTranslator.FromHtml("#EF002E");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 560, 330, 10, 30);
            dibujo.FillRectangle(brush, 550, 300, 10, 30);
            col = System.Drawing.ColorTranslator.FromHtml("#CC0022");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 550, 330, 10, 20);
            col = System.Drawing.ColorTranslator.FromHtml("#EF002E");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 550, 350, 10, 30);
            dibujo.FillRectangle(brush, 540, 330, 10, 20);
            col = System.Drawing.ColorTranslator.FromHtml("#CC0022");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 540, 350, 10, 20);
            col = System.Drawing.ColorTranslator.FromHtml("#EF002E");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 540, 370, 10, 30);
            dibujo.FillRectangle(brush, 530, 350, 10, 20);
            col = System.Drawing.ColorTranslator.FromHtml("#CC0022");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 530, 370, 10, 30);
            col = System.Drawing.ColorTranslator.FromHtml("#EF002E");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 530, 400, 10, 20);
            dibujo.FillRectangle(brush, 520, 370, 10, 30);
            col = System.Drawing.ColorTranslator.FromHtml("#CC0022");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 520, 400, 10, 20);
            col = System.Drawing.ColorTranslator.FromHtml("#EF002E");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 520, 420, 10, 20);
            dibujo.FillRectangle(brush, 510, 390, 10, 30);
            col = System.Drawing.ColorTranslator.FromHtml("#CC0022");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 510, 420, 10, 20);
            col = System.Drawing.ColorTranslator.FromHtml("#EF002E");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 510, 440, 10, 20);
            dibujo.FillRectangle(brush, 500, 410, 10, 30);
            col = System.Drawing.ColorTranslator.FromHtml("#CC0022");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 500, 440, 10, 20);
            col = System.Drawing.ColorTranslator.FromHtml("#EF002E");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 500, 460, 10, 20);
            dibujo.FillRectangle(brush, 490, 430, 10, 30);
            col = System.Drawing.ColorTranslator.FromHtml("#CC0022");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 490, 460, 10, 20);
            col = System.Drawing.ColorTranslator.FromHtml("#EF002E");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 490, 480, 10, 20);
            dibujo.FillRectangle(brush, 480, 450, 10, 30);
            col = System.Drawing.ColorTranslator.FromHtml("#CC0022");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 480, 480, 10, 20);
            col = System.Drawing.ColorTranslator.FromHtml("#EF002E");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 480, 500, 10, 20);
            dibujo.FillRectangle(brush, 470, 470, 10, 30);
            col = System.Drawing.ColorTranslator.FromHtml("#CC0022");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 470, 500, 10, 10);
            col = System.Drawing.ColorTranslator.FromHtml("#EF002E");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 460, 490, 10, 30);
            col = System.Drawing.ColorTranslator.FromHtml("#CC0022");
            brush = new SolidBrush(col);
            dibujo.FillRectangle(brush, 470, 500, 10, 30);

            // mango
            dibujo.FillRectangle(brushgris, 460, 510, 10, 20);
            dibujo.FillRectangle(brushgris, 450, 510, 10, 10);
            dibujo.FillRectangle(brushgris, 470, 520, 10, 10);
            dibujo.FillRectangle(brushgris, 470, 530, 10, 10);
            dibujo.FillRectangle(brushgrisO, 480, 530, 10, 20);
            dibujo.FillRectangle(brushgrisO, 470, 540, 10, 10);
            dibujo.FillRectangle(brushgrisO, 440, 510, 10, 20);
            dibujo.FillRectangle(brushgris, 460, 520, 10, 20);
            dibujo.FillRectangle(brushgris, 450, 520, 10, 10);
            dibujo.FillRectangle(brushgrisOs, 430, 510, 10, 20);
            dibujo.FillRectangle(brushgrisO, 450, 530, 10, 10);
            dibujo.FillRectangle(brushgrisOs, 440, 530, 10, 10);
            dibujo.FillRectangle(brushgrisOs, 460, 540, 10, 10);
            dibujo.FillRectangle(brushblack, 450, 540, 10, 10);
            dibujo.FillRectangle(brushgrishumilde, 450, 550, 10, 20);
            dibujo.FillRectangle(brushgrishumilde, 440, 540, 10, 20);
            dibujo.FillRectangle(brushblack, 440, 560, 10, 10);
            dibujo.FillRectangle(brushgrishumilde, 440, 570, 10, 20);
            dibujo.FillRectangle(brushgrishumilde, 430, 550, 10, 30);
            dibujo.FillRectangle(brushblack, 430, 580, 10, 10);
            dibujo.FillRectangle(brushgrishumilde, 430, 590, 10, 20);
            dibujo.FillRectangle(brushgrishumilde, 420, 580, 10, 20);
            dibujo.FillRectangle(brushblack, 420, 600, 10, 10);
            dibujo.FillRectangle(brushgrishumilde, 420, 610, 10, 20);
            dibujo.FillRectangle(brushgrishumilde, 410, 600, 10, 20);
            dibujo.FillRectangle(brushblack, 410, 620, 10, 10);
            dibujo.FillRectangle(brushgrishumilde, 410, 630, 10, 20);
            dibujo.FillRectangle(brushgrishumilde, 400, 620, 10, 30);
            dibujo.FillRectangle(brushgrey, 400, 650, 10, 10);
            dibujo.FillRectangle(brushgrey3, 390, 640, 10, 10);
            dibujo.FillRectangle(brushgrey2, 390, 650, 10, 10);


            // detalles
            dibujo.FillRectangle(brush, 440, 540, 10, 20);
            dibujo.FillRectangle(brush, 430, 550, 10, 20);

           

        }

        private void Pixe_Load(object sender, EventArgs e)
        {
            dibujo = this.CreateGraphics();
        }

        private void Pixe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }
    }
}

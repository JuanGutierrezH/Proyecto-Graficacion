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
    public partial class Traslacion : Form
    {
        public Traslacion()
        {
            InitializeComponent();
        }

        Graphics dibujo;
        Pen pluma = new Pen(Color.Black, 3);
        Brush brush = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#7A3EB1"));

        private void Traslacion_Load(object sender, EventArgs e)
        {
            dibujo = this.CreateGraphics();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            dibujo.DrawEllipse(pluma, 300, 300, 100, 100);

        }

        
    }
}

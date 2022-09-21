﻿using System;
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
        Pen pluma = new Pen(Color.Black, 3);
        Brush brush = new SolidBrush(Color.Black);


        private void Reloj_Load(object sender, EventArgs e)
        {
            dibujo = this.CreateGraphics();
        }

        private void Reloj_Click(object sender, EventArgs e)
        {
            


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            dibujo.TranslateTransform(301, 301);
            dibujo.FillEllipse(brush, -200, -200, 400, 400);
        }
    }
}
using Proyecto_Graficacion.Unidad2;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void espadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pixe pixe = new Pixe();
            pixe.Show();
        }

        private void perroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Polygon polygon = new Polygon();
            polygon.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void trackBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrackBar trackBar = new TrackBar();
            trackBar.Show();
        }

        private void sierpinskyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sierpinsky sierpinsky = new Sierpinsky();
            sierpinsky.Show();
        }

        private void traslaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Traslacion traslacion = new Traslacion();
            traslacion.Show();
        }

        private void escaladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Escalamiento escalamiento = new Escalamiento();
            escalamiento.Show();
        }

        private void relojToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reloj reloj = new Reloj();
            reloj.Show();
        }
    }
}

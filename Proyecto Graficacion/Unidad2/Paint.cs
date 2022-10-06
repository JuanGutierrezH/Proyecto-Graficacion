using DevExpress.Data.Controls.ExpressionEditor;
using DevExpress.Utils.CommonDialogs;
using DevExpress.XtraBars;
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
    public partial class Paint : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Pen pluma = new Pen(ColorTranslator.FromHtml("#F0F0F0"), 0);
        Brush brush = new SolidBrush(Color.Black);
        Image ImagenLapiz;
        bool clicked = false;
        Point previousPoint;
        bool clickRectangulo;


        public Paint()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            pluma = new Pen(Color.Black, (float)tamano.Value);
        }
        
        private void PaletaColores2_EditValueChanged(object sender, EventArgs e)
        {
            pluma = new Pen((Color)(PaletaColores2.EditValue), 3);
            //color = (Color)(PaletaColores2.EditValue);
            //pluma.Color = color;
        }

        private void btnOpen_ItemClick(object sender, ItemClickEventArgs e)
        {
            openFileDialog1.ShowDialog();
            string ruta = openFileDialog1.FileName;
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string ruta = saveFileDialog1.FileName;

            ImagenLapiz.Save(ruta);
        }

        private void Paint_Load(object sender, EventArgs e)
        {

        }

        private void Paint_Paint(object sender, PaintEventArgs e)
        {
            if (ImagenLapiz != null)
                e.Graphics.DrawImage(ImagenLapiz, 0, 0);
        }

        private void Paint_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            previousPoint = e.Location;
        }

        private void Paint_MouseLeave(object sender, EventArgs e)
        {
            clicked = false;
        }

        private void Paint_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
        }

        private void Paint_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicked)
            {
                if (ImagenLapiz == null)
                    ImagenLapiz = new Bitmap(this.Width, this.Height);
                using (Graphics g = Graphics.FromImage(ImagenLapiz))
                {
                    g.DrawLine(pluma, previousPoint, e.Location);
                    previousPoint = e.Location;
                    this.Invalidate();
                }
            }
        }

        private void barEditItem1_EditValueChanged(object sender, EventArgs e)
        {
            pluma = new Pen( (Color)(PaletaColores3.EditValue), (float)tamano.Value);
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            pluma = new Pen(ColorTranslator.FromHtml("#F0F0F0"), 20);
        }

        private void tamano_ValueChanged(object sender, EventArgs e)
        {
            pluma = new Pen((Color)(PaletaColores3.EditValue), (float)tamano.Value);
        }

        private void Paint_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
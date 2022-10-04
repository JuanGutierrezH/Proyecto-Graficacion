using DevExpress.Data.Controls.ExpressionEditor;
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
        Color color = Color.Black;
        Pen pluma = new Pen(color, 3);
        Brush brush = new SolidBrush(color);


        public Paint()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Que rollo");
        }

        private void PaletaColores_EditValueChanged(object sender, EventArgs e)
        {
            color = (Color)(PaletaColores.EditValue);
        }

    }
}
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
            //Color b = ColorTranslator.FromHtml(PaletaColores.EditValue.ToString());
            //MessageBox.Show(ColorTranslator.FromHtml(PaletaColores.EditValue));
            //Color a = PaletaColores.EditValue.ToString();
        }

        private void PaletaColores2_EditValueChanged(object sender, EventArgs e)
        {
        }
    }
}
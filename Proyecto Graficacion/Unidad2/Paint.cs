using DevExpress.Data.Controls.ExpressionEditor;
using DevExpress.Utils.CommonDialogs;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Graficacion.Unidad2
{
    public partial class Paint : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Pen pluma = new Pen(ColorTranslator.FromHtml("#F0F0F0"), 0);
        Graphics dibujo;
        Brush brush = new SolidBrush(Color.Black);
        Image ImagenLapiz;
        bool clicked = false;
        bool clickCuadrado = false;
        bool plumaClick = false;
        Point previousPoint;
        bool cuadrado = false;
        Point cuadrado1;
        Point cuadrado2;
        bool circulo = false;
        Point circulo1;
        Point circulo2;
        bool clickCirculo = false;
        bool triangulo = false;
        Point triangulo1;
        Point triangulo2;
        Point triangulo3;
        bool clickTriangulo = false;
        bool paint = false;
        bool hexagono = false;
        Point hexagono1;
        Point hexagono2;
        Point hexagono3;
        Point hexagono4;
        Point hexagono5;
        Point hexagono6;
        bool clickHexagono = false;
        bool linea = false;
        bool clickLinea = false;
        Point linea1;
        Point linea2;

        public Paint()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            plumaClick = true;
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

            ImagenLapiz = new Bitmap(ruta);
            this.Invalidate();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            Rectangle targetBounds = this.ClientRectangle;
            var guardar = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(guardar, targetBounds);
            saveFileDialog1.ShowDialog();
            string ruta = saveFileDialog1.FileName;

            guardar.Save(ruta);
        }

        private void Paint_Load(object sender, EventArgs e)
        {
            dibujo = this.CreateGraphics();
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
                if (plumaClick)
                {
                    using (Graphics g = Graphics.FromImage(ImagenLapiz))
                    {
                        g.DrawLine(pluma, previousPoint, e.Location);
                        previousPoint = e.Location;
                        this.Invalidate();
                    }
                }
            }
        }

        private void barEditItem1_EditValueChanged(object sender, EventArgs e)
        {
            pluma.Color = (Color)(PaletaColores3.EditValue);
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            pluma.Color = ColorTranslator.FromHtml("#F0F0F0");
        }

        private void tamano_ValueChanged(object sender, EventArgs e)
        {
            pluma.Width = ((float)tamano.Value);
        }

        private void Paint_MouseClick(object sender, MouseEventArgs e)
        {
            if (cuadrado)
            {
                if (ImagenLapiz == null)
                    ImagenLapiz = new Bitmap(this.Width, this.Height);
                if (clickCuadrado == false)
                {
                    cuadrado1 = e.Location;
                    clickCuadrado = true;
                }
                else
                {
                    cuadrado2 = e.Location;
                    clickCuadrado = false;
                    int width = cuadrado2.X - cuadrado1.X;
                    int height = cuadrado2.Y - cuadrado1.Y;

                    using (Graphics g = Graphics.FromImage(ImagenLapiz))
                    {
                        g.DrawRectangle(pluma, cuadrado1.X, cuadrado1.Y, width, height);
                        this.Invalidate();
                    }
                    cuadrado = false;
                }
            }
            if (circulo)
            {
                if (clickCirculo == false)
                {
                    circulo1 = e.Location;
                    clickCirculo = true;
                }
                else
                {
                    circulo2 = e.Location;
                    clickCirculo = false;
                    int width = circulo2.X - circulo1.X;
                    int height = circulo2.Y - circulo1.Y;

                    using (Graphics g = Graphics.FromImage(ImagenLapiz))
                    {
                        g.DrawEllipse(pluma, circulo1.X, circulo1.Y, width, height);
                        this.Invalidate();
                    }
                    circulo = false;
                }
            }
            if (triangulo)
            {
                if (clickTriangulo == false)
                {
                    triangulo1 = e.Location;
                    clickTriangulo = true;
                }
                else
                {
                    triangulo2 = e.Location;
                    triangulo3 = new Point(triangulo2.X, triangulo1.Y);
                    clickTriangulo = false;
                    int width = triangulo2.X - triangulo1.X;
                    int height = triangulo2.Y - triangulo1.Y;
                    Point[] trianguloDibujo = { triangulo1, triangulo2, triangulo3 };

                    using (Graphics g = Graphics.FromImage(ImagenLapiz))
                    {
                        g.DrawPolygon(pluma, trianguloDibujo);  
                        this.Invalidate();
                    }
                    triangulo = false;
                }
            }
            if (paint)
            {
                using (Graphics g = Graphics.FromImage(ImagenLapiz))
                {
                    g.Clear((Color)(PaletaColores3.EditValue));
                    this.Invalidate();
                }
                paint = false;
            }
            if (hexagono)
            {
                if (clickHexagono == false)
                {
                    hexagono1 = e.Location;
                    clickHexagono = true;
                }
                else
                {
                    hexagono4 = e.Location;
                    hexagono2 = new Point(hexagono4.X, hexagono1.Y);
                    hexagono5 = new Point(hexagono1.X, hexagono4.Y);    
                    hexagono3 = new Point(hexagono2.X+50, hexagono2.Y+50);
                    hexagono6 = new Point(hexagono1.X-50, hexagono1.Y+50);

                    clickHexagono = false;
                    Point[] hexagonoDibujo = { hexagono1, hexagono2, hexagono3, hexagono4, hexagono5, hexagono6 };

                    using (Graphics g = Graphics.FromImage(ImagenLapiz))
                    {
                        g.DrawPolygon(pluma, hexagonoDibujo);
                        this.Invalidate();
                    }
                    hexagono = false;
                }
            }
            if (linea)
            {
                if (clickLinea == false)
                {
                    linea1 = e.Location;
                    clickLinea = true;
                }
                else
                {
                    linea2 = e.Location;

                    clickLinea = false;
                    Point[] lineaDibujo = { linea1, linea2 };

                    using (Graphics g = Graphics.FromImage(ImagenLapiz))
                    {
                        g.DrawPolygon(pluma, lineaDibujo);
                        this.Invalidate();
                    }
                    linea = false;
                }
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            cuadrado = true;
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            circulo = true;
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            triangulo = true;
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            paint = true;
        }

        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (Graphics g = Graphics.FromImage(ImagenLapiz))
            {
                g.Clear(Color.White);
                this.Invalidate();
            }
            //ImagenLapiz = new Bitmap(this.Width, this.Height);
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            hexagono = true;
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            linea = true;
        }
    }
}
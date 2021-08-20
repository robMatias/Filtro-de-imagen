using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiltroImagen
{
    public partial class Form1 : Form
    {
        private Bitmap original;
        private Bitmap resultante;
        private int[] histograma = new int[256];
        private int[,] conv3x3 = new int[3, 3];
        private int factor;
        private int offset;

        //Variables para double buffer y evitar el flicker

        private int anchoVentana, altoVentana;

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerramos la aplicacion
            this.Close();
        }

        private void abrirImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                original = (Bitmap)(Bitmap.FromFile(openFileDialog1.FileName));
                anchoVentana = original.Width;
                altoVentana = original.Height;

                resultante = original;

                this.Invalidate();
            }
        }

        private void guardarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                resultante.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Verificamos que se tenga un Bitmap instanciado
            if (resultante != null)
            {
                // Obtenemos el objeto graphics
                Graphics g = e.Graphics;

                // Calculamos el scroll
                AutoScrollMinSize = new Size(anchoVentana, altoVentana);

                // Copiamos el bitmap a la ventana
                g.DrawImage(resultante,
                            new Rectangle(this.AutoScrollPosition.X,
                                           this.AutoScrollPosition.Y + 30, 
                                           anchoVentana, altoVentana));

                // Liberamos el recurso
                g.Dispose(); 
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;

            resultante = new Bitmap(original.Width, original.Height);

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    resultante.SetPixel(x, y, Color.FromArgb(128, 0, 0));
                }
            }

            this.Invalidate();
        }

        private void negativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // invertir la imagen, saca su negativo

            int x = 0;
            int y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();


            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    // Obtenemos el color del pixel
                    oColor = original.GetPixel(x, y);

                    // Procesamos y obtenemos el nuevo color
                    rColor = Color.FromArgb(255 - oColor.R, 255 - oColor.G, 255 - oColor.B);

                    // Colocamos el color en resultante
                    resultante.SetPixel(x, y, rColor);
                }
            }

            this.Invalidate();
        }

        private void filtroDeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Filtro de color, solo presenta pixeles en un componente y elimina los otros dos
            int x = 0;
            int y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    // Obtenemos el color del pixel
                    oColor = original.GetPixel(x, y);

                    // Procesamos y obtenemos el nuevo color
                    rColor = Color.FromArgb(oColor.R, 0, 0);

                    // Colocamos el color resultante
                    resultante.SetPixel(x, y, rColor);
                }
            }

            this.Invalidate();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            int a = 5; // Tamaño de la aberración

            int r = 0;
            int g = 0;
            int b = 0;

            resultante = new Bitmap(original.Width, original.Height);

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    // Obtenemos el verde 
                    g = original.GetPixel(x, y).G;

                    // Obtenemos el rojo
                    if ((x + a) < original.Width)
                    {
                        r = original.GetPixel(x + a, y).R;
                    }
                    else
                    {
                        r = 0;
                    }

                    // Obtenemos el azul
                    if ((x - a) >= 0)
                    {
                        b = original.GetPixel(x - a, y).B;
                    }
                    else
                    {
                        b = 0;
                    }

                    // Colocamos el pixel 
                    resultante.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            this.Invalidate();
        }

        private void tonosDeGrisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Convertimos la imagen a tonos de gris

            int x = 0;
            int y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();

            float g = 0;

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    // Obtenemos el color del pixel
                    oColor = original.GetPixel(x, y);

                    // Procesamos y obtenemos el numero de color

                    g = oColor.R * .299f + oColor.G * 0.587f + oColor.B * 0.114f;

                    rColor = Color.FromArgb((int)g, (int)g, (int)g);

                    resultante.SetPixel(x, y, rColor);
                }
            }

            this.Invalidate();
        }

        private void colorizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;

            // Queremos colorizar con (120,200,120)
            double rc = 120 / 255.0;
            double gc = 200 / 255.0;
            double bc = 120 / 255.0;

            Color miColor = new Color();
            int r = 0;
            int g = 0;
            int b = 0;

            // Creamos la omagen en tonos de gris
            tonosDeGrisToolStripMenuItem_Click(sender, e);

            for(x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    miColor = resultante.GetPixel(x, y);

                    r = (int)(miColor.R * rc);
                    g = (int)(miColor.G * gc);
                    b = (int)(miColor.B * bc);

                    resultante.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            this.Invalidate();
        }

        private void colonizarGradianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float r1 = 120;
            float g1 = 230;
            float b1 = 120;

            float r2 = 230;
            float g2 = 100;
            float b2 = 230;

            int r = 0;
            int g = 0;
            int b = 0;

            float dr = (r2 - r1) / original.Width;
            float dg = (g2 - g1) / original.Width;
            float db = (b2 - b1) / original.Width;

            int x = 0;
            int y = 0;

            Color oColor;
            //Color rColor

            // Obtenemos los tonos de gris 
            tonosDeGrisToolStripMenuItem_Click(sender, e);

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    // Obtenemos el color 
                    oColor = resultante.GetPixel(x, y);

                    // Calculamos el color
                    r = (int)((r1 / 255.0f) * oColor.R);
                    g = (int)((g1 / 255.0f) * oColor.G);
                    b = (int)((b1 / 255.0f) * oColor.B);

                    if (r > 255)
                    {
                        r = 255;
                    }
                    else if (r < 0)
                    {
                        r = 0;
                    }
                    else if (g > 255)
                    {
                        g = 255;
                    }
                    else if (g < 0)
                    {
                        g = 0;
                    }
                    else if (b > 255)
                    {
                        b = 255;
                    }
                    else if (b < 0)
                    {
                        b = 0;
                    }

                    // Colocamos el color
                    resultante.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
                // Avanzamos el color
                r1 = (r1 + dr);
                g1 = (g1 + dg);
                b1 = (b1 + db);
            }

            this.Invalidate();

        }

        private void brilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Modificamos el brillo de la imagen

            int brillo = 64;  // El valor vca de -255 a 255
            float pBrillo = 1.2f; // El valor vca de 0 a 2

            int x = 0;
            int y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();


            int r = 0;
            int g = 0;
            int b = 0;


            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    // Obtenemos el color del pixel
                    oColor = original.GetPixel(x, y);

                    // Metodo 
                    r = (int)(oColor.R * pBrillo);
                    g = (int)(oColor.G * pBrillo);
                    b = (int)(oColor.B * pBrillo);

                    if (r > 255) r = 255;
                    else if (r < 0) r = 0;

                    if (g > 255) g = 255;
                    else if (g < 0) g = 0;

                    if (b > 255) b = 255;
                    else if (b < 0) b = 0;

                    rColor = Color.FromArgb(r, g, b);

                    // Colocamos el color en resultante
                    resultante.SetPixel(x, y, rColor);
                }
            }
            this.Invalidate();
        }

        public Form1()
        {
            InitializeComponent();

            // creamos el bitmapa resultante del cuadro
            resultante = new Bitmap(800, 600);

            // Colocamos los valores para el dibujo con scrolls
            anchoVentana = 800;
            altoVentana = 600;

        }
    }
}

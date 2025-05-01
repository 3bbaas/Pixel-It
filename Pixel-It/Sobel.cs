using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_It
{
    public partial class Sobel : Form
    {

        public Bitmap bitmap;
        Bitmap orignal;
        public int SobelValue { get; private set; }
        bool updating = false;
        public Sobel(Bitmap img)
        {
            InitializeComponent(); bitmap = new Bitmap(img);
            orignal = new Bitmap(img);

            filterSobelBox.Image = bitmap = ApplySobelFilter(orignal);
        }
        private void applyBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private int Clamp(int value)
        {
            return Math.Max(0, Math.Min(255, value));
        }
        int[,] gx = new int[,]
        {
    { -1, 0, 1 },
    { -2, 0, 2 },
    { -1, 0, 1 }
        };
        int[,] gy = new int[,]
        {
    {  1,  2,  1 },
    {  0,  0,  0 },
    { -1, -2, -1 }
        };

        private Bitmap ApplySobelFilter(Bitmap sourceImage)
        {
            int width = sourceImage.Width;
            int height = sourceImage.Height;
            Bitmap grayImage = new Bitmap(width, height);
            Bitmap edgeImage = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color px = sourceImage.GetPixel(x, y);
                    int l = (px.R + px.G + px.B) / 3;
                    grayImage.SetPixel(x, y, Color.FromArgb(px.A, l, l, l));
                }
            }

            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    int sumX = 0, sumY = 0;

                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            int pixel = grayImage.GetPixel(x + kx, y + ky).R;
                            sumX += gx[ky + 1, kx + 1] * pixel;
                            sumY += gy[ky + 1, kx + 1] * pixel;
                        }
                    }

                    int g = (int)Math.Sqrt(sumX * sumX + sumY * sumY);
                    g = Clamp(g);

                    edgeImage.SetPixel(x, y, Color.FromArgb(255, g, g, g));
                }
            }

            return edgeImage;
        }


    }
}

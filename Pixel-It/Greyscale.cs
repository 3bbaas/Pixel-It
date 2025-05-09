using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pixel_It
{
    public partial class Greyscale : Form
    {
        Bitmap bitmap;
        public Greyscale(Bitmap img)
        {
            InitializeComponent();
            this.Icon = new Icon("..\\..\\assets\\Pixel_it app icon.ico");

            bitmap = new Bitmap(img, greyBox.Size);
        }

        private void greyBtn_Click(object sender, EventArgs e)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bitmap.GetPixel(x, y);
                    //int avg = (p.R + p.G + p.B) / 3;
                    int avg = (int)(p.R * 0.299 + p.G * 0.587 + p.B * 0.114);
                    bitmap.SetPixel(x, y, Color.FromArgb(p.A, avg, avg, avg));
                }
            }
            greyBox.Image = new Bitmap(bitmap, greyBox.Size);
        }
    }
}

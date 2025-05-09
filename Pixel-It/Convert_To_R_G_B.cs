using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pixel_It
{
    public partial class Convert_To_R_G_B : Form
    {
        Bitmap curr_source_image;
        public Convert_To_R_G_B(Bitmap img)
        {
            InitializeComponent();
            this.Icon = new Icon("..\\..\\assets\\Pixel_it app icon.ico");

            curr_source_image = new Bitmap(img, picBoxBlue.Size);
        }
        private void btnRed_Click(object sender, EventArgs e)
        {
            picBoxRed.Image = IMG.GetColor(curr_source_image, Colors.Red);
        }
        private void btnGreen_Click(object sender, EventArgs e)
        {
            picBoxGreen.Image = IMG.GetColor(curr_source_image, Colors.Green);
        }
        private void btnBlue_Click(object sender, EventArgs e)
        {
            picBoxBlue.Image = IMG.GetColor(curr_source_image, Colors.Blue);
        }

    }
    public enum Colors
    {
        Red, Green, Blue
    };

    public static class IMG
    {
        public static Bitmap GetColor(Bitmap src, Colors c)
        {
            int w = src.Width, h = src.Height;

            Bitmap ret = new Bitmap(w, h);

            for (int i = 0; i < w; ++i)
            {
                for (int j = 0; j < h; ++j)
                {
                    Color pixel = src.GetPixel(i, j);

                    int r = 0, g = 0, b = 0;
                    if (c == Colors.Red)
                    {
                        r = pixel.R;
                    }
                    else if (c == Colors.Green)
                    {
                        g = pixel.G;
                    }
                    else if (c == Colors.Blue)
                    {
                        b = pixel.B;
                    }


                    ret.SetPixel(i, j, Color.FromArgb(r, g, b));

                }
            }
            return ret;
        }
    }

}

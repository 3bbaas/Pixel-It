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
    public partial class Negative : Form
    {
        public Bitmap bitmap;
        Bitmap orignal;
        public Negative(Bitmap img)
        {
            InitializeComponent();
            this.Icon = new Icon("..\\..\\assets\\Pixel_it app icon.ico");

            bitmap = new Bitmap(img);
            orignal = new Bitmap(img);

            bitmap = ApplyNegativeFilter(orignal);
            filterNegativeBox.Image = bitmap;

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private Bitmap ApplyNegativeFilter(Bitmap sourceImage)
        {
            int width = sourceImage.Width;
            int height = sourceImage.Height;
            Bitmap newImage = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color px = sourceImage.GetPixel(x, y);

                    int r = 255 - px.R;
                    int g = 255 - px.G;
                    int b = 255 - px.B;

                    Color inverted = Color.FromArgb(px.A, r, g, b);
                    newImage.SetPixel(x, y, inverted);
                }
            }

            return newImage;
        }

    }
}

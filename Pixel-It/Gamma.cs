using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Pixel_It
{
    public partial class Gamma : Form
    {
        public Bitmap bitmap;
        Bitmap orignal;
        public int GammaValue { get; private set; }
        bool updating = false;
        public Gamma(Bitmap img)
        {
            InitializeComponent();
            this.Icon = new Icon("..\\..\\assets\\Pixel_it app icon.ico");

            bitmap = new Bitmap(img);
            orignal = new Bitmap(img);

            filterGammaBox.Image = orignal;
            GammaTrackBar.Minimum = 10;   // 0.10
            GammaTrackBar.Maximum = 500;  // 5.00
            GammaTrackBar.Value = 100;  // 1.00
        }

        private void GammaTrackBar_Scroll(object sender, EventArgs e)
        {
            if (!updating)
            {
                //changeGammaBox.Text = (GammaTrackBar.Value).ToString(CultureInfo.InvariantCulture);
                double gamma = GammaTrackBar.Value / 100.0;
                changeGammaBox.Text = gamma.ToString("F2", CultureInfo.InvariantCulture);
                //filterGammaBox.Image = ApplyGammaFilter(original, gamma);
            }

        }

        private void changeGammaBox_TextChanged(object sender, EventArgs e)
        {
            if (this.changeGammaBox.Text.Contains(','))
            {
                MessageBox.Show(this, "Incorrect, Must be integer", "Pixel It", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            double value = double.Parse(changeGammaBox.Text, CultureInfo.InvariantCulture);

            updating = true;
            GammaTrackBar.Value = (int)(value * 100);
            updating = false;

            filterGammaBox.Image = bitmap = ApplyGammaFilter(orignal, value);

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

        private Bitmap ApplyGammaFilter(Bitmap sourceImage, double gamma)
        {
            int width = sourceImage.Width;
            int height = sourceImage.Height;
            Bitmap newImage = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color px = sourceImage.GetPixel(x, y);
                    double r = Math.Pow(px.R / 255.0, 1.0 / gamma) * 255.0;
                    double g = Math.Pow(px.G / 255.0, 1.0 / gamma) * 255.0;
                    double b = Math.Pow(px.B / 255.0, 1.0 / gamma) * 255.0;

                    Color newColor = Color.FromArgb(
                        px.A,
                        Clamp((int)r),
                        Clamp((int)g),
                        Clamp((int)b)
                    );
                    newImage.SetPixel(x, y, newColor);
                }
            }

            return newImage;
        }

    }
}

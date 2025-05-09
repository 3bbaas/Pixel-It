using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Pixel_It
{
    public partial class Contrast : Form
    {
        public Bitmap bitmap;
        Bitmap orignal;
        public int ContrastValue { get; private set; }
        bool updating = false;
        public Contrast(Bitmap img)
        {
            InitializeComponent();
            this.Icon = new Icon("..\\..\\assets\\Pixel_it app icon.ico");

            bitmap = new Bitmap(img);
            orignal = new Bitmap(img);

            filterContrastBox.Image = orignal;
            contrastTrackBar.Minimum = -255;
            contrastTrackBar.Maximum = 255;
            contrastTrackBar.Value = 0;

        }

        private void changeContrastBox_TextChanged(object sender, EventArgs e)
        {
            if (this.changeContrastBox.Text.Contains('.'))
            {
                MessageBox.Show(this, "Incorrect, Must be integer", "Pixel It", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int value = int.Parse(changeContrastBox.Text, CultureInfo.InvariantCulture);

            updating = true;
            contrastTrackBar.Value = (int)value;
            updating = false;

            filterContrastBox.Image = bitmap = ApplyContrastFilter(orignal, value);

        }

        private void contrastTrackBar_Scroll(object sender, EventArgs e)
        {
            if (!updating)
                changeContrastBox.Text = (contrastTrackBar.Value).ToString(CultureInfo.InvariantCulture);

        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            ContrastValue = contrastTrackBar.Value;
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
        private Bitmap ApplyContrastFilter(Bitmap sourceImage, int contrast)
        {
            Bitmap newImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            double factor = 259.0 * (contrast + 255.0) / (255.0 * (259.0 - contrast));

            for (int x = 0; x < sourceImage.Width; x++)
            {
                for (int y = 0; y < sourceImage.Height; y++)
                {
                    Color pixel = sourceImage.GetPixel(x, y);

                    int r = Clamp((int)(factor * (pixel.R - 128) + 128));
                    int g = Clamp((int)(factor * (pixel.G - 128) + 128));
                    int b = Clamp((int)(factor * (pixel.B - 128) + 128));

                    Color newColor = Color.FromArgb(pixel.A, r, g, b);
                    newImage.SetPixel(x, y, newColor);
                }
            }
            return newImage;

        }
    }
}

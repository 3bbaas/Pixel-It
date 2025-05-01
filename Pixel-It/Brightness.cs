using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Filters;

namespace Pixel_It
{
    public partial class Brightness : Form
    {
        public Bitmap bitmap;
        Bitmap orignal;  
        public int BrightnessValue { get; private set; }
        bool updating = false;
        public Brightness(Bitmap img)
        {
            InitializeComponent();
            bitmap = new Bitmap(img);
            orignal = new Bitmap(img);
            
            filterBrightnessBox.Image = orignal;
            brightnessTrackBar.Minimum = -255;
            brightnessTrackBar.Maximum = 255;
            brightnessTrackBar.Value = 0; 
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            BrightnessValue = brightnessTrackBar.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
            
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

 
        private void brightnessTrackBar_Scroll(object sender, EventArgs e)
        {
            if (!updating)
                changeBrightnessBox.Text = (brightnessTrackBar.Value).ToString(CultureInfo.InvariantCulture);
        }
        private int Clamp(int value)
        {
            return Math.Max(0, Math.Min(255, value));
        }
        private Bitmap ApplyBrightnessFilter(Bitmap sourceImage, int brightness)
        {
            Bitmap newImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            for (int x = 0; x < sourceImage.Width; x++)
            {
                for (int y = 0; y < sourceImage.Height; y++)
                {
                    Color pixel = sourceImage.GetPixel(x, y);

                    int r = Clamp(pixel.R + brightness);
                    int g = Clamp(pixel.G + brightness);
                    int b = Clamp(pixel.B + brightness);

                    Color newColor = Color.FromArgb(r, g, b);
                    newImage.SetPixel(x, y, newColor);
                }
            }

            return newImage;
        }


        private void changeBrightnessBox_TextChanged(object sender, EventArgs e)
        {
            if (this.changeBrightnessBox.Text.Contains('.'))
            {
                MessageBox.Show(this, "Incorrect, Must be integer", "Pixel It", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int value = int.Parse(changeBrightnessBox.Text, CultureInfo.InvariantCulture);

            updating = true;
            brightnessTrackBar.Value = (int)value;
            updating = false;

            filterBrightnessBox.Image = bitmap = ApplyBrightnessFilter(orignal, value);
        }
    }
}

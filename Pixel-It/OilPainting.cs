﻿using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Pixel_It
{
    public partial class OilPainting : Form
    {
        public Bitmap bitmap;
        Bitmap orignal;
        public int OilPaintingValue { get; private set; }
        bool updating = false;
        public OilPainting(Bitmap img)
        {
            InitializeComponent();
           
            this.Icon = new Icon("..\\..\\assets\\Pixel_it app icon.ico");

            bitmap = new Bitmap(img);
            orignal = new Bitmap(img);

            filterOilPaintingBox.Image = orignal;
            oilPaintTrackBar.Minimum = 1;
            oilPaintTrackBar.Maximum = 25;
            oilPaintTrackBar.Value = 2;
        }
        private Bitmap ApplyOilPaintingBrushSize(Bitmap source, int brushSize)
        {
            int width = source.Width;
            int height = source.Height;
            Bitmap result = new Bitmap(width, height);


            const int intensityLevels = 30;


            int[] count = new int[intensityLevels];
            int[] sumR = new int[intensityLevels];
            int[] sumG = new int[intensityLevels];
            int[] sumB = new int[intensityLevels];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {

                    Array.Clear(count, 0, intensityLevels);
                    Array.Clear(sumR, 0, intensityLevels);
                    Array.Clear(sumG, 0, intensityLevels);
                    Array.Clear(sumB, 0, intensityLevels);

                    for (int nx = Math.Max(0, x - brushSize); nx <= Math.Min(width - 1, x + brushSize); nx++)
                    {
                        for (int ny = Math.Max(0, y - brushSize); ny <= Math.Min(height - 1, y + brushSize); ny++)
                        {
                            Color p = source.GetPixel(nx, ny);
                            int intensity = (int)(((p.R + p.G + p.B) / 3.0) * intensityLevels / 255.0);
                            if (intensity >= intensityLevels) intensity = intensityLevels - 1;

                            count[intensity]++;
                            sumR[intensity] += p.R;
                            sumG[intensity] += p.G;
                            sumB[intensity] += p.B;
                        }
                    }


                    int maxCount = 0, bestIdx = 0;
                    for (int i = 0; i < intensityLevels; i++)
                    {
                        if (count[i] > maxCount)
                        {
                            maxCount = count[i];
                            bestIdx = i;
                        }
                    }


                    Color original = source.GetPixel(x, y);
                    int r = sumR[bestIdx] / maxCount;
                    int g = sumG[bestIdx] / maxCount;
                    int b = sumB[bestIdx] / maxCount;
                    result.SetPixel(x, y, Color.FromArgb(original.A, r, g, b));
                }
            }

            return result;
        }
        private void changeOilPaintBox_TextChanged(object sender, EventArgs e)
        {
            if (this.changeOilPaintBox.Text.Contains('.'))
            {
                MessageBox.Show(this, "Incorrect, Must be integer", "Pixel It", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int value = int.Parse(changeOilPaintBox.Text, CultureInfo.InvariantCulture);

            updating = true;
            oilPaintTrackBar.Value = (int)value;
            updating = false;

            filterOilPaintingBox.Image = bitmap = ApplyOilPaintingBrushSize(orignal, value);

        }

        private void oilPaintTrackBar_Scroll(object sender, EventArgs e)
        {
            if (!updating)
                changeOilPaintBox.Text = (oilPaintTrackBar.Value).ToString(CultureInfo.InvariantCulture);

        }

        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void applyBtn_Click_1(object sender, EventArgs e)
        {
            OilPaintingValue = oilPaintTrackBar.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

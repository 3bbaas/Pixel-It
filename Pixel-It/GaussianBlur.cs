﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pixel_It
{
    public partial class GaussianBlur : Form
    {

        public Bitmap bitmap;
        Bitmap orignal;
        public int GaussianBlurValue { get; private set; }
        bool updating = false;
        public GaussianBlur(Bitmap img)
        {
            InitializeComponent();
            this.Icon = new Icon("..\\..\\assets\\Pixel_it app icon.ico");
            bitmap = new Bitmap(img);
            orignal = new Bitmap(img);

            filterGaussianBlurBox.Image = bitmap = ApplyGaussianBlur(orignal);
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
        private Bitmap ApplyGaussianBlur(Bitmap sourceImage)
        {
            Bitmap newImage = new Bitmap(sourceImage.Width, sourceImage.Height);


            float[,] kernel = {
        { 1f/16f, 2f/16f, 1f/16f },
        { 2f/16f, 4f/16f, 2f/16f },
        { 1f/16f, 2f/16f, 1f/16f }
    };

            int width = sourceImage.Width;
            int height = sourceImage.Height;


            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    float r = 0, g = 0, b = 0;


                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            Color pixel = sourceImage.GetPixel(x + kx, y + ky);
                            float weight = kernel[ky + 1, kx + 1];
                            r += pixel.R * weight;
                            g += pixel.G * weight;
                            b += pixel.B * weight;
                        }
                    }


                    int a = sourceImage.GetPixel(x, y).A;
                    Color newColor = Color.FromArgb(a,
                        Clamp((int)r),
                        Clamp((int)g),
                        Clamp((int)b));
                    newImage.SetPixel(x, y, newColor);
                }
            }

            return newImage;
        }


    }
}

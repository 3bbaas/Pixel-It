using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Controls;

namespace Pixel_It
{
    public partial class Histogram : Form
    {
        Bitmap bitmap, equalized;
        public Histogram(Bitmap image)
        {
            InitializeComponent();
            bitmap = new Bitmap(image );
        }

        private void get_histogram_Click(object sender, EventArgs e)
        {
            Bitmap source = new Bitmap(bitmap);
            Bitmap image24bpp = new Bitmap(source.Width, source.Height, PixelFormat.Format24bppRgb);


            using (Graphics g = Graphics.FromImage(image24bpp))
            {
                g.DrawImage(source, 0, 0, source.Width, source.Height);
            }

            var histogramImage = GetHistogram.CreateHistogram(image24bpp, false);
            histogramBox.Image = new Bitmap(histogramImage, histogramBox.Size) ;

        }
        private void get_equzlized_Click(object sender, EventArgs e)
        {
            equalized = histogramEqualization(bitmap);
            if (equalized != null)
                equalizedFilterPreview.Image = equalized;
        }

        private void get_histogram_equalized_Click(object sender, EventArgs e)
        {
            Bitmap source = new Bitmap(equalized);
            Bitmap image24bpp = new Bitmap(source.Width, source.Height, PixelFormat.Format24bppRgb);


            using (Graphics g = Graphics.FromImage(image24bpp))
            {
                g.DrawImage(source, 0, 0, source.Width, source.Height);
            }

            var histogramImage = GetHistogram.CreateHistogram(image24bpp, false);
            if (histogramImage != null)
                EqualizedHistogramBox.Image = new Bitmap(histogramImage, EqualizedHistogramBox.Size);

            //EqualizedHistogramBox.Image = histogramImage;

        }
        public Bitmap histogramEqualization(Bitmap sourceImage)
        {
            if (sourceImage == null)
            {
                MessageBox.Show("No image loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            //Bitmap renderedImage = new Bitmap(sourceImage);

            //uint pixels = (uint)(renderedImage.Height * renderedImage.Width);
            //decimal scale = 255m / pixels;

            //int x, y, R, G, B;

            //ImageStatistics statistics = new ImageStatistics(renderedImage);

            ////Create histogram arrays for R,G,B channels
            //int[] cdfR = statistics.Red.Values.ToArray();
            //int[] cdfG = statistics.Green.Values.ToArray();
            //int[] cdfB = statistics.Blue.Values.ToArray();

            ////Convert arrays to Cumulative Distribution Frequency data
            //for (int r = 1; r <= 255; r++)
            //{
            //    cdfR[r] = cdfR[r] + cdfR[r - 1];
            //    cdfG[r] = cdfG[r] + cdfG[r - 1];
            //    cdfB[r] = cdfB[r] + cdfB[r - 1];
            //}

            //for (y = 0; y < renderedImage.Height; y++)
            //{
            //    for (x = 0; x < renderedImage.Width; x++)
            //    {
            //        Color originalColor = renderedImage.GetPixel(x, y);
            //        int r = Math.Min(255, (int)(cdfR[originalColor.R] * scale));
            //        int g = Math.Min(255, (int)(cdfG[originalColor.G] * scale));
            //        int b = Math.Min(255, (int)(cdfB[originalColor.B] * scale));
            //        renderedImage.SetPixel(x, y, Color.FromArgb(r, g, b));
            //    }
            //}
            //return renderedImage;

            Bitmap result = new Bitmap(sourceImage.Width, sourceImage.Height, PixelFormat.Format24bppRgb);

            Rectangle rect = new Rectangle(0, 0, sourceImage.Width, sourceImage.Height);
            BitmapData dataOriginal = sourceImage.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData dataResult = result.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);


            /*
                Stride : We calc the stride to get the size of each row in the image.
                    Why ??!!!
                    Windows arrange bytes of data in memory with size multiple of 4 ... \
                    Check ref: https://stackoverflow.com/questions/12861582/why-is-padding-added-for-multiple-data-members-of-structures-and-not-for-single
             */
            int stride = dataOriginal.Stride;
            int height = sourceImage.Height;
            int width = sourceImage.Width;

            int bytes = stride * height;
            byte[] buffer = new byte[bytes];
            // Scan0: address of first pixel
            System.Runtime.InteropServices.Marshal.Copy(dataOriginal.Scan0, buffer, 0, bytes);

            sourceImage.UnlockBits(dataOriginal);

            int[] histR = new int[256];
            int[] histG = new int[256];
            int[] histB = new int[256];

            for (int i = 0; i < buffer.Length; i += 3)
            {
                histB[buffer[i]]++;
                histG[buffer[i + 1]]++;
                histR[buffer[i + 2]]++;
            }

            // Cumulative histogram (CDF)
            int totalPixels = width * height;
            float scale = 255f / totalPixels;

            int[] cdfR = histR.ToArray();
            int[] cdfG = histG.ToArray();
            int[] cdfB = histB.ToArray();

            for (int i = 1; i < 256; i++)
            {
                cdfR[i] += cdfR[i - 1];
                cdfG[i] += cdfG[i - 1];
                cdfB[i] += cdfB[i - 1];
            }

            for (int i = 0; i < buffer.Length; i += 3)
            {
                buffer[i] = (byte)Math.Min(255, (int)(cdfB[buffer[i]] * scale));
                buffer[i + 1] = (byte)Math.Min(255, (int)(cdfG[buffer[i + 1]] * scale));
                buffer[i + 2] = (byte)Math.Min(255, (int)(cdfR[buffer[i + 2]] * scale));
            }

            System.Runtime.InteropServices.Marshal.Copy(buffer, 0, dataResult.Scan0, bytes);
            result.UnlockBits(dataResult);

            return result;

        }

    }
}

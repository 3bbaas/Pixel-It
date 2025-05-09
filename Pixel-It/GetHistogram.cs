using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Pixel_It
{
    public class GetHistogram
    {
        public static int indexOf(int hang, int cot, int stride)
        {
            return hang * stride + cot * 3;
        }

        unsafe
        public static Bitmap CreateHistogram(Bitmap source, bool isGray)
        {
            if (source.PixelFormat == PixelFormat.Format24bppRgb)
            {
                Bitmap histogram = new Bitmap(256, 256, PixelFormat.Format24bppRgb);
                BitmapData data = source.LockBits(new Rectangle(0, 0, source.Width, source.Height),
                    ImageLockMode.ReadWrite, source.PixelFormat);

                byte* p = (byte*)data.Scan0;
                int offset = data.Stride - source.Width * 3;

                if (isGray == false)
                {
                    for (int hang = 0; hang < source.Height; hang++)
                    {
                        for (int cot = 0; cot < source.Width; cot++)
                        {
                            //0.21 R + 0.72 G + 0.07 B
                            byte t = (byte)(0.07f * p[0] + 0.72f * p[1] + 0.21 * p[2]);
                            p[0] = p[1] = p[2] = t;
                            p += 3;
                        }
                        p += offset;
                    }
                    p = (byte*)data.Scan0;
                }
                int[] count = new int[256];
                int max = 0;
                for (int hang = 0; hang < source.Height; hang++)
                {
                    for (int cot = 0; cot < source.Width; cot++)
                    {
                        count[p[0]]++;
                        if (count[p[0]] > max)
                            max = count[p[0]];
                        p += 3;
                    }
                    p += offset;
                }
                source.UnlockBits(data);
                // max 255
                // x => x*255/max
                for (int i = 0; i < 256; i++)
                    count[i] = (int)(count[i] * (histogram.Height - 1) * 1f / max * 1f);
                data = histogram.LockBits(new Rectangle(0, 0, histogram.Width, histogram.Height),
                    ImageLockMode.ReadWrite, histogram.PixelFormat);
                p = (byte*)data.Scan0;
                offset = data.Stride - histogram.Width * 3;

                for (int cot = 0; cot < histogram.Width; cot++)
                {
                    for (int hang = 0; hang < histogram.Height; hang++)
                    {
                        byte value = 255;
                        if (hang <= (histogram.Height - count[cot])) value = 255;
                        else value = 0;
                        p[indexOf(hang, cot, data.Stride)] = value;
                        p[indexOf(hang, cot, data.Stride) + 1] = value;
                        p[indexOf(hang, cot, data.Stride) + 2] = value;
                    }
                }
                histogram.UnlockBits(data);
                return histogram;
            }
            else
            {
                MessageBox.Show("PixelFormat: " + source.PixelFormat);
                return source;
            }

        }
    }
}
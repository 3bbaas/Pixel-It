using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using openCV;

namespace Pixel_It
{
    public partial class Compress : Form
    {
        public long Quality;
        public Bitmap bitmap, orignal;
        public Compress(Bitmap img)
        {
            InitializeComponent();

            this.Icon = new Icon("..\\..\\assets\\Pixel_it app icon.ico");

            // store original & preview it
            orignal = new Bitmap(img);
            bitmap = new Bitmap(img);
            filterCompressBox.Image = bitmap;

            // configure slider
            qualityTrackBar1.Minimum = 10;
            qualityTrackBar1.Maximum = 100;
            qualityTrackBar1.Value = 90;
            qualityTrackBar1.Scroll += qualityTrackBar1_Scroll;
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            Quality = qualityTrackBar1.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void qualityTrackBar1_Scroll(object sender, EventArgs e)
        {
            int q = qualityTrackBar1.Value;
            //changeQualityTextBox.Text = q.ToString();

            // compress on-the-fly
            bitmap?.Dispose();
            bitmap = CompressJpeg(orignal, q);
            filterCompressBox.Image = bitmap;
        }
        private Bitmap CompressJpeg(Bitmap source, long quality)
        {
            var codec = ImageCodecInfo.GetImageEncoders()
                .FirstOrDefault(c => c.FormatID == ImageFormat.Jpeg.Guid);
            if (codec == null)
                throw new InvalidOperationException("JPEG codec not found");

            var eps = new EncoderParameters(1);
            eps.Param[0] = new EncoderParameter(Encoder.Quality, quality);

            using (var ms = new MemoryStream())
            {
                source.Save(ms, codec, eps);
                ms.Position = 0;
                return new Bitmap(ms);
            }
        }

    }
}

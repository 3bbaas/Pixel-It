using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Controls;
using AForge.Imaging.Filters;
using openCV;
namespace Pixel_It
{
    public partial class Form1 : Form
    {
        Bitmap bitmap, bit;
        IplImage image1;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenToolBar_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif|All Files|*.*";
                if (dlg.ShowDialog() != DialogResult.OK) return;
                try
                {
                    var loadedImage = new Bitmap(dlg.FileName);
                    bitmap = new Bitmap(loadedImage);
                    filterPreview1.Image = bitmap;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load image: " + ex.Message);
                }
            }
        }
        public void CompressBitmapToJpegFile(Bitmap sourceBitmap, long quality)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Title = "Save Image As...";
                sfd.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp|GIF Image|*.gif";
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                string filePath = sfd.FileName;
                if (quality < 0L || quality > 100L)
                    throw new ArgumentOutOfRangeException(nameof(quality), "Quality must be between 0 and 100.");

                ImageCodecInfo jpgEncoder = ImageCodecInfo.GetImageEncoders()
                    .FirstOrDefault(codec => codec.FormatID == ImageFormat.Jpeg.Guid);
                if (jpgEncoder == null)
                    throw new InvalidOperationException("JPEG encoder not found.");

                var encoderParams = new EncoderParameters(1);
                encoderParams.Param[0] = new EncoderParameter(
                    System.Drawing.Imaging.Encoder.Quality,
                    quality
                );

                using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    sourceBitmap.Save(fs, jpgEncoder, encoderParams);
                }
            }
        }
        public Bitmap ResizeBitmap(Bitmap src, int newWidth, int newHeight)
        {
            var dest = new Bitmap(newWidth, newHeight);
            using (var g = Graphics.FromImage(dest))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(src, 0, 0, newWidth, newHeight);
            }
            return dest;
        }

        private void compressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompressBitmapToJpegFile(ResizeBitmap(bitmap, bitmap.Width/2, bitmap.Height/2), 25);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif|All Files|*.*";
                if (dlg.ShowDialog() != DialogResult.OK) return;
                try
                {
                    var loadedImage = new Bitmap(dlg.FileName);
                    bitmap = new Bitmap(loadedImage);
                    //image1 = cvlib.CvLoadImage(dlg.FileName, cvlib.CV_LOAD_IMAGE_COLOR);
                    //CvSize size = new CvSize(filterPreview1.Width, filterPreview1.Height);
                    //IplImage resized_image = cvlib.CvCreateImage(size, image1.depth, image1.nChannels);
                    //cvlib.CvResize(ref image1, ref resized_image, cvlib.CV_INTER_LINEAR);
                    //filterPreview1.Image = IplImageToBitmap(resized_image);
                    filterPreview1.Image = bitmap;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load image: " + ex.Message);
                }
            }
        }

        public static Bitmap ResizeImage(Bitmap imgToResize, Size size)
        {
            return new Bitmap(imgToResize, size);
        }

        private void calcHistogram_Click(object sender, EventArgs e)
        {
            Histogram histogram = new Histogram(bitmap);
            histogram.Show();
        }

        private void channelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Convert_To_R_G_B channels = new Convert_To_R_G_B(bitmap);
            channels.Show();
        }

        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Greyscale grey = new Greyscale(bitmap);
            grey.Show();
        }

        private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Brightness brightnessForm = new Brightness(bitmap))
            {
                if (brightnessForm.ShowDialog() == DialogResult.OK)
                {
                    filterPreview1.Image = bitmap = brightnessForm.bitmap; 
                }
            }
        }

        private void contrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Contrast contrastForm = new Contrast(bitmap))
            {
                if (contrastForm.ShowDialog() == DialogResult.OK)
                {
                    filterPreview1.Image = bitmap = contrastForm.bitmap; 
                }
            }

        }

        private void negativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Negative negativeForm = new Negative(bitmap))
            {
                if (negativeForm.ShowDialog() == DialogResult.OK)
                {
                    filterPreview1.Image = bitmap = negativeForm.bitmap;
                }
            }

        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Blur blurForm = new Blur(bitmap))
            {
                if (blurForm.ShowDialog() == DialogResult.OK)
                {
                    filterPreview1.Image = bitmap = blurForm.bitmap;
                }
            }

        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (GaussianBlur gaussianBlurForm = new GaussianBlur(bitmap))
            {
                if (gaussianBlurForm.ShowDialog() == DialogResult.OK)
                {
                    filterPreview1.Image = bitmap = gaussianBlurForm.bitmap;
                }
            }

        }

        private void sobelEdgeDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Sobel sobelForm = new Sobel(bitmap))
            {
                if (sobelForm.ShowDialog() == DialogResult.OK)
                {
                    filterPreview1.Image = bitmap = sobelForm.bitmap;
                }
            }
        }
        private ImageFormat FormatFromExtension(string filePath)
        {
            switch (Path.GetExtension(filePath).ToLowerInvariant())
            {
                case ".bmp": return ImageFormat.Bmp;
                case ".gif": return ImageFormat.Gif;
                case ".jpg":
                case ".jpeg": return ImageFormat.Jpeg;
                case ".png": return ImageFormat.Png;
                case ".tif":
                case ".tiff": return ImageFormat.Tiff;
                default: return null;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Title = "Save Image As...";
                sfd.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp|GIF Image|*.gif";
                if (sfd.ShowDialog() != DialogResult.OK)
                    return; 

                string filePath = sfd.FileName;

                if (File.Exists(filePath) &&
                    (File.GetAttributes(filePath) & FileAttributes.ReadOnly) != 0)
                {
                    throw new Exception("File exists and is read-only!"); 
                }

                ImageFormat format = FormatFromExtension(filePath);
                if (format == null)
                    throw new Exception("Unsupported image format."); 

                if (format.Equals(ImageFormat.Jpeg))
                {
                    var jpegEncoder = ImageCodecInfo.GetImageEncoders()
                        .FirstOrDefault(c => c.MimeType == "image/jpeg");
                    var ep = new EncoderParameters(1);
                    ep.Param[0] = new EncoderParameter(
                        System.Drawing.Imaging.Encoder.Quality,
                        85L 
                    );
                    bitmap.Save(filePath, jpegEncoder, ep);
                }
                else
                {
                    bitmap.Save(filePath, format); 
                }
            }


        }

        private void rgbStripButton2_Click(object sender, EventArgs e)
        {
            Convert_To_R_G_B channels = new Convert_To_R_G_B(bitmap);
            channels.Show();
        }

        private void histogramStripButton3_Click(object sender, EventArgs e)
        {
            Histogram histogram = new Histogram(bitmap);
            histogram.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Title = "Save Image As...";
                sfd.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp|GIF Image|*.gif";
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                string filePath = sfd.FileName;
                string dir = Path.GetDirectoryName(filePath);

                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                if (File.Exists(filePath) &&
                    (File.GetAttributes(filePath) & FileAttributes.ReadOnly) != 0)
                    throw new IOException("File exists and is read-only!");

                Bitmap clone;
                lock (bitmap)
                {
                    clone = new Bitmap(bitmap);
                }

                ImageFormat format = FormatFromExtension(filePath);
                if (format == null)
                    throw new NotSupportedException("Unsupported image format.");

                if (format.Equals(ImageFormat.Jpeg))
                {
                    var jpgEncoder = ImageCodecInfo.GetImageEncoders()
                        .First(c => c.MimeType == "image/jpeg");
                    var ep = new EncoderParameters(1);
                    ep.Param[0] = new EncoderParameter(
                        System.Drawing.Imaging.Encoder.Quality, 85L);

                    clone.Save(filePath, jpgEncoder, ep);
                }
                else
                {
                    clone.Save(filePath, format);
                }

                clone.Dispose();
            }
        }

        private void oilPaintingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OilPainting oilForm = new OilPainting(bitmap))
            {
                if (oilForm.ShowDialog() == DialogResult.OK)
                {
                    filterPreview1.Image = bitmap = oilForm.bitmap;
                }
            }
        }

        private void resizeToolStripButton4_Click(object sender, EventArgs e)
        {
            int frameW = filterPreview1.Width;
            int frameH = filterPreview1.Height;
            int imgW = bitmap.Width;
            int imgH = bitmap.Height;

            double ratioSrc = (double)imgW / imgH;
            double ratioBox = (double)frameW / frameH;

            int newW, newH;
            if (ratioSrc > ratioBox)
            {
                newW = frameW;
                newH = (int)(frameW / ratioSrc);
            }
            else
            {
                newH = frameH;
                newW = (int)(frameH * ratioSrc);
            }

            Bitmap resized = new Bitmap(bitmap, new Size(newW, newH));
            filterPreview1.Image = resized;

        }


        private float _zoomFactor = 1.0f; // current zoom level (1.0 = 100%)
        private const float ZoomStep = 0.1f; // 10% per click  
        private const float MinZoom = 0.1f; // 10%  
        private const float MaxZoom = 5.0f; // 500%  
        Bitmap _originalImage = null;
        private void UpdatePictureBox()
        {
            _originalImage = bitmap;
            if (_originalImage == null) return;

            int newW = (int)(_originalImage.Width * _zoomFactor);
            int newH = (int)(_originalImage.Height * _zoomFactor);
            Size N_Size = new Size(newW, newH);

            Bitmap resized = new Bitmap(_originalImage, N_Size);
            filterPreview1.Image = resized;
        }
        private void zoominToolStripButton4_Click(object sender, EventArgs e)
        {
            _zoomFactor = Math.Min(_zoomFactor + ZoomStep, MaxZoom);
            UpdatePictureBox();

        }
        private void zoomoutToolStripButton4_Click(object sender, EventArgs e)
        {
            _zoomFactor = Math.Max(_zoomFactor - ZoomStep, MinZoom);
            UpdatePictureBox();

        }

        private void gammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Gamma gammaForm = new Gamma(bitmap))
            {
                if (gammaForm.ShowDialog() == DialogResult.OK)
                {
                    filterPreview1.Image = bitmap = gammaForm.bitmap;
                }
            }
        }

        
    }

}

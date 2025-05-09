using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetadataExtractor;

namespace Pixel_It
{
    public partial class MetaData : Form
    {
        public Bitmap bitmap;
        private readonly string img_path; 
        private readonly ImageFormat originalFormat;

        public MetaData(string imageFilePath, Bitmap img)
        {
            InitializeComponent();
            originalFormat = img.RawFormat;
            this.Icon = new Icon("..\\..\\assets\\Pixel_it app icon.ico");

            bitmap = new Bitmap(img);
            clear_metadata.Dock = DockStyle.Top;

            InitGrid();

            img_path = imageFilePath;

            LoadMetadata();
        }

        private void InitGrid()
        {
            listViewMetadata.Dock = DockStyle.Fill;
            listViewMetadata.View = View.Details;
            listViewMetadata.FullRowSelect = false;
            listViewMetadata.GridLines = true;
            listViewMetadata.Columns.Clear();
            listViewMetadata.Columns.Add("Tag", 200);
            listViewMetadata.Columns.Add("Value", 400);
        }

        private void LoadMetadata()
        {
            listViewMetadata.Items.Clear();
            try
            {
                var directories = ImageMetadataReader.ReadMetadata(img_path);

                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        var item = new ListViewItem(new[] { tag.Name, tag.Description });
                        listViewMetadata.Items.Add(item);
                    }
                }

                if (listViewMetadata.Items.Count == 0)
                    listViewMetadata.Items.Add(new ListViewItem(new[] { "(none)", "" }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading metadata: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear_metadata_Click(object sender, EventArgs e)
        {
            try
            {
                var propertyIds = bitmap.PropertyIdList.ToArray();
                foreach (int id in propertyIds)
                {
                    try
                    {
                        bitmap.RemovePropertyItem(id);
                    }
                    catch (ArgumentException)
                    { }
                }

                ImageFormat format = originalFormat;

                bitmap.Save(img_path, format);

                LoadMetadata();

                MessageBox.Show("Metadata cleared successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing metadata: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
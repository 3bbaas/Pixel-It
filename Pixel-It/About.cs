using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_It
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.Icon = new Icon("..\\..\\assets\\Pixel_it app icon.ico");
            description.Size = new Size(11, 25);
            description.Text = "Version 1.0\n\nFull Copyright \u00A9 " + DateTime.Now.Year;

            Bitmap icon = new Bitmap(ICON.Image, ICON.Size);
            ICON.Image = icon;
            Size mysize = pictureBox1.Size;
            Image linkedimg = Image.FromFile("..\\..\\assets\\linkedin.png");
            Bitmap linkedin = new Bitmap(linkedimg, mysize);
            pictureBox1.Image = linkedin;
            pictureBox2.Image = linkedin;
            pictureBox3.Image = linkedin;
            pictureBox4.Image = linkedin;
            pictureBox5.Image = linkedin;
        }

        private void githubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.githubLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/3bbaas/Pixel-It");

        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/3bbaas/");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/hasnaa-nageh-a884a6265");

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://linkedin.com/in/rokiya-abdelsatar");

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/-ahmed-ibrahim-abd-elghany/");

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/seif-al-din-sayed-299baa264/");

        }
    }
}

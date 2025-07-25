using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBSPC
{
    public partial class mapaOffline : Form
    {
        

        PictureBox org;


        public mapaOffline()
        {
            InitializeComponent();
        }

        Image imagenZoom(Image img, Size size)
        {
            Bitmap bmp = new Bitmap(img, Convert.ToInt32(img.Width * size.Width),
                Convert.ToInt32(img.Height * size.Height));
            Graphics gpu = Graphics.FromImage(bmp);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        }

        private void tbZoom_Scroll(object sender, EventArgs e)
        {
            
                if (tbZoom.Value != 0)
                {
                    pictureBox1.Image = null;
                    pictureBox1.Image = imagenZoom(org.Image, new Size(tbZoom.Value, tbZoom.Value));

                }
            
        }

        private void mapaOffline_Load(object sender, EventArgs e)
        {
            tbZoom.Minimum = 1;
            tbZoom.Maximum = 6;
            tbZoom.SmallChange = 1;
            tbZoom.LargeChange = 1;
            tbZoom.UseWaitCursor = false;


            this.DoubleBuffered = true;
            org = new PictureBox();
            org.Image = pictureBox1.Image;
            Refresh();
        }
    }
}


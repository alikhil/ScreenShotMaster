using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenShot_Master
{
    public partial class FImage : Form
    {
        public FImage(Image img)
        {
            InitializeComponent();
            pictureBox.Image = img;
            Size ims = img.Size;
            Point p = Location;
            if (ims.Width == Screen.PrimaryScreen.Bounds.Size.Width)
                p.X = -1;
            if (ims.Height == Screen.PrimaryScreen.Bounds.Size.Height)
                p.Y = -1;

            ims.Width += 2;
            ims.Height += 2;
            Size = ims;
            Location = p;
            
        }

        private void FImage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

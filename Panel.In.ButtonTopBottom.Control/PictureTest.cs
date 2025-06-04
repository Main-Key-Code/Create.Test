using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel.In.ButtonTopBottom.Control
{
    public partial class PictureTest : Form
    {
        public PictureTest()
        {
            InitializeComponent();
        }

        private void PictureTest_Load(object sender, EventArgs e)
        {
            string imagePath = System.IO.Path.Combine(Application.StartupPath, "Images", "compass.png");

            if (System.IO.File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.Location = new Point(10, 10); // Set the location of the PictureBox
                //pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Size = new Size(100, 100); // Set the size of the PictureBox



            }
            else
            {
                MessageBox.Show("Image file not found: " + imagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //pictureBox1.Image = System.IO.Path.Combine(Application.StartupPath, "Images", "compass.png");

        }
    }
}

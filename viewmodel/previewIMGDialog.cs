using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bank_System.viewmodel
{
    public partial class previewIMGDialog : Form
    {

        public previewIMGDialog(String filepath, Bitmap img)
        {
            InitializeComponent();
            var si = img.Size;
            si.Height += 70;
            this.Size = si;
            filePath.Text = filepath;
            pictureBox1.Size = img.Size;
            pictureBox1.Image = img;
            this.Text = filepath;

        }
        public previewIMGDialog(Image image)
        {
            InitializeComponent();
            var si = image.Size;
            si.Height += 70;
            this.Size = si;
            filePath.Text = image.Width.ToString();
            pictureBox1.Size = image.Size;
            pictureBox1.Image = image;


        }

        private void previewIMGDialog_Load(object sender, EventArgs e)
        {

        }
    }
}

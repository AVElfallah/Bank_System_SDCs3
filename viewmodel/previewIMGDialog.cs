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

        private void previewIMGDialog_Load(object sender, EventArgs e)
        {

        }
    }
}

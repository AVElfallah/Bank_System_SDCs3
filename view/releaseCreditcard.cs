using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bank_System.view
{
    public partial class releaseCreditcard : Form
    {
        public releaseCreditcard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            this.Size = new Size(570, 504);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewmodel.createCard create = new viewmodel.createCard();
            create.ShowDialog();
            cardPreview.Visible = true;
            notHaveVisa.Visible = false;
            cardNumber.Text = model.RandomNumbers.randomCardNumber();
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bank_System.view
{
    public partial class cashWithdrawal : Form
    {
        public cashWithdrawal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(570, 419);
        }
    }
}

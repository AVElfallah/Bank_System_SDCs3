using System;
using System.Drawing;

namespace Bank_System.view
{
    public partial class financialDeposit : model.FormWithPlugins
    {
        public financialDeposit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(570, 419);
        }
    }
}

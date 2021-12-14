using System;
using System.Windows.Forms;

namespace Bank_System.view
{
    public partial class mainScreen : Form
    {
        public Timer showTimer;
        public mainScreen()
        {
            InitializeComponent();

            showTimer = new Timer();
            showTimer.Interval = 200;
            showTimer.Tick += ShowTimer_Tick;
            showTimer.Start();



        }


        private void ShowTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                progressBar1.Visible = false;
                progressText.Visible = false;
                pan.Visible = true;
                showTimer.Stop();
                showTimer.Dispose();
            }
            else
            {
                progressBar1.Value += 20;
                progressText.Text = progressBar1.Value.ToString() + "%";
            }
        }

        private void xuiFormDesign1_WorkingArea_Paint(object sender, PaintEventArgs e)
        {

        }




        private void singOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            newCompanyAccount newCompany = new newCompanyAccount();

            newCompany.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            newPersonalAccount newPersonal = new newPersonalAccount();
            newPersonal.ShowDialog();
        }

        private void mainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            financialDeposit financial = new financialDeposit();
            financial.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cashWithdrawal cashWithdrawal = new cashWithdrawal();
            cashWithdrawal.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            releaseCreditcard creditcard = new releaseCreditcard();
            creditcard.ShowDialog();
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            newCompanyLoan companyLoan = new newCompanyLoan();
            companyLoan.ShowDialog();
        }
    }
}

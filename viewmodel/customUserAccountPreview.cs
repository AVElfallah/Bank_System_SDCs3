using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bank_System.viewmodel
{
    public partial class customUserAccountPreview : Form
    {
        public static model.personalAccount personal;
        public customUserAccountPreview(model.personalAccount account)
        {
            InitializeComponent();
            personal = account;
            if (account.isHaveVisa)
            {
                while (personal.accountVisa == null)
                {
                    createCard createCard = new createCard();
                    createCard.ShowDialog();
                }


            }

            accountNumber.Text = account.accountNumber;
            this.accountName.Text = account.name;
            this.nation.Text = account.national;
            this.nationalId.Text = account.nationalId;
            this.nationalIdPhoto.Image = new Bitmap(account.nationalIdPhotoPath);
            this.job.Text = account.job;
            this.tradeReportPhoto.Image = new Bitmap(account.tradeReportPhotoPath);
           
            this.crruncy.Text = account.crruncy;
            this.accountReport.Text = account.accountReport;
            this.notes.Text = account.notes;
            this.cashAccount.Text = account.cash.ToString();
            if (account.isHaveCheque)
            {
                this.isHaveChque.Text = "نعم";
                this.isHaveChque.BackColor = Color.SpringGreen;
                this.isHaveChque.ForeColor = Color.Maroon;
            }
            else
            {
                this.isHaveChque.Text = "لا";
                this.isHaveChque.BackColor = Color.Maroon;
                this.isHaveChque.ForeColor = Color.SpringGreen;
            }
            if (account.isHaveVisa)
            {
                this.isHaveVisa.Text = "نعم";
                this.isHaveVisa.BackColor = Color.SpringGreen;
                this.isHaveVisa.ForeColor = Color.Maroon;
            }
            else
            {
                this.isHaveVisa.Text = "لا";
                this.isHaveVisa.BackColor = Color.Maroon;
                this.isHaveVisa.ForeColor = Color.SpringGreen;
            }
        }

        private void accountNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void printReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تمت طباعة التقرير بنجاح");
        }
    }
}

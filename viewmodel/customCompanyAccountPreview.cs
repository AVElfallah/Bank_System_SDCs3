using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bank_System.viewmodel
{
    public partial class customCompanyAccountPreview : Form
    {
        model.companyAccount account;
        public customCompanyAccountPreview(model.companyAccount accountPreview)
        {
            InitializeComponent();
            account = accountPreview;
            accountNumber.Text = accountPreview.accountNumber;
            accountName.Text = accountPreview.name;
            accountReport.Text = accountPreview.accountReport;
            crruncy.Text = accountPreview.crruncy;
            cashAccount.Text = accountPreview.cash.ToString();
            notes.Text = accountPreview.notes;
            try
            {
                tradeReportPhoto.Image = new Bitmap(accountPreview.tradeReportPhotoPath);
                financialIdPhoto.Image = new Bitmap(accountPreview.financialIdPhotoPath);
            }
            catch (Exception)
            {
            }
            if (accountPreview.isHaveCheque)
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

        }

        private void printReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تم طباعة التقرير");
        }
    }
}

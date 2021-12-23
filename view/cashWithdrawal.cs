using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bank_System.view
{
    public partial class cashWithdrawal : Form
    {
        model.personalAccount account;
        model.companyAccount companyAccount;
        public cashWithdrawal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (personalacc.Checked && accountNumber.Text != "")
            {

                account = db.personalAccountDB.getAccountDataByID(accountNumber.Text);
                if (account != null)
                {
                    name.Text = account.name;
                    crruncy.Text = account.crruncy;
                    cash.Text = account.cash.ToString();
                    arabic_cash.Text = new model.ToWord(account.cash, account.crruncy).ConvertToArabic();
                    this.Size = new Size(570, 419);
                }
                else { System.Windows.Forms.MessageBox.Show("هذا الرقم لاينتمي لأي حساب موجود"); }

            }
            else if (companyacc.Checked && accountNumber.Text != "")

            {
                companyAccount = db.companyAccountDB.getAccountById(accountNumber.Text);
                if (companyAccount != null)
                {

                    name.Text = companyAccount.name;
                    crruncy.Text = companyAccount.crruncy;
                    cash.Text = companyAccount.cash.ToString();
                    arabic_cash.Text = new model.ToWord(companyAccount.cash, companyAccount.crruncy).ConvertToArabic();
                    this.Size = new Size(570, 419);
                }
                else { System.Windows.Forms.MessageBox.Show("هذا الرقم لاينتمي لأي حساب موجود"); }
            }
            else
            {
                this.Size = new Size(570, 132);
            }

        }
    }
}

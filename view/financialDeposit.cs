using System;
using System.Drawing;

namespace Bank_System.view
{

    public partial class financialDeposit : model.FormWithPlugins
    {
        model.personalAccount account;
        model.companyAccount companyAccount;

        #region methods
        void setInstallmentData() {

            if (personalacc.Checked && accountNumber.Text != "")
            {

                account = db.personalAccountDB.getAccountDataByID(accountNumber.Text);
                if (account != null)
                {
                  
                    name.Text = account.name;
                    crruncy.Text = account.crruncy;
                    cash.Text = account.cash.ToString();
                    arabic_cash.Text = new model.ToWord(account.cash, account.crruncy).ConvertToArabic();
                    var installment = db.installmentsDB.getInstallmentWithAccountNumber(accountNumber.Text);
                    if (installment != null && installment.installment_id_this_period <= DateTime.Now)
                    {
                        button4.Enabled = true;
                        panel2.Visible = true;
                        date.Text = installment.installment_id_this_period.ToShortDateString();
                        installmentformonth.Text = installment.installment_value_with_benfit.ToString();
                    }
                    else
                    {
                        button4.Enabled = false;
                        panel2.Visible = false;
                        installmentformonth.Text = " لا توجد اي اقساط لهذا الشهر";
                    }
                    this.Size = new Size(570, 469);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("هذا الرقم لاينتمي لأي حساب موجود");
                    this.Size = new Size(570, 132);
                }

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
                    var installment = db.installmentsDB.getInstallmentWithAccountNumber(accountNumber.Text);//dont forget to make company
                    if (installment != null && installment.installment_id_this_period <= DateTime.Now)
                    {
                        button4.Enabled = true;
                        panel2.Visible = true;
                        date.Text = installment.installment_id_this_period.ToShortDateString();
                        installmentformonth.Text = installment.installment_value_with_benfit.ToString();
                    }
                    else
                    {
                        button4.Enabled = false;
                        panel2.Visible = false;
                        installmentformonth.Text = " لا توجد اي اقساط لهذا الشهر";
                    }
                    this.Size = new Size(570, 469);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("هذا الرقم لاينتمي لأي حساب موجود");
                    this.Size = new Size(570, 132);
                }
            }
            else
            {
                this.Size = new Size(570, 132);
            }

        }
        #endregion
        public financialDeposit()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            setInstallmentData();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (personalacc.Checked && add_cash.Text != "")
            {
                if (db.dipositAndWithdrawal.addPersonalDiposit(accountNumber.Text, double.Parse(add_cash.Text)))
                {
                    setInstallmentData();
                    add_cash.Text = "";
                    System.Windows.Forms.MessageBox.Show("تم السحب بنجاح");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("فشلت عملية السحب");
                }
            }
            else if (companyacc.Checked && add_cash.Text != "")
            {
                if (db.dipositAndWithdrawal.addCompanyDiposit(accountNumber.Text, double.Parse(add_cash.Text)))
                {
                    setInstallmentData();
                    add_cash.Text = "";
                    System.Windows.Forms.MessageBox.Show("تم الايداع بنجاح");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("فشلت عملية الايداع");
                }
            }
         
        }

        private void add_cash_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            AcceptOnlyNumbersTB(sender,e);
        }
    }
}

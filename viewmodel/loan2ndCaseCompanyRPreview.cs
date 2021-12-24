using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bank_System.viewmodel
{
    public partial class loan2ndCaseCompanyRPreview : Form
    {
        public loan2ndCaseCompanyRPreview()
        {
            InitializeComponent();
        }
        model.LoanClasses.companyWithoutAccountLoan loan;
        public loan2ndCaseCompanyRPreview(model.LoanClasses.companyWithoutAccountLoan companyLoan)
        {
            InitializeComponent();
            loan = companyLoan;
            name.Text = loan.tempcompany.name;
            feildPreviewNotes.Text = loan.fieldPreviewNote;
            crruncy.Text = loan.tempcompany.crruncy;
            bankAccountiD.Text = loan.tempcompany.accountNumber;

            loanID.Text = loan.loanID;
            loanValue.Text = loan.loanValue.ToString();

            arabicLoanValue.Text = new model.ToWord(loan.loanValue, loan.tempcompany.crruncy)
                .ConvertToArabic();
            installmentsNumber.Text = loan.installmentsNumber.ToString();
            installmentSystem.Text = loan.installmentsSystem;
            installmentValue.Text = loan.installmentValue.ToString();
            installmentValue_in_arabic.Text = new model.ToWord(loan.installmentValue, loan.tempcompany.crruncy).ConvertToArabic();
            binfetPrecentage.Text = loan.benfitPrecent.ToString();
            loanValueWithBinfets.Text = loan.loanValueWithBinfets.ToString();
            loanValue_in_arabic.Text = new model.ToWord(loan.loanValueWithBinfets, loan.tempcompany.crruncy).ConvertToArabic();
            installmentWithBinfet.Text = loan.installmentValueWithBinfets.ToString();
            inValue_with_in_arabic.Text = new model.ToWord(loan.installmentValueWithBinfets, loan.tempcompany.crruncy).ConvertToArabic();
            loanEndDate.Text = model.calcLoanEndDate.endDateString(loan.loanEndDate);
            if (loan.haveBankAccount)
            {

                this.ishaveanotherbank.Text = "نعم";
                this.ishaveanotherbank.BackColor = Color.SpringGreen;
                this.ishaveanotherbank.ForeColor = Color.Maroon;
                morebankinfo.Visible = true;
                bankName.Text = loan.bankName;
                accountNumberINBank.Text = loan.bankNumber;
            }
            else
            {
                this.ishaveanotherbank.Text = "لا";
                this.ishaveanotherbank.BackColor = Color.Maroon;
                this.ishaveanotherbank.ForeColor = Color.SpringGreen;
            }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loanReportPreview_Load(object sender, EventArgs e)
        {
            dayDate.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" تمت طباعة التقارير جري الحفظ");
            if (db.companyLoanDB.addLoanWithoutAccount(loan))
            {
                MessageBox.Show("تم الحفظ");
            }
            else
            {
                MessageBox.Show("لم يتم الحفظ بشكل سليم");
            }
        }

        private void loanID_TextChanged(object sender, EventArgs e)
        {

        }

        private void ishaveanotherbank_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

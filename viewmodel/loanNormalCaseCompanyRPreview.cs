using System;
using System.Windows.Forms;

namespace Bank_System.viewmodel
{
    public partial class loanNormalCaseCompanyRPreview : Form
    {
        public loanNormalCaseCompanyRPreview()
        {
            InitializeComponent();
        }
        model.LoanClasses.companyWithAccountInOurBankLoan loan;
        public loanNormalCaseCompanyRPreview(model.LoanClasses.companyWithAccountInOurBankLoan companyLoan)
        {
            InitializeComponent();
            loan = companyLoan;
            name.Text = loan.companyAccount.name;
            feildPreviewNotes.Text = loan.fieldPreviewNote;
            crruncy.Text = loan.companyAccount.crruncy;
            bankAccountiD.Text = loan.companyAccount.accountNumber;

            loanID.Text = loan.loanID;
            loanValue.Text = loan.loanValue.ToString();

            arabicLoanValue.Text = new model.ToWord(loan.loanValue, loan.companyAccount.crruncy)
                .ConvertToArabic();
            installmentsNumber.Text = loan.installmentsNumber.ToString();
            installmentSystem.Text = loan.installmentsSystem;
            installmentValue.Text = loan.installmentValue.ToString();
            installmentValue_in_arabic.Text = new model.ToWord(loan.installmentValue, loan.companyAccount.crruncy).ConvertToArabic();
            binfetPrecentage.Text = loan.benfitPrecent.ToString();
            loanValueWithBinfets.Text = loan.loanValueWithBinfets.ToString();
            loanValue_in_arabic.Text = new model.ToWord(loan.loanValueWithBinfets, loan.companyAccount.crruncy).ConvertToArabic();
            installmentWithBinfet.Text = loan.installmentValueWithBinfets.ToString();
            inValue_with_in_arabic.Text = new model.ToWord(loan.installmentValueWithBinfets, loan.companyAccount.crruncy).ConvertToArabic();
            loanEndDate.Text = model.calcLoanEndDate.endDateString(loan.loanEndDate);


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
            if (db.companyLoanDB.addNormalLoan(loan))
            {
                this.Close();
                model.systemData.navigator.formStore.Pop().Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            model.systemData.navigator.formStore.Pop().Visible = true;
        }
    }
}

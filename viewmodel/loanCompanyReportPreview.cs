using System;
using System.Windows.Forms;

namespace Bank_System.viewmodel
{
    public partial class loanCompanyReportPreview : Form
    {
        public loanCompanyReportPreview()
        {
            InitializeComponent();
        }
        model.LoanClasses.companyWithAccountInOurBankLoan loan;
        public loanCompanyReportPreview(model.LoanClasses.companyWithAccountInOurBankLoan companyLoan)
        {
            InitializeComponent();
            loan = companyLoan;
            loanID.Text = loan.loanID;
            loanValue.Text = loan.loanValue.ToString();

            arabicLoanValue.Text = new model.ToWord(loan.loanValue, model.CurrencyInfo.CurrencyType.EGP)
                .ConvertToArabic();
            installmentsNumber.Text = loan.installmentsNumber.ToString();
            installmentSystem.Text = loan.installmentsSystem;
            installmentValue.Text = loan.installmentValue.ToString();
            binfetPrecentage.Text = loan.benfitPrecent.ToString();
            loanValueWithBinfets.Text = loan.loanValueWithBinfets.ToString();
            installmentWithBinfet.Text = loan.installmentValueWithBinfets.ToString();
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

        }

        private void loanID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

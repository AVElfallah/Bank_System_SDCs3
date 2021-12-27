using System;
using System.Windows.Forms;

namespace Bank_System.viewmodel
{
    public partial class loanPersonalRPrieview : Form
    {
        public loanPersonalRPrieview()
        {
            InitializeComponent();
        }
        model.LoanClasses.personalLoan loan;
        public loanPersonalRPrieview(model.LoanClasses.personalLoan pLoan)
        {
            InitializeComponent();
            loan = pLoan;
            p1.Visible = !loan.ISCBankUser;
            tempAccountNumber.Text = loan.personal.accountNumber;
            name.Text = loan.personal.name;
            feildPreviewNotes.Text = loan.fieldPreviewNote;
            crruncy.Text = loan.personal.crruncy;
            bankAccountiD.Text = loan.personal.accountNumber;
            pictureBox3.Image = model.photo.decryption(loan.personal.nationalIdPhoto);
            loanID.Text = loan.loanID;
            loanValue.Text = loan.loanValue.ToString();

            arabicLoanValue.Text = new model.ToWord(loan.loanValue, loan.personal.crruncy)
                .ConvertToArabic();
            installmentsNumber.Text = loan.installmentsNumber.ToString();
            installmentSystem.Text = loan.installmentsSystem;
            installmentValue.Text = loan.installmentValue.ToString();
            installmentValue_in_arabic.Text = new model.ToWord(loan.installmentValue, loan.personal.crruncy).ConvertToArabic();
            binfetPrecentage.Text = loan.benfitPrecent.ToString();
            loanValueWithBinfets.Text = loan.loanValueWithBinfets.ToString();
            loanValue_in_arabic.Text = new model.ToWord(loan.loanValueWithBinfets, loan.personal.crruncy).ConvertToArabic();
            installmentWithBinfet.Text = loan.installmentValueWithBinfets.ToString();
            inValue_with_in_arabic.Text = new model.ToWord(loan.installmentValueWithBinfets, loan.personal.crruncy).ConvertToArabic();
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
            if (db.personalLoanDB.addLoan(loan))
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

using System;

namespace Bank_System.view
{
    public partial class newCompanyLoan : model.FormWithPlugins
    {
        public newCompanyLoan()
        {
            InitializeComponent();
        }




        private void newPersonalAccount_Load(object sender, EventArgs e)
        {

        }

     

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkAndChangeTheTax();
        }

        void checkAndChangeTheTax()
        {
            if (installmentsPaymentsSys.Text != "" &&
                totalCostOfLoan.Text != "" &&
                totalLoanInstallments.Text != ""
                )
            {
                double totalCost = double.Parse(totalCostOfLoan.Text);//اجمالي قيمة القرض
                double installmentsNum = double.Parse(totalLoanInstallments.Text);//عدد الاقساط
                var sum = totalCost / installmentsNum;
                totalInstallments.Text = sum.ToString();




            }
            else {
                totalInstallments.Text = "";
            }

        }

        private void totalLoanInstallments_TextChanged(object sender, EventArgs e)
        {
            checkAndChangeTheTax();
        }

        private void totalCostOfLoan_TextChanged(object sender, EventArgs e)
        {
            checkAndChangeTheTax();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}

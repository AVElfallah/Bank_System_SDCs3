using System;

namespace Bank_System.view
{
    public partial class newCompanyLoan : model.FormWithPlugins
    {

        #region constans
        DateTime endDATE = new DateTime();

        #endregion

        public newCompanyLoan()
        {
            InitializeComponent();
            groupBox3.Location = new System.Drawing.Point(13, 289);
        }



      
        private void newPersonalAccount_Load(object sender, EventArgs e)
        {

        }


     


        private void totalCostOfLoan_TextChanged_1(object sender, EventArgs e)

        {
            checkAndChangeValues();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
             var account=new model.LoanClasses.companyWithAccountInOurBankLoan() ;
                var company = new model.companyAccount();
                company.name = accountNumber.Text;
                company.crruncy = crruncy.Text;
             
                company.accountNumber = accountNumber.Text;
              //  company.tradeReportPhotoPath = tradeReportImge.Image.ToString();
                //company.financialIdPhotoPath = taxIDImag.Image.ToString();
                account.loanID = model.RandomNumbers.accountNumberGen();
                account.companyAccount=company;
                account.installmentsNumber =double.Parse(installmentsNumber.Text);
                account.installmentsSystem = installmentsPaymentsSys.Text;
                account.installmentValue =  double.Parse( installmentValue.Text);
                account.installmentValueWithBinfets = double.Parse(installmentWithBinfet.Text);
                account.loanValue = double.Parse(loanValue.Text);
                account.loanValueWithBinfets = double.Parse(loanValue.Text)
                    +
                    double.Parse(loanValue.Text) *(double.Parse(binfetPrecentage.Text)/100);
                account.benfitPrecent =double.Parse(binfetPrecentage.Text);
                account.loanEndDate = endDATE;
                var preview =new viewmodel.loanCompanyReportPreview(account);
                preview.ShowDialog();


            }
         
        }

        private void installmentsNumber_TextChanged(object sender, EventArgs e)
        {
            checkAndChangeValues();
            calcEndDate();
        }

        private void installmentsPaymentsSys_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkAndChangeValues();
            calcEndDate();
        }

        private void binfetPrecentage_TextChanged(object sender, EventArgs e)
        {
            calcinstallmentWithBinfet();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            feildPreview_FileDialog.ShowDialog();
            if (feildPreview_FileDialog.FileName != "") {

                fieldPreviewpath.Text = feildPreview_FileDialog.FileName;
            
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (feildPreview_FileDialog.FileName != "") { 
            
            var dialog=new viewmodel.previewIMGDialog(feildPreview_FileDialog.FileName,new System.Drawing.Bitmap(feildPreview_FileDialog.FileName) );
                dialog.ShowDialog();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = checkBox1.Checked;
            groupBox3.Location = !checkBox1.Checked? new System.Drawing.Point(13, 289): new System.Drawing.Point(13, 453);
        }


        void calcEndDate()
        {
            try
            {
                int ins = int.Parse(installmentsNumber.Text);
                string inSystem = installmentsPaymentsSys.Text;
                if (ins != null && inSystem != "")
                {

                    endD.Text = model.calcLoanEndDate.endDateString(inSystem, ins);
                    endDATE = model.calcLoanEndDate.endDate(inSystem, ins);
                }
            }
            catch (Exception ex) { }
        }
        void calcinstallmentWithBinfet()
        {
            try
            {
                if (binfetPrecentage.Text != "")
                {
                    var i = double.Parse(binfetPrecentage.Text) / 100;
                    installmentWithBinfet.Text = (double.Parse(installmentValue.Text) + double.Parse(installmentValue.Text) * i).ToString();
                }
                else
                {
                    installmentWithBinfet.Text = 0.ToString();
                }
            }
            catch (Exception) { }

        }
        #region methods
        void checkAndChangeValues()
        {
            try
            {
                if (installmentsPaymentsSys.Text != "" &&
                    loanValue.Text != "" &&
                    installmentsNumber.Text != ""
                    )
                {
                    double totalCost = double.Parse(loanValue.Text);//اجمالي قيمة القرض
                    double installmentsNum = double.Parse(installmentsNumber.Text);//عدد الاقساط
                    var sum = totalCost / installmentsNum;
                    installmentValue.Text = sum.ToString();

                    calcinstallmentWithBinfet();


                }
                else
                {
                    installmentValue.Text = "0";
                    calcinstallmentWithBinfet();
                }
            }
            catch (Exception)
            {
            }

        }
        #endregion
    }
}

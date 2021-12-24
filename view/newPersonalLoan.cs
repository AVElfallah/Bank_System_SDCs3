using System;
using System.Windows.Forms;

namespace Bank_System.view
{

    public partial class newPersonalLoan : Form
    {
        model.LoanClasses.personalLoan loan;
        DateTime endDATE = new DateTime();
        model.personalAccount personalAccount;
        public newPersonalLoan()
        {
            InitializeComponent();
        }
        #region methods
        //validation
        bool validationCaseNotBankCustomer()
        {
            if (
                  fieldPreviewNotes2.Text != "" &&
                  fieldPreview_FileDialog.FileName != "" &&
                  bankAccountReport_FileDialog.FileName != "" &&
                  elcReceipt_FileDialog.FileName != "" &&
                  salaryTrans_FileDialog.FileName != "" &&
                  nationalID_FileDialog.FileName!=""&&
                  tradeReport_FileDialog.FileName!=""&&
                  loanValue2.Text != "" &&
                  installmentsNumber2.Text != "" &&
                  installmentsSystem2.Text != ""
                  && binfetPrecentage2.Text != ""
                  )
            {
                return true;
            }

            return false;

        }
        bool validationNormalCase()
        {
            if (personalAccount != null &&
                fieldPreviewNotes.Text != "" &&
                fieldPreview_FileDialog.FileName != "" &&
                bankAccountReport_FileDialog.FileName!=""&&
                elcReceipt_FileDialog.FileName != ""&&
                salaryTrans_FileDialog.FileName!=""&&

                loanValue.Text != "" &&
                installmentsNumber.Text != "" &&
                installmentsPaymentsSys.Text != ""
                && binfetPrecentage.Text != ""
                )
            {
                return true;
            }

            return false;
        }
        //equation
        void calcEndDate2()
        {
            try
            {
                int ins = int.Parse(installmentsNumber2.Text);
                string inSystem = installmentsSystem2.Text;
                if (inSystem != "")
                {

                    endDate2.Text = model.calcLoanEndDate.endDateString(inSystem, ins);
                    endDATE = model.calcLoanEndDate.endDate(inSystem, ins);
                }
            }
            catch (Exception) { }
        }

        void calcinstallmentWithBinfet2()
        {
            try
            {
                if (binfetPrecentage2.Text != "")
                {
                    var i = double.Parse(binfetPrecentage2.Text) / 100;
                    installmentWithBinfets2.Text = (double.Parse(installmentValue2.Text) + double.Parse(installmentValue2.Text) * i).ToString();
                }
                else
                {
                    installmentWithBinfets2.Text = 0.ToString();
                }
            }
            catch (Exception) { }

        }

        void checkAndChangeValues2()
        {
            try
            {
                if (installmentsSystem2.Text != "" &&
                    loanValue2.Text != "" &&
                    installmentsNumber2.Text != ""
                    )
                {
                    double totalCost = double.Parse(loanValue2.Text);//اجمالي قيمة القرض
                    double installmentsNum = double.Parse(installmentsNumber2.Text);//عدد الاقساط
                    var sum = totalCost / installmentsNum;
                    installmentValue2.Text = sum.ToString();

                    calcinstallmentWithBinfet2();


                }
                else
                {
                    installmentValue2.Text = "0";
                    calcinstallmentWithBinfet2();
                }
            }
            catch (Exception)
            {
            }

        }
        void calcEndDate()
        {
            try
            {
                int ins = int.Parse(installmentsNumber.Text);
                string inSystem = installmentsPaymentsSys.Text;
                if (inSystem != "")
                {

                    endD.Text = model.calcLoanEndDate.endDateString(inSystem, ins);
                    endDATE = model.calcLoanEndDate.endDate(inSystem, ins);
                }
            }
            catch (Exception) { }
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


        #region haveBankAccount
        private void button2_Click(object sender, EventArgs e)
        {
            newPersonalAccount account = new newPersonalAccount();
            this.Close();
            account.ShowDialog();
        }

        private void newPersonalLoan_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (validationNormalCase()) {

                loan=new model.LoanClasses.personalLoan();
                loan.personal = personalAccount;
                loan.loanEndDate = endDATE;
                loan.fieldPreviewImage =
                    model.photo.encryption(fieldPreview_FileDialog.FileName);
                loan.bankAccountReportPhoto =
                    model.photo.encryption(bankAccountReport_FileDialog.FileName);
                loan.elcReceiptPhoto =
                model.photo.encryption(elcReceipt_FileDialog.FileName);
                loan.salaryTransferPhoto =
                model.photo.encryption(salaryTrans_FileDialog.FileName);
                loan.fieldPreviewNote = fieldPreviewNotes.Text;
               
                loan.loanID = model.RandomNumbers.accountNumberGen();
                loan.installmentsNumber = double.Parse(installmentsNumber.Text);
                loan.benfitPrecent = double.Parse(binfetPrecentage.Text);
                loan.loanValue = double.Parse(loanValue.Text);
                loan.loanValueWithBinfets = loan.loanValue + (loan.benfitPrecent/100)*loan.loanValue;
                loan.installmentsSystem=installmentsPaymentsSys.Text;
                loan.installmentValue =  double.Parse(installmentValue.Text);
                loan.ISCBankUser = true;
                loan.installmentValueWithBinfets = double.Parse(installmentWithBinfet.Text);
                viewmodel.loanPersonalRPrieview rPrieview =new viewmodel.loanPersonalRPrieview (loan) ;
                rPrieview.ShowDialog();
            }
            else
            {
                MessageBox.Show("برجاء التأكد من ادخال كل البيانات بشكل سليم");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personalAccount = null;
            personalAccount = db.personalAccountDB.getAccountDataByID(accountNumber.Text);
            if (personalAccount != null)
            {
                accountName.Text = personalAccount.name;
                crruncy.Text = personalAccount.crruncy;
                crlbl.Text = personalAccount.crruncy;
                cash.Text = personalAccount.cash.ToString();
                cash_in_arabic.Text = new model.ToWord(personalAccount.cash, personalAccount.crruncy).ConvertToArabic();
                trade_report.Image = model.photo.decryption(personalAccount.tradeReportPhoto);
                national_Id.Image = model.photo.decryption(personalAccount.nationalIdPhoto);

                p1.Visible = true;  
                p2.Visible=true;    
            }
            else {
                p1.Visible = false;
                p2.Visible=false;
                MessageBox.Show("لاينتمي هذا الرقم لأي حساب بالنظام"); }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            fieldPreview_FileDialog.ShowDialog();
            if (fieldPreview_FileDialog.FileName != "")
            {
                fieldPreviewpath.Text = fieldPreview_FileDialog.FileName;

            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (fieldPreview_FileDialog.FileName != "")
            {
                new viewmodel
                       .previewIMGDialog(fieldPreview_FileDialog.FileName
                       , new System.Drawing.Bitmap(fieldPreview_FileDialog.FileName));
            }
        }
        private void loanValue_TextChanged(object sender, EventArgs e)
        {
            checkAndChangeValues();
            calcEndDate();
            calcinstallmentWithBinfet();
        }

        private void installmentsNumber_TextChanged(object sender, EventArgs e)
        {
            checkAndChangeValues();
            calcEndDate();
            calcinstallmentWithBinfet();
        }

        private void binfetPrecentage_TextChanged(object sender, EventArgs e)
        {
            checkAndChangeValues();
            calcEndDate();
            calcinstallmentWithBinfet();
        }

        private void installmentsPaymentsSys_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkAndChangeValues();
            calcEndDate();
            calcinstallmentWithBinfet();
        }


        private void pictureBox12_Click(object sender, EventArgs e)
        {
            elcReceipt_FileDialog.ShowDialog();
            if (elcReceipt_FileDialog.FileName != "")
            {
                elcReceipt.Text = elcReceipt_FileDialog.FileName;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (elcReceipt_FileDialog.FileName != "")
            {
                new viewmodel
                      .previewIMGDialog(elcReceipt_FileDialog.FileName
                      , new System.Drawing.Bitmap(elcReceipt_FileDialog.FileName)).ShowDialog();

            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            salaryTrans_FileDialog.ShowDialog();
            if (salaryTrans_FileDialog.FileName != "")
            {
                salaryTransfer.Text = salaryTrans_FileDialog.FileName;
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            new viewmodel
                    .previewIMGDialog(salaryTrans_FileDialog.FileName
                    , new System.Drawing.Bitmap(salaryTrans_FileDialog.FileName)).ShowDialog();

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            bankAccountReport_FileDialog.ShowDialog();
            if (bankAccountReport_FileDialog.FileName != "")
            {
                bankReport.Text = bankAccountReport_FileDialog.FileName;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            new viewmodel
                              .previewIMGDialog(bankAccountReport_FileDialog.FileName
                              , new System.Drawing.Bitmap(bankAccountReport_FileDialog.FileName)).ShowDialog();

        }
        #endregion

        #region notHaveBankAccount
        private void loanValue2_TextChanged(object sender, EventArgs e)
        {
            checkAndChangeValues2();
            calcEndDate2();
            calcinstallmentWithBinfet2();
        }

        private void installmentsNumber2_TextChanged(object sender, EventArgs e)
        {
            checkAndChangeValues2();
            calcEndDate2();
            calcinstallmentWithBinfet2();
        }

        private void binfetPrecentage2_TextChanged(object sender, EventArgs e)
        {
            checkAndChangeValues2();
            calcEndDate2();
            calcinstallmentWithBinfet2();
        }

        private void installmentsSystem2_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkAndChangeValues2();
            calcEndDate2();
            calcinstallmentWithBinfet2();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            nationalID_FileDialog.ShowDialog();
            if (nationalID_FileDialog.FileName != "")
            {
                national_id2.Text = nationalID_FileDialog.FileName;

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new viewmodel
                           .previewIMGDialog(nationalID_FileDialog.FileName
                         , new System.Drawing.Bitmap(nationalID_FileDialog.FileName)).ShowDialog();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tradeReport_FileDialog.ShowDialog();
            if (tradeReport_FileDialog.FileName != "")
            {
                tradereport2.Text=tradeReport_FileDialog.FileName;  
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
  new viewmodel
                           .previewIMGDialog(tradeReport_FileDialog.FileName
                         , new System.Drawing.Bitmap(tradeReport_FileDialog.FileName)).ShowDialog();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
 elcReceipt_FileDialog.ShowDialog();
            if (elcReceipt_FileDialog.FileName != "")
            {
                elcrecepit2.Text = elcReceipt_FileDialog.FileName;
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (elcReceipt_FileDialog.FileName != "")
            {
                new viewmodel
                      .previewIMGDialog(elcReceipt_FileDialog.FileName
                      , new System.Drawing.Bitmap(elcReceipt_FileDialog.FileName)).ShowDialog();

            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            bankAccountReport_FileDialog.ShowDialog();
            if (bankAccountReport_FileDialog.FileName != "")
            {
                bankreport2.Text = bankAccountReport_FileDialog.FileName;
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            new viewmodel
                                          .previewIMGDialog(bankAccountReport_FileDialog.FileName
                                          , new System.Drawing.Bitmap(bankAccountReport_FileDialog.FileName)).ShowDialog();

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            salaryTrans_FileDialog.ShowDialog();
            if (salaryTrans_FileDialog.FileName != "")
            {
                salarytransfer2.Text = salaryTrans_FileDialog.FileName;
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            new viewmodel
                 .previewIMGDialog(salaryTrans_FileDialog.FileName
                 , new System.Drawing.Bitmap(salaryTrans_FileDialog.FileName)).ShowDialog();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            fieldPreview_FileDialog.ShowDialog();
            if (fieldPreview_FileDialog.FileName != "")
            {
                fieldPreviewPath2.Text = fieldPreview_FileDialog.FileName;

            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (fieldPreview_FileDialog.FileName != "")
            {
                new viewmodel
                       .previewIMGDialog(fieldPreview_FileDialog.FileName
                       , new System.Drawing.Bitmap(fieldPreview_FileDialog.FileName)).ShowDialog();
            }
        }


        #endregion

        private void button4_Click(object sender, EventArgs e)
        {
            if (validationCaseNotBankCustomer())
            {
                model.personalAccount acc = new model.personalAccount();
                acc.name = personalName2.Text;
                acc.nationalIdPhoto = model.photo.encryption(nationalID_FileDialog.FileName);
                acc.tradeReportPhoto = model.photo.encryption(tradeReport_FileDialog.FileName);
                acc.crruncy = crruncy2.Text;
                acc.accountNumber = model.RandomNumbers.accountNumberGen();

                loan = new model.LoanClasses.personalLoan();
                loan.personal = acc;
                loan.loanEndDate = endDATE;
                loan.fieldPreviewImage =
                    model.photo.encryption(fieldPreview_FileDialog.FileName);
                loan.bankAccountReportPhoto =
                    model.photo.encryption(bankAccountReport_FileDialog.FileName);
                loan.elcReceiptPhoto =
                model.photo.encryption(elcReceipt_FileDialog.FileName);
                loan.salaryTransferPhoto =
                model.photo.encryption(salaryTrans_FileDialog.FileName);
                loan.fieldPreviewNote = fieldPreviewNotes2.Text;

                loan.loanID = model.RandomNumbers.accountNumberGen();
                loan.installmentsNumber = double.Parse(installmentsNumber2.Text);
                loan.benfitPrecent = double.Parse(binfetPrecentage2.Text);
                loan.loanValue = double.Parse(loanValue2.Text);
                loan.loanValueWithBinfets = loan.loanValue + (loan.benfitPrecent / 100) * loan.loanValue;
                loan.installmentsSystem = installmentsSystem2.Text;
                loan.installmentValue = double.Parse(installmentValue2.Text);
                loan.ISCBankUser = false;
                loan.installmentValueWithBinfets = double.Parse(installmentWithBinfets2.Text);
                viewmodel.loanPersonalRPrieview rPrieview = new viewmodel.loanPersonalRPrieview(loan);
                rPrieview.ShowDialog();
            }
            else
            {
                MessageBox.Show("برجاء التأكد من ادخال كل البيانات بشكل سليم");
            }
        }
    }
}

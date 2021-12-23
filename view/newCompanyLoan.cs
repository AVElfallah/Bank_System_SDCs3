using System;

namespace Bank_System.view
{
    public partial class newCompanyLoan : model.FormWithPlugins
    {

        #region constans
        DateTime endDATE = new DateTime();
        model.companyAccount companyAccount;

        #endregion

        public newCompanyLoan()
        {
            InitializeComponent();

        }

        #region Tab1Region
        private void button3_Click(object sender, EventArgs e)
        {
            if (validationNormalCase())
            {
                var account = new model.LoanClasses.companyWithAccountInOurBankLoan();


                account.loanID = model.RandomNumbers.accountNumberGen();
                account.companyAccount = companyAccount;
                account.installmentsNumber = double.Parse(installmentsNumber.Text);
                account.installmentsSystem = installmentsPaymentsSys.Text;
                account.installmentValue = double.Parse(installmentValue.Text);
                account.installmentValueWithBinfets = double.Parse(installmentWithBinfet.Text);
                account.loanValue = double.Parse(loanValue.Text);
                account.loanValueWithBinfets = double.Parse(loanValue.Text)
                    +
                    double.Parse(loanValue.Text) * (double.Parse(binfetPrecentage.Text) / 100);
                account.benfitPrecent = double.Parse(binfetPrecentage.Text);
                account.loanEndDate = endDATE;
                account.fieldPreviewNote = fieldPreviewNotes.Text;
                account.fieldPreviewImage = model.photo.encryption(fieldPreview_FileDialog.FileName);
                var preview = new viewmodel.loanNormalCaseCompanyRPreview(account);
                preview.ShowDialog();


            }
            else
            {
                System.Windows.Forms.MessageBox.Show("تأكد من اكمالك للبيانات بشكل صحيح");
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

        private void totalCostOfLoan_TextChanged_1(object sender, EventArgs e)

        {
            checkAndChangeValues();



        }
        private void button1_Click(object sender, EventArgs e)
        {
            companyAccount = null;
            if (accountNumber.Text != "")
            {
                companyAccount = db.companyAccountDB.getAccountById(accountNumber.Text);
                if (companyAccount != null)
                {
                    tradeReportImge.Image = model.photo.decryption(companyAccount.tradeReportPhoto);
                    taxIDImag.Image = model.photo.decryption(companyAccount.financialIdPhoto);
                    compName.Text = companyAccount.name;
                    crruncy.Text = companyAccount.crruncy;
                    cash.Text = companyAccount.cash.ToString();
                    cash_in_arabic.Text = new model.ToWord(companyAccount.cash, companyAccount.crruncy).ConvertToArabic();
                    crlbl.Text = companyAccount.crruncy;
                    p1.Visible = true;
                    p2.Visible = true;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("لاوجود لمثل هذا الحساب بالنظام");
                    p1.Visible = false;
                    p2.Visible = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newCompanyAccount account=new newCompanyAccount();
            this.Hide();
            account.ShowDialog();
            
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

                var dialog = new viewmodel.previewIMGDialog(fieldPreview_FileDialog.FileName, new System.Drawing.Bitmap(fieldPreview_FileDialog.FileName));
                dialog.ShowDialog();
            }
        }



        #endregion





        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tradeReport_FileDialog.ShowDialog();
            if (tradeReport_FileDialog.FileName != "")
            {
                tradeReportPath.Text = tradeReport_FileDialog.FileName;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (tradeReport_FileDialog.FileName != "")
            {
                new viewmodel.previewIMGDialog(tradeReport_FileDialog.FileName
                     , new System.Drawing.Bitmap(tradeReport_FileDialog.FileName))
                     .ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            financialID_FileDialog.ShowDialog();
            if (financialID_FileDialog.FileName != "")
            {
                taxsIdPath.Text = financialID_FileDialog.FileName;
            }
        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {

            if (financialID_FileDialog.FileName != "")
            {
                new viewmodel.previewIMGDialog(financialID_FileDialog.FileName
                       , new System.Drawing.Bitmap(financialID_FileDialog.FileName))
                       .ShowDialog();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            bankAccountReport.ShowDialog();
            if (bankAccountReport.FileName != "")
            {
                bankAccountReportPath.Text = bankAccountReport.FileName;

            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (bankAccountReport.FileName != "")
            {
                new viewmodel.previewIMGDialog(bankAccountReport.FileName
                    , new System.Drawing.Bitmap(bankAccountReport.FileName))
                    .ShowDialog();
            }
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            fieldPreview_FileDialog.ShowDialog();
            if (fieldPreview_FileDialog.FileName !=
                "")
            {

                fieldPreviewPath2.Text = fieldPreview_FileDialog.FileName;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (fieldPreview_FileDialog.FileName != "")
            {
                new viewmodel.previewIMGDialog(fieldPreview_FileDialog.FileName,
                  new System.Drawing.Bitmap(fieldPreview_FileDialog.FileName)).ShowDialog();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (validationCaseHaveAnotherBankAccount())
            {


            }
            else { System.Windows.Forms.MessageBox.Show("تأكد من اكمالك للبيانات بشكل صحيح"); }
        }
        private void loanValue2_TextChanged(object sender, EventArgs e)
        {
            checkAndChangeValues2();

        }

        private void installmentsNumber2_TextChanged(object sender, EventArgs e)
        {
            checkAndChangeValues();
            calcEndDate();
        }

        private void binfetPrecentage2_TextChanged(object sender, EventArgs e)
        {
            calcinstallmentWithBinfet2();
        }

        private void installmentsSystem2_SelectedIndexChanged(object sender, EventArgs e)
        {

            checkAndChangeValues2();
            calcEndDate2();
        }

     

        #region methods
        //validation
        bool validationCaseHaveAnotherBankAccount()
        {
            if (!checkBox1.Checked)
            {
                if (companyName2.Text != "" &&
                    tradeReport_FileDialog.FileName != "" &&
                    financialID_FileDialog.FileName != "" &&
                    crruncy2.Text != "" &&
                    fieldPreview_FileDialog.FileName != "" &&
                    fieldPreviewNotes2.Text != "" &&
                    loanValue2.Text != "" &&
                    installmentsNumber2.Text != "" &&
                   binfetPrecentage2.Text != "" &&
                   installmentsSystem2.Text != ""

                    )
                {

                    return true;
                }
            }
            else
            {
                if (companyName2.Text != "" &&
                                   tradeReport_FileDialog.FileName != "" &&
                                   financialID_FileDialog.FileName != "" &&
                                   crruncy2.Text != "" &&
                                   fieldPreview_FileDialog.FileName != "" &&
                                   fieldPreviewNotes2.Text != "" &&
                                   loanValue2.Text != "" &&
                                   installmentsNumber2.Text != "" &&
                                  binfetPrecentage2.Text != "" &&
                                  installmentsSystem2.Text != "" &&
                                  bankAccountReport.FileName != "" &&
                                  bankName.Text != "" &&
                                  accountNumberINbank.Text != ""

                                   )
                {

                    return true;
                }
            }
            return false;
        }
        bool validationNormalCase()
        {
            if (companyAccount != null &&
                fieldPreviewNotes.Text != "" &&
                fieldPreview_FileDialog.FileName != "" &&
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

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            panel1.Visible = checkBox1.Checked;
            pictureBox11.Visible = !checkBox1.Checked;
        }

        private void crruncy2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl.Text = crruncy2.Text;
        }
    }
}

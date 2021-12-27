using System;
using System.Data.SqlClient;

namespace Bank_System.db
{
    public static class companyLoanDB
    {
      
        public static bool addInstallment(model.installment installment)
        {

            var con = createConnection.openConnection();
            var qu = $"insert into installments values('{installment.loan_id}'" +
                $",'{installment.installment_id_this_period}','{installment.installment_id_next_period}',{installment.installment_value_with_benfit})";
            var cmd = new SqlCommand(qu, con);
            if (cmd.ExecuteNonQuery() != 0)
            {

                cmd.Cancel();
                con.Close();
                return true;
            }

            return false;
        }
        public static bool addLoanWithoutAccount(model.LoanClasses.companyWithoutAccountLoan company)
        {
            var con = createConnection.openConnection();
            var now = DateTime.Now;
            var qu = "insert into company_loan(is_bank_customer,loan_number,loan_value,benfit_precentage," +
                "installments_number,installment_value,installment_system,loan_end_date," +
                "loan_create_date,field_preview_image,field_preview_note,have_another_bank,temp_companyacc_id) values(" +
                $"{0},N'{company.loanID}'" +
                $",{company.loanValue},{company.benfitPrecent},{company.installmentsNumber}" +
                $",{company.installmentValue},N'{company.installmentsSystem}',N'{company.loanEndDate}'" +
                $",N'{now}',@photo,N'{company.fieldPreviewNote}',@anotherbank,@tempcomp)";
            var cmd = new SqlCommand(qu, con);
            cmd.Parameters.AddWithValue("photo", company.fieldPreviewImage);
            cmd.Parameters.AddWithValue("anotherbank", company.haveBankAccount ? 1 : 0);
            cmd.Parameters.AddWithValue("tempcomp", company.tempcompany.accountNumber);

            if (cmd.ExecuteNonQuery() != 0)
            {
                con.Close();
                cmd.Dispose();

                #region installmentSet
                var _1st_installment =DateTime.Now.AddMonths(company.getINTInsSystem);
                model.installment installment =new model.installment();
                installment.loan_id= company.loanID;    
                installment.installment_value_with_benfit= company.installmentValueWithBinfets;
                installment.installment_id_this_period = _1st_installment;
                installment.installment_id_next_period = _1st_installment.AddMonths(company.getINTInsSystem);
                addInstallment(installment);
                #endregion
                
                addtempCompanyAccount(company);
                return true;
            }
            con.Close();
            cmd.Dispose();
            return false;
        }
        private static bool addtempCompanyAccount(model.LoanClasses.companyWithoutAccountLoan company)
        {
            string qu = "insert into temp_company_account(temp_companyacc_id,name," +
                "trade_report_photo,financial_id_photo,crruncy,iscustomer_in_another_bank," +
                "bank_areport_l6m,bank_name,bank_number) " +
                $"values(N'{company.tempcompany.accountNumber}',N'{company.tempcompany.name}'," +
                $"@tradeRep,@financial,N'{company.tempcompany.crruncy}',@iscust,@bankRep," +
                $"N'{company.bankName}',N'{company.bankNumber}')";
            var con = createConnection.openConnection();
            var cmd = new SqlCommand(qu, con);
            cmd.Parameters.AddWithValue("tradeRep", company.tempcompany.tradeReportPhoto);
            cmd.Parameters.AddWithValue("financial", company.tempcompany.financialIdPhoto);
            cmd.Parameters.AddWithValue("iscust", company.haveBankAccount ? 1 : 0);
            cmd.Parameters.AddWithValue("bankRep", company.bankAccountReportLast6Month);

            if (cmd.ExecuteNonQuery() != 0)
            {
                con.Close();
                cmd.Dispose();

                return true;
            }
            con.Close();
            cmd.Dispose();
            return false;
        }
        public static bool addNormalLoan(model.LoanClasses.companyWithAccountInOurBankLoan company)
        {
            var con = createConnection.openConnection();
            var now = DateTime.Now;
            var qu = "insert into company_loan(is_bank_customer,number_in_bank,loan_number,loan_value,benfit_precentage," +
                "installments_number,installment_value,installment_system,loan_end_date," +
                "loan_create_date,field_preview_image,field_preview_note) values(" +
                $"{1},N'{company.companyAccount.accountNumber}',N'{company.loanID}'" +
                $",{company.loanValue},{company.benfitPrecent},{company.installmentsNumber}" +
                $",{company.installmentValue},N'{company.installmentsSystem}',N'{company.loanEndDate}'" +
                $",'{now}',@photo,N'{company.fieldPreviewNote}')";
            var cmd = new SqlCommand(qu, con);
            cmd.Parameters.AddWithValue("photo", company.fieldPreviewImage);

            if (cmd.ExecuteNonQuery() != 0)
            {
                con.Close();
                cmd.Dispose();
                #region installmentSet
                var _1st_installment = DateTime.Now.AddMonths(company.getINTInsSystem);
                model.installment installment = new model.installment();
                installment.loan_id = company.loanID;
                installment.installment_value_with_benfit = company.installmentValueWithBinfets;
                installment.installment_id_this_period = _1st_installment;
                installment.installment_id_next_period = _1st_installment.AddMonths(company.getINTInsSystem);
                addInstallment(installment);
                #endregion
                return true;
            }
            con.Close();
            cmd.Dispose();
            return false;
        }
    }
}





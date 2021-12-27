using System;
using System.Data.SqlClient;

namespace Bank_System.db
{
    public static class personalLoanDB
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

            private static bool addTempAccount(model.personalAccount account)
        {
            var conn = createConnection.openConnection();
            var qu = $"insert into temp_personal_account values('{account.accountNumber}'," +
                $"N'{account.name}',@natphoto,@traderep,N'{account.crruncy}')";
            var cmd = new SqlCommand(qu, conn);
            cmd.Parameters.AddWithValue("natphoto", account.nationalIdPhoto);
            cmd.Parameters.AddWithValue("traderep", account.tradeReportPhoto);
            if (cmd.ExecuteNonQuery() != 0)
            {
                cmd.Dispose();
                conn.Close();
                return true;
            }
            return false;
        }
        public static bool addLoan(model.LoanClasses.personalLoan personal)
        {
            var conn = createConnection.openConnection();
            var qu = $"insert into personal_loan values(@accid,@tempid,'{personal.loanID}'," +
                $"{personal.loanValue},{personal.installmentValue},{personal.installmentsNumber}" +
                $",{personal.benfitPrecent},N'{personal.installmentsSystem}',N'{DateTime.Now}',N'{personal.loanEndDate}'," +
                $"@fprPhoto,@bankrep,@elcrecepit" +
                $",@salarytrans,@isbankuser,N'{personal.fieldPreviewNote}')";
            var cmd = new SqlCommand(qu, conn);
            cmd.Parameters.AddWithValue("accid", personal.ISCBankUser ?
                personal.personal.accountNumber : (object)DBNull.Value);
            cmd.Parameters.AddWithValue("tempid", !personal.ISCBankUser ?
                personal.personal.accountNumber : (object)DBNull.Value);
            cmd.Parameters.AddWithValue("fprPhoto", personal.fieldPreviewImage);
            cmd.Parameters.AddWithValue("bankrep", personal.bankAccountReportPhoto);
            cmd.Parameters.AddWithValue("elcrecepit", personal.elcReceiptPhoto);
            cmd.Parameters.AddWithValue("salarytrans", personal.salaryTransferPhoto);
            cmd.Parameters.AddWithValue("isbankuser", personal.ISCBankUser ? 1 : 0);

            if (cmd.ExecuteNonQuery() != 0)
            {
                cmd.Cancel();
                conn.Close();
                if (!personal.ISCBankUser) addTempAccount(personal.personal);
                #region installmentCreation
                model.installment installment = new model.installment();
                var nextInstallmen = DateTime.Now.AddMonths(personal.getINTInsSystem);
                installment.loan_id = personal.loanID;
                installment.installment_id_this_period = nextInstallmen;
                installment.installment_id_next_period = nextInstallmen.AddMonths(personal.getINTInsSystem);
                installment.installment_value_with_benfit = personal.installmentValueWithBinfets;
                #endregion
                addInstallment(installment);    
                return true;
            }
            return false;
        }
    }
}

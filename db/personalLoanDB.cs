using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.db
{
    public static class personalLoanDB
    {
        private static bool addTempAccount(model.personalAccount account) {
            var conn=createConnection.openConnection();
            var qu = $"insert into temp_personal_account values('{account.accountNumber}'," +
                $"N'{account.name}',@natphoto,@traderep,N'{account.crruncy}')";
            var cmd = new SqlCommand(qu, conn);
            cmd.Parameters.AddWithValue("natphoto",account.nationalIdPhoto);
            cmd.Parameters.AddWithValue("traderep",account.tradeReportPhoto);
            if (cmd.ExecuteNonQuery() != 0) {
            cmd.Dispose();
        conn.Close();
            return true;    
            }
            return false;
        }
      public static bool  addLoan(model.LoanClasses.personalLoan personal) {
            var conn=createConnection.openConnection();
            var qu = $"insert into personal_loan values(@accid,@tempid,'{personal.loanID}'," +
                $"{personal.loanValue},{personal.installmentValue},{personal.installmentsNumber}" +
                $",{personal.benfitPrecent},N'{personal.installmentsSystem}',N'{DateTime.Now}',N'{personal.loanEndDate}'," +
                $"@fprPhoto,@bankrep,@elcrecepit" +
                $",@salarytrans,@isbankuser,N'{personal.fieldPreviewNote}')";
            var cmd =new SqlCommand(qu,conn);
            cmd.Parameters.AddWithValue("accid",personal.ISCBankUser?
                personal.personal.accountNumber:(object)DBNull.Value);
            cmd.Parameters.AddWithValue("tempid", !personal.ISCBankUser ?
                personal.personal.accountNumber : (object)DBNull.Value);
            cmd.Parameters.AddWithValue("fprPhoto",personal.fieldPreviewImage);
            cmd.Parameters.AddWithValue("bankrep", personal.bankAccountReportPhoto);
            cmd.Parameters.AddWithValue("elcrecepit", personal.elcReceiptPhoto);
            cmd.Parameters.AddWithValue("salarytrans", personal.salaryTransferPhoto);
            cmd.Parameters.AddWithValue("isbankuser", personal.ISCBankUser?1:0);

            if (cmd.ExecuteNonQuery() != 0) {
                cmd.Cancel();
                conn.Close();
              if(!personal.ISCBankUser)  addTempAccount(personal.personal);
                return true;
            }
            return false;
        }
    }
}

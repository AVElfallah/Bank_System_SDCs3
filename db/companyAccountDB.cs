using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.db
{
    public static class companyAccountDB
    {
      public static bool addAccount(model.companyAccount account)
        {
            var conn = createConnection.openConnection();
            var now = DateTime.Now.ToString();
            var sqlQu =
         $"insert into company_account values(N'{account.accountNumber}'" +
         $",N'{account.name}',N'{account.crruncy}',N'{account.accountReport}'" +
         $",N'{account.notes}',@financial_id_photo,@trade_report,{account.cash},@isHaveCheque,'{now}')";
            SqlCommand cmd = new SqlCommand(sqlQu, conn);
            cmd.Parameters.AddWithValue("financial_id_photo", account.financialIdPhoto);

            cmd.Parameters.AddWithValue("isHaveCheque", account.isHaveCheque ? 1 : 0);
            cmd.Parameters.AddWithValue("trade_report", account.tradeReportPhoto);
            if (cmd.ExecuteNonQuery() != 0)
            {
                conn.Close();
                cmd.Dispose();
                return true;
            }
            conn.Close();
            cmd.Dispose();
       return false;

        }
    }
}

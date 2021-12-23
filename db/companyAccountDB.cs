using System;
using System.Data.SqlClient;

namespace Bank_System.db
{
    public static class companyAccountDB
    {
        public static model.companyAccount getAccountById(string accountNumber)
        {
            try
            {
                model.companyAccount account = new model.companyAccount();
                var qu = $"select * from company_account where account_number='{accountNumber}'";
                var conn = db.createConnection.openConnection();
                var cmd = new SqlCommand(qu, conn);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    account.name = reader["name"].ToString();
                    account.accountNumber = accountNumber;

                    account.crruncy = reader["crruncy"].ToString();
                    account.accountReport = reader["account_report"].ToString();
                    account.notes = reader["note"].ToString();
                    account.cash = (double)reader["cash_in_bank"];

                    account.isHaveCheque = (bool)reader["is_have_cheque"];
                    account.tradeReportPhoto = (byte[])reader["trade_report_photo"];
                    account.financialIdPhoto = (byte[])reader["financial_id_photo"];

                    account.date = (DateTime)reader["date"];
                    conn.Close();
                    cmd.Cancel();

                    return account;

                }
                else
                {
                    conn.Close();
                    cmd.Cancel();

                    return null;
                }
            }
            catch (Exception)
            {


                return null;
            }
        }
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

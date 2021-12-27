using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.db
{
    public static class dipositAndWithdrawal
    {
       
        public static bool addCompanyWithdrawal(string accountNumber, double cash)
        {
            var conn = createConnection.openConnection();
            string qu = $"insert into withdrawal values('{accountNumber}',{cash},N'{DateTime.Now}')";
            var cmd = new SqlCommand(qu, conn);
            if (cmd.ExecuteNonQuery() != 0)
            {
                cmd.Cancel();
                cmd.CommandText = $"update company_account set cash_in_bank-={cash} where account_number='{accountNumber}'";
                if (cmd.ExecuteNonQuery() != 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            return false;
        }
        public static bool addCompanyDiposit(string accountNumber, double cash)
        {
            var conn = createConnection.openConnection();
            string qu = $"insert into deposit values('{accountNumber}',{cash},N'{DateTime.Now}')";
            var cmd = new SqlCommand(qu, conn);
            if (cmd.ExecuteNonQuery() != 0)
            {
                cmd.Cancel();
                cmd.CommandText = $"update company_account set cash_in_bank+={cash} where account_number='{accountNumber}'";
                if (cmd.ExecuteNonQuery() != 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            return false;
        }


        public static bool addPersonalWithdrawal(string accountNumber, double cash)
        {
            var conn = createConnection.openConnection();
            string qu = $"insert into withdrawal values('{accountNumber}',{cash},N'{DateTime.Now}')";
            var cmd = new SqlCommand(qu, conn);
            if (cmd.ExecuteNonQuery() != 0)
            {
                cmd.Cancel();
                cmd.CommandText = $"update personal_account set cash_in_account-={cash} where account_number='{accountNumber}'";
                if (cmd.ExecuteNonQuery() != 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            return false;
        }
        public static bool addPersonalDiposit(string accountNumber, double cash)
        {
            var conn = createConnection.openConnection();
            string qu = $"insert into deposit values('{accountNumber}',{cash},N'{DateTime.Now}')";
            var cmd = new SqlCommand(qu, conn);
            if (cmd.ExecuteNonQuery() != 0)
            {
                cmd.Cancel();
                cmd.CommandText = $"update personal_account set cash_in_account+={cash} where account_number='{accountNumber}'";
                if (cmd.ExecuteNonQuery() != 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            return false;
        }
    }
}

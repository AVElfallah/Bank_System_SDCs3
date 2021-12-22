using System;
using System.Data.SqlClient;

namespace Bank_System.db
{
    public static class personalAccountDB
    {
        public static bool createNewVisaByID(string accountNumber, model.Visa visa)
        {
            bool back = false;
            var con = createConnection.openConnection();
            var qu = $"update personal_account set visa_number='{visa.visaNumber}', is_have_visa={1} where account_number='{accountNumber}'";
            var qu2 = $"insert into visa values('{visa.visaNumber}','{visa.expDate}','{visa.nameInVisa}')";
            var cmd1 = new SqlCommand(qu, con);
            if (cmd1.ExecuteNonQuery() != 0)
            {
                cmd1.Cancel();
                cmd1 = new SqlCommand(qu2, con);
                back = true;
            }
            else { back = false; }
            if (cmd1.ExecuteNonQuery() != 0)
            {

                back = true;
            }
            else { back = false; }
            con.Close();
            cmd1.Dispose();
            return back;

        }
        public static model.Visa getVisaByID(string accountNumber)
        {
            var qu = $"select * from visa where visa_number in (select visa_number from personal_account where account_number='{accountNumber}')";
            var conn = db.createConnection.openConnection();
            var cmd = new SqlCommand(qu, conn);
            model.Visa visa = new model.Visa();
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                visa.visaNumber = (string)reader["visa_number"];
                visa.expDate = (string)reader["exp_date"];
                visa.nameInVisa = (string)reader["name_in_visa"];
            }
            return visa;
        }

        public static model.personalAccount getAccountDataByID(string accountNumber)
        {
            try
            {
                model.personalAccount account = new model.personalAccount();
                var qu = $"select * from personal_account where account_number='{accountNumber}'";
                var conn = db.createConnection.openConnection();
                var cmd = new SqlCommand(qu, conn);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    account.name = reader["name"].ToString();
                    account.accountNumber = accountNumber;
                    account.national = reader["nationalty"].ToString();
                    account.nationalId = reader["national_id"].ToString();
                    account.job = reader["job"].ToString();
                    account.crruncy = reader["crruncy"].ToString();
                    account.accountReport = reader["account_report"].ToString();
                    account.notes = reader["notes"].ToString();
                    account.cash = (double)reader["cash_in_account"];
                    account.isHaveVisa = (bool)reader["is_have_visa"];
                    account.isHaveCheque = (bool)reader["is_have_cheque"];
                    account.tradeReportPhoto = (byte[])reader["trade_report_photo"];
                    account.nationalIdPhoto = (byte[])reader["national_id_photo"];
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
        public static bool addAccountWithVisa(model.personalAccount account)
        {
            var conn = createConnection.openConnection();
            var now = DateTime.Now.ToString();
            bool back = false;
            var sqlQu =
         $"insert into personal_account values(N'{account.accountNumber}'" +
         $",N'{account.name}',N'{account.national}',N'{account.nationalId}'" +
         $",N'{account.job}',N'{account.crruncy}',N'{account.accountReport}'" +
         $",N'{account.notes}',{account.cash},@isHaveVisa" +
         $",@isHaveCheque,@visa_number" +
         $",@trade_report,@national_id_photo,'{now}')";
            SqlCommand cmd = new SqlCommand(sqlQu, conn);
            cmd.Parameters.AddWithValue("visa_number", $"{account.accountVisa.visaNumber}");
            cmd.Parameters.AddWithValue("isHaveVisa", account.isHaveVisa ? 1 : 0);
            cmd.Parameters.AddWithValue("isHaveCheque", account.isHaveCheque ? 1 : 0);
            cmd.Parameters.AddWithValue("trade_report", account.tradeReportPhoto);
            cmd.Parameters.AddWithValue("national_id_photo", account.nationalIdPhoto);
            if (cmd.ExecuteNonQuery() != 0)
            {

                cmd.Dispose();
                back = true;
            }
            var qu2 = $"insert into visa values('{account.accountVisa.visaNumber}','{account.accountVisa.expDate}','{account.accountVisa.nameInVisa}')";
            SqlCommand cmd2 = new SqlCommand(qu2, conn);
            if (cmd2.ExecuteNonQuery() != 0)
            {
                cmd2.Dispose();
                conn.Dispose();
                back = true;
            }
            return back;
        }
        public static bool addAccountWithoutVisa(model.personalAccount account)
        {
            var conn = createConnection.openConnection();
            var now = DateTime.Now.ToString();
            var sqlQu =
         $"insert into personal_account values(N'{account.accountNumber}'" +
         $",N'{account.name}',N'{account.national}',N'{account.nationalId}'" +
         $",N'{account.job}',N'{account.crruncy}',N'{account.accountReport}'" +
         $",N'{account.notes}',{account.cash},@isHaveVisa" +
         $",@isHaveCheque,@visa_number" +
         $",@trade_report,@national_id_photo,'{now}')";
            SqlCommand cmd = new SqlCommand(sqlQu, conn);
            cmd.Parameters.AddWithValue("visa_number", "");
            cmd.Parameters.AddWithValue("isHaveVisa", account.isHaveVisa ? 1 : 0);
            cmd.Parameters.AddWithValue("isHaveCheque", account.isHaveCheque ? 1 : 0);
            cmd.Parameters.AddWithValue("trade_report", account.tradeReportPhoto);
            cmd.Parameters.AddWithValue("national_id_photo", account.nationalIdPhoto);
            if (cmd.ExecuteNonQuery() != 0)
            {
                conn.Close();
                cmd.Dispose();
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.db
{
    public static class installmentsDB
    {
        public static model.installment getInstallmentWithAccountNumber(string account)
        {
            var conn = createConnection.openConnection();
            var qu = $"select * from personal_loan where account_id='{account}'";
            var cmd=new SqlCommand(qu, conn);   
            var reader=cmd.ExecuteReader();
            if (reader.Read())
            {
                string loan_id = (string)reader["loan_id"];
                conn.Close();
                reader.Close();
                cmd.Dispose();
                return getLastInstallment(loan_id);
            }

            return null;

        }
        public static model.installment getLastInstallment(string loan_id)
        {
            model.installment installment = new model.installment();   
            var con=createConnection.openConnection();
            var qu= $"SELECT TOP 1 * FROM installments where loan_id='{loan_id}'  order by installment_id DESC";
            var cmd = new SqlCommand(qu,con);
            var rader=cmd.ExecuteReader();
            if (rader.Read())
            {
                installment.loan_id = loan_id;
                installment.installment_id_next_period = (DateTime)rader["installment_date_next_period"];
                installment.installment_id_this_period = (DateTime)rader["installment_date_this_period"];
                installment.installment_value_with_benfit = (double)rader["installment_value_with_benfit"];
                rader.Close();
                cmd.Cancel();
                con.Close();
                return installment;
            }
            return null;

        }
    }
}

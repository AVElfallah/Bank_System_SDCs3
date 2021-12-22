using System.Collections.Generic;
using System.Data.SqlClient;

namespace Bank_System.db
{
    public class systemLogin
    {
        public bool login(string u_name, string password)
        {
            string sqlQu = $"select * from admin where u_name='{u_name}' and password='{password}'";
            var conn = createConnection.openConnection();
            SqlCommand sqlCommand = new SqlCommand(sqlQu, conn);
            if (sqlCommand.ExecuteReader().HasRows)
            {
                conn.Close();
                sqlCommand.Cancel();
                return true;
            }
            conn.Close();
            sqlCommand.Cancel();
            return false;


        }
        public List<string> loginAndBackData(string u_name, string password)
        {
            if (login(u_name, password))
            {
                string sqlQu = $"select * from admin where u_name='{u_name}' and password='{password}'";
                var conn = createConnection.openConnection();
                SqlCommand sqlCommand = new SqlCommand(sqlQu, conn);
                var reder = sqlCommand.ExecuteReader();
                if (reder.Read())
                {
                    var back = new List<string>();
                    back.Add(reder["a_name"].ToString());
                    back.Add(reder["a_role"].ToString());
                    conn.Close();
                    sqlCommand.Dispose();

                    return back;
                }
            }
            return null;

        }
    }
}

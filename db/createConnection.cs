using System.Data.SqlClient;

namespace Bank_System.db
{
    public static class createConnection
    {
        public static SqlConnection openConnection()
        {
            string path = "Server=(LocalDb)\\mangmentdb;Database=bank_system;Trusted_Connection=True;";
            SqlConnection conn = new SqlConnection(path);
            conn.Open();
            return conn;

        }
    }
}

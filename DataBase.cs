using System.Data.SqlClient;

namespace WindowsFormsAppDEMOPrepearing
{
    public class DataBase
    {
        SqlConnection connection = new SqlConnection(@"Data Source =UWU\SQLEXPRESS; Initial catalog = РемонтТехники; integrated security = true");
        public SqlConnection GetConnection() { return connection; }

        public void Open()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void Close()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}

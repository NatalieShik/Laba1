using System.Data.SqlClient;

namespace ClassLibraryDEMOPrepearing
{
    public static class Statistic
    {
        public static int ПолучитьКоличествоЗаявок(int кодСтатуса)
        {
            string sql = $"select count(кодСтатусаЗаявки) from ДеталиЗаявки where кодСтатусаЗаявки = {кодСтатуса}";
            using (var connection = AppState.db.GetConnection())
            {
                connection.Open();
                using (var cmd = new SqlCommand(sql, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetInt32(0);
                        }
                    }
                }
            }
            return 0;
        }
    }
}

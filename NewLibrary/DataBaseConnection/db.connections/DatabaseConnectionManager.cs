using System.Data.SQLite;
namespace NewLibrary.DataBaseConnection
{
    public class DatabaseConnectionManager
    {
        private DatabaseConnectionManager()
        {
        }

        private static string GetConnectionString()
        {
            return
                @"Data Source=C:\Users\nanan\Desktop\NewLibrary\NewLibrary\DataBaseConnection\library.sqlite";
        }

        public static SQLiteConnection GetSqlConnection()
        {
            return new(GetConnectionString(), true);
        }
    }
}
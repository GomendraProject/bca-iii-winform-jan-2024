using System.Data;
using MySqlConnector;

namespace BCA_III_jan_2024.Providers
{
    public class ConnectionProvider
    {
        public static IDbConnection GetConnection()
        {
            return new MySqlConnection("Server=localhost;database=bca_iii_test;Uid=root;Pwd=admin");
        }
    }
}
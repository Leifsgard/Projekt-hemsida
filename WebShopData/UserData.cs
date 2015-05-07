using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebShopData
{
    public static class UserData
    {
       public static int Load(SqlDataReader reader)
        {
            var userId = int.Parse(reader["UserID"].ToString());
            return userId;
        }
        public static int Authenticate(string username, string password)
        {
            var userId = -1;
            using (var conn = Connection.GetsqlConnection())
            {
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = @"SELECT [UserID], [Username], [Password] 
                                            FROM [ProjectWebStore].[dbo].[Users] 
                                            WHERE [Username] = @Username AND [Password] = @Password";

                    command.Parameters.Add("Username", SqlDbType.NVarChar).Value = username;
                    command.Parameters.Add("Password", SqlDbType.NVarChar).Value = password;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                        userId = Load(reader);
                }
            }
            return userId;
        }
    }
    public class Connection
    {
        public static string ConnectionString
        {
            get
            {
                var connectionString = ConfigurationManager.ConnectionStrings["ShopDB"].ToString();
                var newConnectionString = new SqlConnectionStringBuilder(connectionString);
                newConnectionString.ApplicationName = ApplicationName ?? newConnectionString.ApplicationName;
                newConnectionString.ConnectTimeout = (ConnectionTimeout > 0)
                    ? ConnectionTimeout
                    : newConnectionString.ConnectTimeout;
                return newConnectionString.ToString();
            }
        }
        public static int ConnectionTimeout { get; set; }
        public static string ApplicationName { get; set; }
        public static SqlConnection GetsqlConnection()
        {
            var connection = new SqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }
    }
}

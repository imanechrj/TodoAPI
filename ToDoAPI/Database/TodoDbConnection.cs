using System;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ToDoAPI.Database
{
    public class TodoDbConnection
    {
        private static SqlConnection _connection;

        
        private TodoDbConnection() { }

        
        public static SqlConnection GetInstance()
        {
            if (_connection == null)
                _connection = Connect();

            return _connection;
        }

        private static SqlConnection Connect()
        {
            try
            {
                var connectionString = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

                var connection = new SqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Connected to database.");

                return connection;
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("SQL Exception while connecting to DB : {0}", sqlEx.Message);
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error : {0}", ex.Message);
                throw;
            }
        }
    }
}

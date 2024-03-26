using System;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ToDoAPI.Database
{
	public class TodoDbConnection
	{
		private static SqlConnection _connection;

        private TodoDbConnection(){}

		public static SqlConnection GetInstance()
        {
            if (_connection == null)
            {
				_connection = new SqlConnection(@"Data Source = localhost\SQLEXPRESS; Initial Catalog = TodoList; Integrated Security = True; Encrypted = false");
				return _connection;
			}
			else
			{
				return _connection; 
			}

		}


    }
}


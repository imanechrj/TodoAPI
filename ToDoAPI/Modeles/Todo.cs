using System;
using System.Data.SqlClient;
using ToDoAPI.Database;

namespace ToDoAPI.Modeles
{
	public class Todo
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public string Title { get; set; }
		public bool IsDone { get; set; }

        public Todo(int id)
        {
            Id = id;
        }

        public int Create()
        {
            using(var db = TodoDbConnection.GetInstance())
            {
                var query = "INSERT INTO Todo (Date, Title, IsDone) VALUES(@Date, @IsDone);";

                SqlCommand command = new SqlCommand(query, db);
                command.Parameters.AddWithValue("@Date", DateTime.Now);
                command.Parameters.AddWithValue("@Title", Title);
                command.Parameters.AddWithValue("@IsDone", IsDone);

                return command.ExecuteNonQuery();
            }
        }
    }
}


using System;
namespace ToDoAPI.DTO.Response
{
	public class GetTodoByIdResponse
	{
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}


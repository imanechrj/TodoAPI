using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoAPI.DTO.Requests
{
	public class CreateTodoRequest
	{
		public string Title { get; set; }
	}
}


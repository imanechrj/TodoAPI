using System;
using FastEndpoints;
using ToDoAPI.DTO.Requests;
using ToDoAPI.DTO.Response;
using ToDoAPI.Modeles;

namespace ToDoAPI.Endpoints
{
	public class TodoGetEndpoint : Endpoint<GetTodoByIdRequest, GetTodoByIdResponse>
	{
        public override void Configure()
        {
            Get("/todos/{id}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(GetTodoByIdRequest request, CancellationToken ct)
        {
            Console.WriteLine("Id asked : {0}", request.Id);

            var todo = new GetTodoByIdResponse
            {
                Id = request.Id,
                Date = DateTime.Now,
                Title = "Faire les courses",
                IsDone = false
            };

            await SendAsync(todo);
        }
    }
}


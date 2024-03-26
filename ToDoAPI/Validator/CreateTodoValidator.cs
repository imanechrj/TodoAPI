using System;
using FastEndpoints;
using FluentValidation;
using ToDoAPI.DTO.Requests;

namespace ToDoAPI.Validator
{
	public class CreateTodoValidator : Validator<CreateTodoRequest>
	{
        public CreateTodoValidator()
		{
			RuleFor(x => x.Title)
				.NotEmpty()
				.WithMessage("Title is required")
				.MaximumLength(50)
				.WithMessage("Title must be less than 50 characters");
		}
	}
}


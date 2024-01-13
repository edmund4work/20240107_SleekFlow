using System;
using InterviewTestAPISleekFlow.Models;
using InterviewTestAPISleekFlow.Models.ViewModels;

namespace InterviewTestAPISleekFlow.Interfaces
{
	public interface ITodoService
    {
        List<Todo> GetAllTodos();

        Todo todoCRUD(todoVM todo);
    }
}


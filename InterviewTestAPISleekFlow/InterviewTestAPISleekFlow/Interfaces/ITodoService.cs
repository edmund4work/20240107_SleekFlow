using System;
using InterviewTestAPISleekFlow.Models;

namespace InterviewTestAPISleekFlow.Interfaces
{
	public interface ITodoService
    {
        Todo GetTodoById(int id);
        IEnumerable<Todo> GetAllTodos();
        Todo CreateTodo(Todo todo);
        Todo UpdateTodo(int id, Todo todo);
        void DeleteTodo(int id);
    }
}


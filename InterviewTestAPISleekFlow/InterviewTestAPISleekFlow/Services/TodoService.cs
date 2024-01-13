using System;
using InterviewTestAPISleekFlow.Interfaces;
using InterviewTestAPISleekFlow.Models;

namespace InterviewTestAPISleekFlow.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoService _todoService;

        public TodoService(ITodoService todoService)
        {
            _todoService = todoService;
        }

        public Todo CreateTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public void DeleteTodo(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Todo> GetAllTodos()
        {
            throw new NotImplementedException();
        }

        public Todo GetTodoById(int id)
        {
            throw new NotImplementedException();
        }

        public Todo UpdateTodo(int id, Todo todo)
        {
            throw new NotImplementedException();
        }

        // Implement the methods using business logic
    }
}


using System;
namespace InterviewTestAPISleekFlow.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public required int statusID { get; set; } //from commonStatus.cs

        public int priority { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime updatedDate { get; set; }
    }

}


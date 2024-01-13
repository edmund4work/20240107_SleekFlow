using System;
namespace InterviewTestAPISleekFlow.Models.ViewModels
{
	public class todoVM
	{
		public class todoDataRequest
		{
            public string action { get; set; }
            public Todo todoData { get; set; }
        }
        public class todoDataReturn
        {
        }
    }
}


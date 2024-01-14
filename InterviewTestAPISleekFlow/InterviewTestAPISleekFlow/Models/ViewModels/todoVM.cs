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
        public class todoDataRequest_Filter
        {
            public List<string> statusSelected { get; set; }
            public DateTime dateFrom { get; set; }
            public DateTime dateTo { get; set; }
        }
        public class todoDataReturn
        {
        }
    }
}


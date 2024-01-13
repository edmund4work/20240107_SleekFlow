using System;
using InterviewTestAPISleekFlow.common;
using InterviewTestAPISleekFlow.Interfaces;
using InterviewTestAPISleekFlow.Models;
using InterviewTestAPISleekFlow.Models.ViewModels;
using static InterviewTestAPISleekFlow.Models.ViewModels.todoVM;

namespace InterviewTestAPISleekFlow.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoService _todoService;

        public TodoService(ITodoService todoService)
        {
            _todoService = todoService;
        }

        public commonJsonReturn todoCRUD(todoDataRequest data)
        {
            commonJsonReturn dataCommonReturn = new commonJsonReturn();

            try
            {
                if (data != null)
                {
                    if (data.action == commonData.actionCodeCreate)
                    {

                    }
                    else if (data.action == commonData.actionCodeRead)
                    {

                    }
                    else if (data.action == commonData.actionCodeUpdate)
                    {

                    }
                    else if (data.action == commonData.actionCodeDelete)
                    {

                    }
                    else
                    {
                        dataCommonReturn = new commonJsonReturn
                        {
                            returnStatus = commonData.statusCodeFail,
                            returnMsg = "No Action Found",
                            returnDataObject = null,
                        };
                    }
                }
                else
                {
                    dataCommonReturn = new commonJsonReturn
                    {
                        returnStatus = commonData.statusCodeFail,
                        returnMsg = "Bad Request",
                        returnDataObject = null,
                    };
                }
            }
            catch (Exception ex)
            {
                dataCommonReturn = new commonJsonReturn
                {
                    returnStatus = commonData.statusCodeFail,
                    returnMsg = ex.Message,
                    returnDataObject = null,
                };
            }
            return dataCommonReturn;
        }

        public List<Todo> GetAllTodos()
        {
            throw new NotImplementedException();
        }

    }
}


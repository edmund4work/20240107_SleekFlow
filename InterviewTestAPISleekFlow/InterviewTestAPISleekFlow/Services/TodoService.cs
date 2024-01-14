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
                    if (data.action == commonData.actionCode.create)
                    {

                    }
                    else if (data.action == commonData.actionCode.read)
                    {

                    }
                    else if (data.action == commonData.actionCode.update)
                    {

                    }
                    else if (data.action == commonData.actionCode.delete)
                    {

                    }
                    else
                    {
                        dataCommonReturn = new commonJsonReturn
                        {
                            returnStatus = commonData.statusCode.fail,
                            returnMsg = "No Action Found",
                            returnDataObject = null,
                        };
                    }
                }
                else
                {
                    dataCommonReturn = new commonJsonReturn
                    {
                        returnStatus = commonData.statusCode.fail,
                        returnMsg = "Bad Request",
                        returnDataObject = null,
                    };
                }
            }
            catch (Exception ex)
            {
                dataCommonReturn = new commonJsonReturn
                {
                    returnStatus = commonData.statusCode.fail,
                    returnMsg = ex.Message,
                    returnDataObject = null,
                };
            }
            return dataCommonReturn;
        }

        public commonJsonReturn GetAllTodos(todoDataRequest_Filter data)
        {
            commonJsonReturn dataCommonReturn = new commonJsonReturn();


            return dataCommonReturn;
        }

    }
}


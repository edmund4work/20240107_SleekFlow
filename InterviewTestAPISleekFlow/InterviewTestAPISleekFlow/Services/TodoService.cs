using InterviewTestAPISleekFlow.common;
using InterviewTestAPISleekFlow.Database;
using InterviewTestAPISleekFlow.Interfaces;
using InterviewTestAPISleekFlow.Models;
using InterviewTestAPISleekFlow.Models.ViewModels;
using static InterviewTestAPISleekFlow.Models.ViewModels.todoVM;

namespace InterviewTestAPISleekFlow.Services
{
    public class TodoService : ITodoService
    {
        private readonly SleekFlowDBContext sql;
        public TodoService(SleekFlowDBContext _sql)
        {
            sql = _sql;
        }

        public commonJsonReturn todoCRUD(todoDataRequest data)
        {
            commonJsonReturn dataCommonReturn = defaultcommonJsonReturn();

            try
            {
                if (data != null && data.todoData != null)
                {
                    tblTodo todoDataRequest = data.todoData;
                    if (data.action == commonData.actionCode.create)
                    {
                        tblTodo todoDetail = new tblTodo
                        {
                            Name = todoDataRequest.Name,
                            priority = todoDataRequest.priority,

                            statusID = todoDataRequest.statusID,
                            Description = todoDataRequest.Description,
                            DueDate = todoDataRequest.DueDate,

                            enabled = true,
                            createdDate = DateTime.Now,
                            updatedDate = DateTime.Now,
                        };
                        sql.Add(todoDetail);
                        sql.SaveChanges();

                        dataCommonReturn = new commonJsonReturn
                        {
                            returnStatus = commonData.statusCode.success,
                            returnMsg = "Data Created",
                            returnDataObject = todoDetail,
                        };
                    }
                    else
                    {
                        if (data.todoData.Id != 0)
                        {
                            tblTodo todoDetail = returnTodoDetail(todoDataRequest.Id);
                            if (data.action == commonData.actionCode.read)
                            {
                                dataCommonReturn = new commonJsonReturn
                                {
                                    returnStatus = commonData.statusCode.success,
                                    returnMsg = "Data Found",
                                    returnDataObject = todoDetail,
                                };
                            }
                            else if (data.action == commonData.actionCode.update)
                            {
                                todoDetail.Name = todoDataRequest.Name;
                                todoDetail.priority = todoDataRequest.priority;

                                todoDetail.statusID = todoDataRequest.statusID;
                                todoDetail.Description = todoDataRequest.Description;
                                todoDetail.DueDate = todoDataRequest.DueDate;

                                todoDetail.updatedDate = DateTime.Now;
                                sql.SaveChanges();


                                dataCommonReturn = new commonJsonReturn
                                {
                                    returnStatus = commonData.statusCode.success,
                                    returnMsg = "Data Updated",
                                    returnDataObject = todoDetail,
                                };
                            }
                            else if (data.action == commonData.actionCode.delete)
                            {
                                todoDetail.enabled = false;
                                todoDetail.updatedDate = DateTime.Now;
                                sql.SaveChanges();

                                dataCommonReturn = new commonJsonReturn
                                {
                                    returnStatus = commonData.statusCode.success,
                                    returnMsg = "Data Deleted",
                                    returnDataObject = todoDetail,
                                };
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
                                returnMsg = "Data Incorrect",
                                returnDataObject = null,
                            };
                        }
                    }
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
            commonJsonReturn dataCommonReturn = defaultcommonJsonReturn();

            try
            {
                List<tblTodo> dataReturn
                = (from t1 in sql.tblTodo
                   where t1.Id == t1.Id
                   select new todoDataReturn
                   {

                   }).ToList();
            }
            catch(Exception ex)
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


        private tblTodo returnTodoDetail(int id)
        {
            tblTodo dataReturn
                = (from t1 in sql.tblTodo
                    where t1.Id == t1.Id
                   select t1)
                    .FirstOrDefault();

            return dataReturn;
        }
        private commonJsonReturn defaultcommonJsonReturn()
        {
            return new commonJsonReturn
            {
                returnStatus = commonData.statusCode.fail,
                returnMsg = "Bad Request",
                returnDataObject = null,
            };
        }
    }
}


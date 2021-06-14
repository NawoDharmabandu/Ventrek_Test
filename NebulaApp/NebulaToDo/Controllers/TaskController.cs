using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NebulaToDo.Models;
using NebulaToDo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NebulaToDo.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private NebulaDbContext _dbContext;

        static DateTime localDt = DateTime.UtcNow;
        static DateTime utcTime = localDt.ToUniversalTime();
        static TimeZoneInfo timeInfo = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        static DateTime dateToday = TimeZoneInfo.ConvertTimeFromUtc(utcTime, timeInfo);

        public TaskController(NebulaDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }
       
        [HttpGet("AllTasks")]
        public IEnumerable<TASK_DETAILS> Get()
        {
            try
            {
                return _dbContext.TASK_DETAIL.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("CreateTasks")]
        public TASK_DETAILS AddTasks([FromBody] TaskAddingView taskDetails)
        {
            try
            {
                if (taskDetails != null)
                {
                    var task = new TASK_DETAILS()
                    {
                        TASK_NAME = taskDetails.TaskName,
                        DUE_DATE = taskDetails.DueDate,
                        CREATED_BY = taskDetails.Creator,
                        CREATED_DATE = dateToday,
                        TASK_STATUS = 2,
                        DESCRIPTION = taskDetails.Description,
                        MODIFIED_DATE = dateToday,
                        MODIFIED_BY = ""
                    };

                    _dbContext.Add(task);
                    _dbContext.SaveChanges();
                    return task;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("CompletedTasks")]
        public ActionResult<List<TaskListView>> GetCompletedTasks(string userID)
        {
            try
            {
                List<TaskListView> taskList = new List<TaskListView>();

                var finishedTasks = (from t in _dbContext.TASK_DETAIL
                                     where t.TASK_STATUS == 3 && t.CREATED_BY == userID
                                     select new
                                     {
                                         t.TASK_ID,
                                         t.TASK_NAME,
                                         t.DUE_DATE,
                                         t.CREATED_DATE,
                                         t.DESCRIPTION
                                     }
                                    ).ToList();

                if (finishedTasks != null)
                {
                    foreach (var itm in finishedTasks)
                    {
                        TaskListView task = new TaskListView();
                        task.TaskID = itm.TASK_ID;
                        task.TaskName = itm.TASK_NAME;
                        task.DueDate = itm.DUE_DATE;
                        task.CreatedDate = itm.CREATED_DATE;
                        task.Description = itm.DESCRIPTION;

                        taskList.Add(task);
                    }

                    return taskList;
                }
                else
                {
                    return taskList;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("UnfinishedTasks")]
        public ActionResult<List<TaskListView>> GetUnfinishedTasks(string userID)
        {
            try
            {
                List<TaskListView> taskList = new List<TaskListView>();

                var finishedTasks = (from t in _dbContext.TASK_DETAIL
                                     where t.TASK_STATUS == 2 && t.CREATED_BY == userID
                                     select new
                                     {
                                         t.TASK_ID,
                                         t.TASK_NAME,
                                         t.DUE_DATE,
                                         t.CREATED_DATE,
                                         t.DESCRIPTION
                                     }
                                    ).ToList();

                if (finishedTasks != null)
                {
                    foreach (var itm in finishedTasks)
                    {
                        TaskListView task = new TaskListView();
                        task.TaskID = itm.TASK_ID;
                        task.TaskName = itm.TASK_NAME;
                        task.DueDate = itm.DUE_DATE;
                        task.CreatedDate = itm.CREATED_DATE;
                        task.Description = itm.DESCRIPTION;

                        taskList.Add(task);
                    }

                    return taskList;
                }
                else
                {
                    return taskList;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("UpdateCompleted")]
        public ActionResult<string> UpdateCompleted(int taskID, string userID)
            {
            try
            {
                var updateTask = _dbContext.TASK_DETAIL.FirstOrDefault(x => x.TASK_ID == taskID);

                updateTask.TASK_STATUS = 3;
                updateTask.MODIFIED_DATE = dateToday;
                updateTask.MODIFIED_BY = userID;

                _dbContext.Update(updateTask);
                _dbContext.SaveChanges();

                //handle this
                string message = "Task Updated as Complete Successfully.";
                return Ok(message);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("DeleteTask")]
        public void Delete(string taskID)
        {
            try
            {
                int task_ID = Convert.ToInt32(taskID);
                var deleteTask = _dbContext.TASK_DETAIL.FirstOrDefault(y => y.TASK_ID == task_ID);

                if (deleteTask != null)
                {
                    _dbContext.Remove(deleteTask);
                    _dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
           
        }

    }
}

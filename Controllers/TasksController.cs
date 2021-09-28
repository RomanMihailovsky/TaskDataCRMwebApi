using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TaskDataCRMwebApi.Models;
using CrmEarlyBound;


namespace TaskDataCRMwebApi.Controllers
{
    public class TasksController : ApiController
    {
        DataContextCRM dc = new DataContextCRM();
        
        [Route("api/task/{number}")]
        public IHttpActionResult GetTask(string number)
        {
            QueryExpression query = new QueryExpression
            {
                EntityName = new_task.EntityLogicalName,
                ColumnSet = new ColumnSet(true)
            };

            new_task newtask = dc.Service.RetrieveMultiple(query)
                .Entities
                .Select(e => e.ToEntity<new_task>())
                .Where(e => e.new_number == number)
                .FirstOrDefault();

            if (newtask == null)
            {
                return NotFound();
            }
            else
            {
                return Json(SetPropClassResp(newtask));
            }

        }

        public IHttpActionResult GetTask(DateTime enddate, bool completed)
        {
            QueryExpression query = new QueryExpression
            {
                EntityName = new_task.EntityLogicalName,
                ColumnSet = new ColumnSet(true)
            };

            IEnumerable<new_task> newtasks = dc.Service.RetrieveMultiple(query)
                  .Entities.Select(e => e.ToEntity<new_task>())
                  .Where(p => p.new_enddate < enddate);

            if (completed)
            {
                newtasks = newtasks.Where(p => p.new_completed == true);
            }
            else
            {
                newtasks = dc.Service.RetrieveMultiple(query).Entities.Select(e => e.ToEntity<new_task>());
            }

            List<TaskRespModel> taskrespmodellist = new List<TaskRespModel>();

            foreach (var newtask in newtasks)
            {
                taskrespmodellist.Add(SetPropClassResp(newtask));
            }

            return Json(taskrespmodellist);

        }

        private TaskRespModel SetPropClassResp(new_task newtask)
        {
            TaskRespModel taskresp = new TaskRespModel();

            taskresp.TaskId = newtask.new_taskId.ToString();
            taskresp.Name = newtask.new_name;
            taskresp.Number = newtask.new_number;
            taskresp.HoursSpend = newtask.new_hoursspend;
            taskresp.EndDate = newtask.new_enddate;
            taskresp.PersonResp = newtask.new_personresp.Name;
            taskresp.PersonInit = newtask.new_personinit.Name;
            taskresp.Completed = newtask.new_completed;

            taskresp.TypeTask = newtask.FormattedValues["new_type"];

            return taskresp;
        }

    }
}

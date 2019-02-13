using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Ninject;
using OrganizerApp.BllDtos.Tasks;
using OrganizerApp.DataCirculationHelpers;
using OrganizerApp.Helpers;

namespace OrganizerApp.WebUI.Helpers.Api.OrganizerApp.Tasks
{
    public class OrganizerAppTaskApiRequestHandler : IOrganizerAppTaskApiRequestHandler
    {
        private IApiRequestHandler _apiRequestHandler;


        public OrganizerAppTaskApiRequestHandler(IApiRequestHandler apiRequestHandler) 
        {
            _apiRequestHandler = apiRequestHandler;
        }


        public async Task<TaskDetail> GetTaskById(int id)
        {
            string getTaskByIdUri = ApiUriBuilder.GetTaskByIdUri.ToString();
            NameValueCollection parameters = new NameValueCollection()
            {
                { "id" , id.ToString() } ,
            };

            return await _apiRequestHandler.ExecuteGetAsync<TaskDetail>(getTaskByIdUri, parameters);
        }

        public async Task<IEnumerable<TaskBaseWithPriorityAndContext>> GetTasksHeadersWithPriority(string timeType = null, int? projectID = null, string searchPhrase = null, string date = null, TaskType tasksType = TaskType.All)
        {
            return await GetTasks<List<TaskBaseWithPriorityAndContext>>(timeType, projectID, searchPhrase , date , tasksType , TaskResponseDataSetType.HeaderWithPriorityAndContext);
        }

        public async Task SaveTask<T>(T objectToSerialize)
        {
            string saveTaskUri = ApiUriBuilder.SaveTaskUri.ToString();
            await _apiRequestHandler.ExecutePostAsync(saveTaskUri, objectToSerialize);
        }

        public async Task<List<TaskBaseWithPriorityAndContext>> SearchTasks(string searchPhrase)
        {
            return await GetTasks<List<TaskBaseWithPriorityAndContext>>(searchPhrase: searchPhrase , taskResponseType: TaskResponseDataSetType.HeaderWithPriorityAndContext);
        }

        public async Task Done(int id)
        {
            string doneTaskUri = ApiUriBuilder.DoneTaskUri.ToString();
            NameValueCollection parameters = new NameValueCollection()
            {
                { "id" , id.ToString() }
            };
            await _apiRequestHandler.ExecuteGetAsync(doneTaskUri, parameters);
        }

        public async Task Remove(int id)
        {
            string removeTaskUri = ApiUriBuilder.RemoveTaskUri.ToString();
            NameValueCollection parameters = new NameValueCollection()
            {
                { "id" , id.ToString() }
            };
            await _apiRequestHandler.ExecuteGetAsync(removeTaskUri, parameters);
        }

        private async Task<T> GetTasks<T>(string timeType = null , int? projectID = null , string searchPhrase = null , string date = null , TaskType tasksType = TaskType.All, TaskResponseDataSetType taskResponseType = TaskResponseDataSetType.Detail) where T : new()
        {
            string getTasksUri = ApiUriBuilder.GetTasksUri.ToString();
            NameValueCollection parameters = new NameValueCollection()
            {
                { "timeType" , timeType },
                { "projectID" ,  projectID?.ToString() },
                { "searchPhrase" , searchPhrase },
                { "date" , date },
                { "tasksType" , tasksType.GetEnumName() },
                { "responseDataSetType" , taskResponseType.GetEnumName() } ,
            };

            return await _apiRequestHandler.ExecuteGetAsync<T>(getTasksUri, parameters);
        }
    }
}
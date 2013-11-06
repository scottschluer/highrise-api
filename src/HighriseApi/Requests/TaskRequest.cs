using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighriseApi.Interfaces;
using HighriseApi.Models;
using RestSharp;
using RestSharp.Serializers;
using HighriseApi.Models.Enums;
using System.Net;
using HighriseApi.Serializers;

namespace HighriseApi.Requests
{
    public class TaskRequest : RequestBase, ITaskRequest
    {
        public TaskRequest(IRestClient client) : base(client) { }

        public IEnumerable<Task> Get(TaskStatus taskStatus)
        {
            var url = String.Format("tasks/{0}.xml", taskStatus.ToString().ToLower());
            var response = _client.Execute<List<Task>>(new RestRequest(url, Method.GET));
            var tasks = response.Data;            
            return tasks;
        }

        public IEnumerable<Task> Get(SubjectType subjectType, int subjectId)
        {
            var url = String.Format("{0}/{1}/tasks.xml", subjectType.ToString().ToLower(),subjectId);
            var response = _client.Execute<List<Task>>(new RestRequest(url, Method.GET));
            var tasks = response.Data;
            return tasks;
        }

        public Task Get(int id)
        {
            var response = _client.Execute<Task>(new RestRequest(String.Format("tasks/{0}.xml", id), Method.GET));
            var task = response.Data;
            return task;
        }

        public Task Create(Task task)
        {
            var request = new RestRequest("tasks.xml", Method.POST) { XmlSerializer = new XmlSerializer() { DateFormat = "yyyy-MM-ddTHH:mm:sszz" } };
            request.AddBody(task);

            var response = _client.Execute<Task>(request);
            return response.Data;
        }

        public Task Update(Task task)
        {
            var request = new RestRequest(String.Format("tasks/{0}.xml?reload=true", task.Id), Method.PUT) { XmlSerializer = new XmlIgnoreSerializer() };
            request.AddBody(task);

            var response = _client.Execute<Task>(request);
            return response.Data;
        }

        public Task Complete(int id)
        {
            var response = _client.Execute<Task>(new RestRequest(String.Format("tasks/{0}/complete.xml", id), Method.POST));
            var task = response.Data;
            return task;
        }

        public bool Delete(int id)
        {
            var response = _client.Execute<Deal>(new RestRequest(String.Format("tasks/{0}.xml", id), Method.DELETE));
            return response.StatusCode == HttpStatusCode.OK;
        }
    }
}

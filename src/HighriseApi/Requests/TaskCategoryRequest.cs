using HighriseApi.Interfaces;
using HighriseApi.Models;
using HighriseApi.Serializers;
using RestSharp;
using System;
using System.Linq;
using System.Net;
using System.Collections.Generic;

namespace HighriseApi.Requests
{
    public class TaskCategoryRequest : RequestBase, ITaskCategoryRequest
    {
        public TaskCategoryRequest(IRestClient client) : base(client) { }

        public TaskCategory Get(int id)
        {
            var response = _client.Execute<TaskCategory>(new RestRequest(String.Format("task_categories/{0}.xml", id), Method.GET));
            var TaskCategory = response.Data;
            return TaskCategory;
        }

        public IEnumerable<TaskCategory> Get()
        {
            var response = _client.Execute<List<TaskCategory>>(new RestRequest("task_categories.xml", Method.GET));
            return response.Data;
        }

        public TaskCategory Create(TaskCategory category)
        {
            var request = new RestRequest("task_categories.xml", Method.POST) { XmlSerializer = new XmlIgnoreSerializer() };
            request.AddBody(category);

            var response = _client.Execute<TaskCategory>(request);
            return response.Data;
        }

        public bool Update(TaskCategory category)
        {
            var request = new RestRequest(String.Format("task_categories/{0}.xml", category.Id), Method.PUT) { XmlSerializer = new XmlIgnoreSerializer() };
            request.AddBody(category);

            var response = _client.Execute<TaskCategory>(request);
            return response.StatusCode == HttpStatusCode.OK;
        }

        public bool Delete(int id)
        {
            var response = _client.Execute<Deal>(new RestRequest(String.Format("task_categories/{0}.xml", id), Method.DELETE));
            return response.StatusCode == HttpStatusCode.OK;
        }
    }
}

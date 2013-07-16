using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighriseApi.Interfaces;
using HighriseApi.Models;
using RestSharp;
using RestSharp.Serializers;

namespace HighriseApi.Requests
{
    public class TaskRequest : RequestBase, ITaskRequest
    {
        public TaskRequest(IRestClient client) : base(client) { }

        public Task Create(Task task)
        {
            var request = new RestRequest("tasks.xml", Method.POST) { XmlSerializer = new XmlSerializer() { DateFormat = "yyyy-MM-ddTHH:mm:sszz" } };
            request.AddBody(task);

            var response = _client.Execute<Task>(request);
            return response.Data;
        }
    }
}

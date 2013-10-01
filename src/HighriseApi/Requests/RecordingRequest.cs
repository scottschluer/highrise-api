using HighriseApi.Interfaces;
using HighriseApi.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighriseApi.Requests
{
    public class RecordingRequest : RequestBase,IRecordingRequest
    {
        public RecordingRequest(IRestClient client) : base(client) { }

        public IEnumerable<Recording> Get()
        {
            var response = _client.Execute<List<Recording>>(new RestRequest("recordings.xml", Method.GET));
            return response.Data;
        }

        public IEnumerable<Recording> Get(DateTime startDate)
        {
            var url = String.Format("recordings.xml?since={0}", startDate.ToString("yyyyMMddHHmmss"));
            var response = _client.Execute<List<Recording>>(new RestRequest(url, Method.GET));
            return response.Data;
        }
    }
}

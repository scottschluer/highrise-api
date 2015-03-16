using System;
using System.Collections.Generic;
using System.Net;
using HighriseApi.ExtensionMethods;
using HighriseApi.Interfaces;
using RestSharp;
using RestSharp.Serializers;

namespace HighriseApi.Requests
{
    public class EmailRequest : RequestBase, IEmailRequest
    {
        public EmailRequest(IRestClient client) : base(client) { }

        public IEnumerable<Email> Get(int? offset = null)
        {
            var url = String.Format("/people/185835413/emails.xml");

            var response = _client.Execute<List<Email>>(new RestRequest(url, Method.GET));
            return response.Data; ;
        }

        public IEnumerable<Email> Get(DateTime startDate, int? offset = null)
        {
            throw new NotImplementedException();
        }
    }
}

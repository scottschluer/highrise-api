using System;
using System.Collections.Generic;
using System.Net;
using HighriseApi.Interfaces;
using HighriseApi.Models;
using HighriseApi.Models.Enums;
using HighriseApi.Serializers;
using RestSharp;
using RestSharp.Serializers;

namespace HighriseApi.Requests
{
    public class EmailRequest : RequestBase, IEmailRequest
    {
        public EmailRequest(IRestClient client) : base(client) { }

        public Email Create(SubjectType subjectType, int subjectId, Email email)
        {
            var request = new RestRequest(String.Format("{0}/{1}/emails.xml",
                subjectType.ToString().ToLower(), subjectId), Method.POST)
            { XmlSerializer = new XmlSerializer() };
            request.AddBody(email);

            var response = _client.Execute<Email>(request);
            return response.Data;
        }

        public bool Delete(int id)
        {
            var response = _client.Execute<Note>(new RestRequest(String.Format("emails/{0}.xml", id), Method.DELETE));
            return response.StatusCode == HttpStatusCode.OK;
        }

        public Email Get(int id)
        {
            var response = _client.Execute<Email>(new RestRequest(String.Format("/emails/{0}.xml", id), Method.GET));
            var email = response.Data;
            return email;
        }

        public IEnumerable<Email> Get(SubjectType subjectType, int subjectId, int? offset = null)
        {
            var url = offset.HasValue
                         ? String.Format("/{0}/{1}/emails.xml?n={2}", subjectType.ToString().ToLower(), subjectId, offset.Value)
                         : String.Format("/{0}/{1}/emails.xml", subjectType.ToString().ToLower(), subjectId);

            var response = _client.Execute<List<Email>>(new RestRequest(url, Method.GET));
            var results = response.Data;
            return results;
        }

        public IEnumerable<Email> Get(SubjectType subjectType, int subjectId, DateTime since, int? offset = null)
        {
            var url = offset.HasValue
                         ? String.Format("/{0}/{1}/emails.xml?since={2}&n={3}", subjectType.ToString().ToLower(), subjectId, since, offset.Value)
                         : String.Format("/{0}/{1}/emails.xml?since={2}", subjectType.ToString().ToLower(), subjectId, since);

            var response = _client.Execute<List<Email>>(new RestRequest(url, Method.GET));
            var results = response.Data;
            return results;
        }

        public IEnumerable<Comment> GetComments(int id)
        {
            var response = _client.Execute<List<Comment>>(new RestRequest(String.Format("/emails/{0}/comments.xml", id), Method.GET));
            var commentsForNote = response.Data;
            return commentsForNote;
        }

        public bool Update(Email email)
        {
            var request = new RestRequest(String.Format("emails/{0}.xml", email.Id), Method.PUT) { XmlSerializer = new XmlIgnoreSerializer() };
            request.AddBody(email);

            var response = _client.Execute<Email>(request);
            return response.StatusCode == HttpStatusCode.OK;
        }
    }
}

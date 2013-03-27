using System;
using System.Collections.Generic;
using System.Net;
using HighriseApi.Interfaces;
using HighriseApi.Models;
using HighriseApi.Models.Enums;
using HighriseApi.Utilities;
using RestSharp;
using RestSharp.Serializers;

namespace HighriseApi.Requests
{
    public class TagRequest : RequestBase, ITagRequest
    {
        public TagRequest(IRestClient client) : base(client) { }

        public IEnumerable<Tag> Get()
        {
            var response = _client.Execute<List<Tag>>(new RestRequest("tags.xml", Method.GET));
            return response.Data;
        }

        public IEnumerable<Tag> Get(SubjectType subjectType, int subjectId)
        {
            var response = _client.Execute<List<Tag>>(new RestRequest(String.Format("{0}/{1}/tags.xml", subjectType.ToString().ToLower(), subjectId), Method.GET));
            return response.Data;
        }

        public Parties Parties(int tagId)
        {
            var response = _client.Execute(new RestRequest(String.Format("tags/{0}.xml", tagId), Method.GET));
            return PartyConverter.Convert(response.Content);
        }

        public Tag Create(SubjectType subjectType, int subjectId, Tag tag)
        {
            var request = new RestRequest(String.Format("{0}/{1}/tags.xml",
                subjectType.ToString().ToLower(), subjectId), Method.POST) { XmlSerializer = new XmlSerializer() };

            request.AddParameter("name", tag.Name);

            var response = _client.Execute<Tag>(request);
            return response.Data;
        }

        public bool Delete(SubjectType subjectType, int subjectId, int tagId)
        {
            var response = _client.Execute<Tag>(new RestRequest(String.Format("{0}/{1}/tags/{2}.xml", 
                subjectType.ToString().ToLower(), subjectId, tagId), Method.DELETE));

            return response.StatusCode == HttpStatusCode.OK;
        }
    }
}

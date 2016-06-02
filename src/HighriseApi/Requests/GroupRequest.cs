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
    public class GroupRequest : RequestBase, IGroupRequest
    {
        public GroupRequest(IRestClient client) : base(client) { }

        public IEnumerable<Group> Get()
        {

            var response = _client.Execute<List<Group>>(new RestRequest("groups.xml", Method.GET));
            var groups = response.Data;

            return groups;
        }

        public Group Get(int id)
        {
            var response = _client.Execute<Group>(new RestRequest(String.Format("groups/{0}.xml", id), Method.GET));
            var group = response.Data;

            return group;
        }

        public Group Create(Group group)
        {
            var request = new RestRequest("groups.xml", Method.POST) { XmlSerializer = new XmlIgnoreSerializer() };
            request.AddBody(group);

            var response = _client.Execute<Group>(request);
            return response.Data;
        }

        public bool Update(Group group)
        {
            var request = new RestRequest(String.Format("groups/{0}.xml", group.Id), Method.PUT) { XmlSerializer = new XmlIgnoreSerializer() };
            request.AddBody(group);

            var response = _client.Execute<Group>(request);
            return response.StatusCode == HttpStatusCode.OK;
        }

        public bool Delete(int id)
        {
            var response = _client.Execute<Group>(new RestRequest(String.Format("groups/{0}.xml", id), Method.DELETE));
            return response.StatusCode == HttpStatusCode.OK;
        }

    }
}

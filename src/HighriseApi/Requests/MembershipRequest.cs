using System;
using System.Collections.Generic;
using System.Net;
using HighriseApi.Interfaces;
using HighriseApi.Serializers;
using RestSharp;

namespace HighriseApi.Requests
{
    public class MembershipRequest : RequestBase, IMembershipRequest
    {
        public MembershipRequest(IRestClient client) : base(client) { }


        public IEnumerable<Membership> Get()
        {

            var response = _client.Execute<List<Membership>>(new RestRequest("memberships.xml", Method.GET));
            var memberships = response.Data;

            return memberships;
        }

        public Membership Get(int id)
        {
            var response = _client.Execute<Membership>(new RestRequest(String.Format("memberships/{0}.xml", id), Method.GET));
            var membership = response.Data;

            return membership;
        }

        public Membership Create(Membership membership)
        {
            var request = new RestRequest("memberships.xml", Method.POST) { XmlSerializer = new XmlIgnoreSerializer() };
            request.AddBody(membership);

            var response = _client.Execute<Membership>(request);
            return response.Data;
        }

        public bool Delete(int id)
        {
            var response = _client.Execute<Membership>(new RestRequest(String.Format("memberships/{0}.xml", id), Method.DELETE));
            return response.StatusCode == HttpStatusCode.OK;
        }


    }
}

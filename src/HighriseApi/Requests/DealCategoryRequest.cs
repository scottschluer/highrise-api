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
    public class DealCategoryRequest : RequestBase, IDealCategoryRequest
    {
        public DealCategoryRequest(IRestClient client) : base(client) { }

        public DealCategory Get(int id)
        {
            var response = _client.Execute<DealCategory>(new RestRequest(String.Format("deal_categories/{0}.xml", id), Method.GET));
            var dealCategory = response.Data;
            return dealCategory;
        }

        public IEnumerable<DealCategory> Get()
        {
            var response = _client.Execute<List<DealCategory>>(new RestRequest("deal_categories.xml", Method.GET));
            return response.Data;
        }

        public DealCategory Create(DealCategory category)
        {
            var request = new RestRequest("deal_categories.xml", Method.POST) { XmlSerializer = new XmlIgnoreSerializer() };
            request.AddBody(category);

            var response = _client.Execute<DealCategory>(request);
            return response.Data;
        }

        public bool Update(DealCategory category)
        {
            var request = new RestRequest(String.Format("deal_categories/{0}.xml", category.Id), Method.PUT) { XmlSerializer = new XmlIgnoreSerializer() };
            request.AddBody(category);

            var response = _client.Execute<DealCategory>(request);
            return response.StatusCode == HttpStatusCode.OK;
        }

        public bool Delete(int id)
        {
            var response = _client.Execute<Deal>(new RestRequest(String.Format("deal_categories/{0}.xml", id), Method.DELETE));
            return response.StatusCode == HttpStatusCode.OK;
        }
    }
}

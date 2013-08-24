using System;
using System.Collections.Generic;
using System.Net;
using HighriseApi.Interfaces;
using HighriseApi.Models;
using HighriseApi.Models.Enums;
using HighriseApi.Serializers;
using RestSharp;

namespace HighriseApi.Requests
{
    public class DealRequest : RequestBase, IDealRequest
    {
        public DealRequest(IRestClient client) : base(client) { }

        public Deal Get(int id)
        {
            var response = _client.Execute<Deal>(new RestRequest(String.Format("deals/{0}.xml", id), Method.GET));
            var deal = response.Data;

            if (deal == null) return null;
            deal.LoadParties(response.Content);

            return deal;
        }

        public IEnumerable<Deal> Get(DealStatus dealStatus)
        {
            var url = "deals.xml?status=" + dealStatus.ToString().ToLower();
            var response = _client.Execute<List<Deal>>(new RestRequest(url, Method.GET));
            var deals = response.Data;

            foreach (var deal in deals)
                deal.LoadParties(response.Content);

            return deals;
        }

        public Deal Create(Deal deal)
        {
            var request = new RestRequest("deals.xml", Method.POST) { XmlSerializer = new XmlIgnoreSerializer() };
            request.AddBody(deal);

            var response = _client.Execute<Deal>(request);
            return response.Data;
        }

        public bool Update(Deal deal)
        {
            var request = new RestRequest("deals/{id}.xml", Method.PUT) { XmlSerializer = new XmlIgnoreSerializer() };
            request.AddParameter("id", deal.Id, ParameterType.UrlSegment);
            request.AddBody(deal);

            var response = _client.Execute<Deal>(request);
            return response.StatusCode == HttpStatusCode.OK;
        }

        public bool Delete(int id)
        {
            var response = _client.Execute<Deal>(new RestRequest(String.Format("deals/{0}.xml", id), Method.DELETE));
            return response.StatusCode == HttpStatusCode.OK;
        }
        

        // TODO: Implement
        public bool UpdateStatus(int id, DealStatus dealStatus)
        {
            throw new NotImplementedException();
        }
    }
}

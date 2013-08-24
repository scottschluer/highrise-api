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

        public IEnumerable<Deal> Get(int? offset = null)
        {
            var url = offset.HasValue
                          ? String.Format("deals.xml?n={0}", offset.Value)
                          : "deals.xml";

            var response = _client.Execute<List<Deal>>(new RestRequest(url, Method.GET));
            var deals = response.Data;

            foreach (var deal in deals)
                deal.LoadParties(response.Content);

            return deals;
        }

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

        public IEnumerable<Deal> Get(DateTime startDate)
        {
            var url = String.Format("deals.xml?since={0}", startDate.ToString("yyyyMMddHHmmss"));

            var response = _client.Execute<List<Deal>>(new RestRequest(url, Method.GET));
            return response.Data;
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
            var request = new RestRequest(String.Format("deals/{0}.xml", deal.Id), Method.PUT) { XmlSerializer = new XmlIgnoreSerializer() };
            request.AddBody(deal);

            var response = _client.Execute<Deal>(request);
            return response.StatusCode == HttpStatusCode.OK;
        }

        public bool Delete(int id)
        {
            var response = _client.Execute<Deal>(new RestRequest(String.Format("deals/{0}.xml", id), Method.DELETE));
            return response.StatusCode == HttpStatusCode.OK;
        }
        
        public bool UpdateStatus(int id, DealStatus dealStatus)
        {
            var request = new RestRequest(String.Format("deals/{0}/status.xml", id), Method.PUT) { XmlSerializer = new XmlIgnoreSerializer() };
            request.AddParameter("text/xml", String.Format("<status><name>{0}</name></status>", dealStatus.ToString().ToLower()), ParameterType.RequestBody);

            var response = _client.Execute(request);
            return response.StatusCode == HttpStatusCode.OK;
        }
    }
}

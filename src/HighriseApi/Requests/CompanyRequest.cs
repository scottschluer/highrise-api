using System;
using System.Collections.Generic;
using System.Net;
using HighriseApi.ExtensionMethods;
using HighriseApi.Interfaces;
using HighriseApi.Models;
using RestSharp;
using RestSharp.Serializers;

namespace HighriseApi.Requests
{
    public class CompanyRequest : ICompanyRequest
    {
        private readonly IRestClient _client;

        public CompanyRequest(IRestClient client)
        {
            _client = client;
        }

        public IEnumerable<Company> Get(int? offset = null)
        {
            var url = offset.HasValue
                          ? String.Format("companies.xml?n={0}", offset.Value)
                          : "companies.xml";

            var response = _client.Execute<List<Company>>(new RestRequest(url, Method.GET));
            return response.Data;
        }

        public Company Get(int id)
        {
            var response = _client.Execute<Company>(new RestRequest(String.Format("companies/{0}.xml", id), Method.GET));
            return response.Data;
        }

        public Company Create(Company company)
        {
            var request = new RestRequest("companies.xml", Method.POST) { XmlSerializer = new XmlSerializer() };
            request.AddBody(company);

            var response = _client.Execute<Company>(request);
            return response.Data;
        }

        public Company Update(Company company)
        {
            var request = new RestRequest("companies/{id}.xml?reload=true", Method.PUT) { XmlSerializer = new XmlSerializer() };
            request.AddParameter("id", company.Id, ParameterType.UrlSegment);
            request.AddBody(company);

            var response = _client.Execute<Company>(request);
            return response.Data;
        }

        public bool Delete(int id)
        {
            var response = _client.Execute<Company>(new RestRequest(String.Format("companies/{0}.xml", id), Method.DELETE));
            return response.StatusCode == HttpStatusCode.OK;
        }

        public IEnumerable<Company> Search(string name, int? offset = null)
        {
            if (String.IsNullOrEmpty(name)) return Get(offset);

            var url = offset.HasValue
                          ? String.Format("companies/search.xml?term={0}&n={1}", name, offset.Value)
                          : String.Format("companies/search.xml?term={0}", name);

            var response = _client.Execute<List<Company>>(new RestRequest(url, Method.GET));
            return response.Data;
        }

        public IEnumerable<Company> Search(IDictionary<string, string> values, int? offset = null)
        {
            if (values == null || values.Count == 0) return Get(offset);

            var url = offset.HasValue
                ? String.Format("companies/search.xml?n={0}&{1}", offset.Value, string.Join("&", values))
                : String.Format("companies/search.xml?{0}", values.ToSearchQueryString());


            var response = _client.Execute<List<Company>>(new RestRequest(url, Method.GET));
            return response.Data;
        }
    }
}

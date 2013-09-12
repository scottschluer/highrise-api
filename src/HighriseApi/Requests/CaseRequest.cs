﻿using System;
using System.Collections.Generic;
using System.Net;
using HighriseApi.Interfaces;
using HighriseApi.Models;
using HighriseApi.Models.Enums;
using HighriseApi.Serializers;
using RestSharp;

namespace HighriseApi.Requests
{
    public class CaseRequest : RequestBase, ICaseRequest
    {
        public CaseRequest(IRestClient client) : base(client) { }

        public Kase Get(int id)
        {
            var response = _client.Execute<Kase>(new RestRequest(String.Format("kases/{0}.xml", id), Method.GET));
            var kase = response.Data;

            if (kase == null) return null;
            kase.LoadParties(response.Content);

            return kase;
        }

        public IEnumerable<Kase> Get(CaseStatus caseStatus)
        {
            var url = caseStatus == CaseStatus.Open ? "kases/open.xml" : "kases/closed.xml";
            var response = _client.Execute<List<Kase>>(new RestRequest(url, Method.GET));
            var kases = response.Data;

            foreach (var kase in kases)
                kase.LoadParties(response.Content);

            return kases;
        }

        public Kase Create(Kase kase)
        {
            var request = new RestRequest("kases.xml", Method.POST) { XmlSerializer = new XmlIgnoreSerializer() };
            request.AddBody(kase);

            var response = _client.Execute<Kase>(request);
            return response.Data;
        }

        public bool Update(Kase kase)
        {
            var request = new RestRequest("kases/{id}.xml", Method.PUT) { XmlSerializer = new XmlIgnoreSerializer() };
            request.AddParameter("id", kase.Id, ParameterType.UrlSegment);
            request.AddBody(kase);

            var response = _client.Execute<Kase>(request);
            return response.StatusCode == HttpStatusCode.OK;
        }

        public bool Delete(int id)
        {
            var response = _client.Execute<Kase>(new RestRequest(String.Format("kases/{0}.xml", id), Method.DELETE));
            return response.StatusCode == HttpStatusCode.OK;
        }
    }
}

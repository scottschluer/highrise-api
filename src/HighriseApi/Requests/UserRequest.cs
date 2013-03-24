using System;
using System.Collections.Generic;
using HighriseApi.Interfaces;
using HighriseApi.Models;
using RestSharp;

namespace HighriseApi.Requests
{
    public class UserRequest : IUserRequest
    {
        private readonly IRestClient _client;

        public UserRequest(IRestClient client)
        {
            _client = client;
        }

        public User Me()
        {
            var response = _client.Execute<User>(new RestRequest("me.xml", Method.GET));
            return response.Data;
        }

        public User Get(int id)
        {
            var response = _client.Execute<User>(new RestRequest(String.Format("users/{0}.xml", id), Method.GET));
            return response.Data;
        }

        public IEnumerable<User> Get()
        {
            var response = _client.Execute<List<User>>(new RestRequest("users.xml", Method.GET));
            return response.Data;
        }
    }
}

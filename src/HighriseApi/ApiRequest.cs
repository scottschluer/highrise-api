using System;
using HighriseApi.Requests;
using RestSharp;

namespace HighriseApi
{
    public class ApiRequest
    {
        private readonly string _username;
        private readonly string _authenticationToken;
        private readonly IRestClient _client;

        public PersonRequest PersonRequest
        {
            get { return new PersonRequest(_client); }
        }
        
        public ApiRequest(string username, string authenticationToken)
        {
            _username = username;
            _authenticationToken = authenticationToken;
            _client = new RestClient
                {
                    BaseUrl = String.Format("https://{0}.highrisehq.com", _username),
                    Authenticator = new HttpBasicAuthenticator(_authenticationToken, "X")
                };
        }
    }
}

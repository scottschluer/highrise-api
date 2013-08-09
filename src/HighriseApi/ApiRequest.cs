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

        public AccountRequest AccountRequest { get { return new AccountRequest(_client); } }
        public CaseRequest CaseRequest { get { return new CaseRequest(_client); } }
        public CompanyRequest CompanyRequest { get { return new CompanyRequest(_client); } }
        public PersonRequest PersonRequest { get { return new PersonRequest(_client); } }
        public TagRequest TagRequest { get { return new TagRequest(_client); } }
        public UserRequest UserRequest { get { return new UserRequest(_client); } }
        public TaskRequest TaskRequest { get { return new TaskRequest(_client); } }
        
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

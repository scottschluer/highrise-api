using HighriseApi.Interfaces;
using HighriseApi.Models;
using RestSharp;

namespace HighriseApi.Requests
{
    public class AccountRequest : IAccountRequest
    {
        private readonly IRestClient _client;

        public AccountRequest(IRestClient client)
        {
            _client = client;
        }

        public Account Get()
        {
            var response = _client.Execute<Account>(new RestRequest("account.xml", Method.GET));
            return response.Data;
        }
    }
}

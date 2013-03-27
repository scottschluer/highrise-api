using HighriseApi.Interfaces;
using HighriseApi.Models;
using RestSharp;

namespace HighriseApi.Requests
{
    public class AccountRequest : RequestBase, IAccountRequest
    {
        public AccountRequest(IRestClient client) : base(client) { }

        public Account Get()
        {
            var response = _client.Execute<Account>(new RestRequest("account.xml", Method.GET));
            return response.Data;
        }
    }
}

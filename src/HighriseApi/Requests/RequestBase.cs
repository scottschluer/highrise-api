using RestSharp;
using System.Net;

namespace HighriseApi.Requests
{
    public class RequestBase
    {
        protected readonly IRestClient _client;

        public RequestBase() 
        {
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, sslPolicyErrors) => true;
        }

        public RequestBase(IRestClient client)
        {
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, sslPolicyErrors) => true;
            _client = client;
        }
    }
}

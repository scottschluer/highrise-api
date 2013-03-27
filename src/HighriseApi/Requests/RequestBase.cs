using RestSharp;

namespace HighriseApi.Requests
{
    public class RequestBase
    {
        protected readonly IRestClient _client;

        public RequestBase() {}

        public RequestBase(IRestClient client)
        {
            _client = client;
        }
    }
}

using RestSharp.Serializers;

namespace HighriseApi
{
    [SerializeAs(Name = "web-address")]
    public class WebAddress
    {
        [SerializeAs(Name = "id")]
        public int? Id { get; set; }

        [SerializeAs(Name = "location")]
        public string Location { get; set; }

        [SerializeAs(Name = "url")]
        public string Url { get; set; }
    }
}

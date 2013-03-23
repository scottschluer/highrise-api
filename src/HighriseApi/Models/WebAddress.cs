using HighriseApi.Models;
using RestSharp.Serializers;

namespace HighriseApi
{
    [SerializeAs(Name = "web-address")]
    public class WebAddress : BaseModel
    {
        [SerializeAs(Name = "location")]
        public string Location { get; set; }

        [SerializeAs(Name = "url")]
        public string Url { get; set; }
    }
}

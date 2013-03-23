using HighriseApi.Models;
using RestSharp.Serializers;

namespace HighriseApi
{
    [SerializeAs(Name = "twitter-account")]
    public class TwitterAccount : BaseModel
    {
        [SerializeAs(Name = "location")]
        public string Location { get; set; }

        [SerializeAs(Name = "username")]
        public string Username { get; set; }

        [SerializeAs(Name = "url")]
        public string Url { get; set; }
    }
}

using RestSharp.Serializers;

namespace HighriseApi
{
    [SerializeAs(Name = "twitter-account")]
    public class TwitterAccount
    {
        [SerializeAs(Name = "id")]
        public int? Id { get; set; }

        [SerializeAs(Name = "location")]
        public string Location { get; set; }

        [SerializeAs(Name = "username")]
        public string Username { get; set; }

        [SerializeAs(Name = "url")]
        public string Url { get; set; }
    }
}

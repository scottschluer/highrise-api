using HighriseApi.Models;
using RestSharp.Serializers;

namespace HighriseApi
{
    [SerializeAs(Name = "instant-messenger")]
    public class InstantMessenger : BaseModel
    {
        [SerializeAs(Name = "location")]
        public string Location { get; set; }

        [SerializeAs(Name = "protocol")]
        public string Protocol { get; set; }

        [SerializeAs(Name = "address")]
        public string Address { get; set; }
    }
}

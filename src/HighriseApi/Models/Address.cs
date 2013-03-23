using HighriseApi.Models;
using RestSharp.Serializers;

namespace HighriseApi
{
    [SerializeAs(Name = "address")]
    public class Address : BaseModel
    {
        [SerializeAs(Name = "location")]
        public string Location { get; set; }

        [SerializeAs(Name = "street")]
        public string Street { get; set; }

        [SerializeAs(Name = "city")]
        public string City { get; set; }

        [SerializeAs(Name = "state")]
        public string State { get; set; }

        [SerializeAs(Name = "zip")]
        public string Zip { get; set; }

        [SerializeAs(Name = "country")]
        public string Country { get; set; }
    }
}

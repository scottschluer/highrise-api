using RestSharp.Serializers;

namespace HighriseApi
{
    [SerializeAs(Name = "email-address")]
    public class EmailAddress
    {
        [SerializeAs(Name = "id")]
        public int? Id { get; set; }

        [SerializeAs(Name = "address")]
        public string Address { get; set; }

        [SerializeAs(Name = "location")]
        public string Location { get; set; }
    }
}

using RestSharp.Serializers;

namespace HighriseApi
{
    [SerializeAs(Name = "phone-number")]
    public class PhoneNumber
    {
        [SerializeAs(Name = "id")]
        public int? Id { get; set; }

        [SerializeAs(Name = "location")]
        public string Location { get; set; }

        [SerializeAs(Name = "number")]
        public string Number { get; set; }
    }
}

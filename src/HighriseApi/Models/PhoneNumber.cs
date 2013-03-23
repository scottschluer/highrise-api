using HighriseApi.Models;
using RestSharp.Serializers;

namespace HighriseApi
{
    [SerializeAs(Name = "phone-number")]
    public class PhoneNumber : BaseModel
    {
        [SerializeAs(Name = "location")]
        public string Location { get; set; }

        [SerializeAs(Name = "number")]
        public string Number { get; set; }
    }
}

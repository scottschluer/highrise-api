using HighriseApi.Models;
using RestSharp.Serializers;

namespace HighriseApi
{
    [SerializeAs(Name = "email-address")]
    public class EmailAddress : BaseModel
    {
        [SerializeAs(Name = "address")]
        public string Address { get; set; }

        [SerializeAs(Name = "location")]
        public string Location { get; set; }
    }
}

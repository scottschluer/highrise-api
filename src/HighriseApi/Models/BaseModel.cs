using RestSharp.Serializers;

namespace HighriseApi.Models
{
    public class BaseModel
    {
        [SerializeAs(Name = "id")]
        public int Id { get; set; }
    }
}

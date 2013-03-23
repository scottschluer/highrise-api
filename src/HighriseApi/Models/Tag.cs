using RestSharp.Serializers;

namespace HighriseApi.Models
{
    [SerializeAs(Name = "tag")]
    public class Tag
    {
        [SerializeAs(Name = "id")]
        public int? Id { get; set; }

        [SerializeAs(Name = "name")]
        public string Name { get; set; }
    }
}

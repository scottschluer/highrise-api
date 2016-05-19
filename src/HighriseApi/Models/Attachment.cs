using RestSharp.Serializers;

namespace HighriseApi.Models
{
    [SerializeAs(Name = "attachment")]
    public class Attachment : BaseModel
    {

        [SerializeAs(Name = "url")]
        public string Url { get; set; }

        [SerializeAs(Name = "name")]
        public string Name { get; set; }

        [SerializeAs(Name = "size")]
        public int Size { get; set; }
    }
}

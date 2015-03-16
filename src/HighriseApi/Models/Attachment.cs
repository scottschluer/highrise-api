using System;
using RestSharp.Serializers;

namespace HighriseApi
{
    [SerializeAs(Name = "attachement")]
    public class Attachment
    {
        [SerializeAs(Name = "id")]
        public int? Id { get; set; }

        [SerializeAs(Name = "url")]
        public string Url { get; set; }

        [SerializeAs(Name = "name")]
        public string Name { get; set; }

        [SerializeAs(Name = "size")]
        public int? Size { get; set; }
    }
}

using System;
using RestSharp.Serializers;

namespace HighriseApi.Models
{
    [SerializeAs(Name = "account")]
    public class Account : BaseModel
    {
        [SerializeAs(Name = "name")]
        public string Name { get; set; }

        [SerializeAs(Name = "subdomain")]
        public string Subdomain { get; set; }

        [SerializeAs(Name = "plan")]
        public string Plan { get; set; }

        [SerializeAs(Name = "owner-id")]
        public int OwnerId { get; set; }

        [SerializeAs(Name = "people-count")]
        public int PeopleCount { get; set; }

        [SerializeAs(Name = "storage")]
        public int Storage { get; set; }

        [SerializeAs(Name = "color_theme")]
        public string ColorTheme { get; set; }

        [SerializeAs(Name = "ssll_enabled")]
        public bool SslEnabled { get; set; }

        [SerializeAs(Name = "created-at")]
        public DateTime CreatedAt { get; set; }

        [SerializeAs(Name = "updated-at")]
        public DateTime UpdatedAt { get; set; }
    }
}

using System;
using RestSharp.Serializers;

namespace HighriseApi.Models
{
    public class User : BaseModel
    {
        [SerializeAs(Name = "name")]
        public string Name { get; set; }

        [SerializeAs(Name = "email-address")]
        public string EmailAddress { get; set; }

        [SerializeAs(Name = "created-at")]
        public DateTime CreatedAt { get; set; }

        [SerializeAs(Name = "updated-at")]
        public DateTime UpdatedAt { get; set; }

        [SerializeAs(Name = "token")]
        public string Token { get; set; }

        [SerializeAs(Name = "dropbox")]
        public string Dropbox { get; set; }
    }
}

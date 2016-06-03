using System;
using HighriseApi.Models;
using RestSharp.Serializers;

namespace HighriseApi
{
    [Serializable, SerializeAs(Name = "membership")]
    public class Membership : BaseModel
    {
        [SerializeAs(Name = "user-id")]
        public int UserId { get; set; }

        [SerializeAs(Name = "group-id")]
        public int GroupId { get; set; }

        [SerializeAs(Name = "updated-at")]
        public DateTime UpdatedAt { get; set; }

        [SerializeAs(Name = "created-at")]
        public DateTime CreatedAt { get; set; }
    }
}

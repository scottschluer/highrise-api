using System;
using System.Collections.Generic;
using HighriseApi.Models;
using RestSharp.Serializers;

namespace HighriseApi
{
    [Serializable, SerializeAs(Name = "group")]
    public class Group : BaseModel
    {

        [SerializeAs(Name = "name")]
        public string Name { get; set; }

        [SerializeAs(Name = "users")]
        public List<User> Users { get; set; }

    }
}

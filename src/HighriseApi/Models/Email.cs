using System;
using System.Collections.Generic;
using HighriseApi.Models;
using RestSharp.Serializers;

namespace HighriseApi
{
    [Serializable, SerializeAs(Name = "email")]
    public class Email : Note
    {

        [SerializeAs(Name = "title")]
        public string Title { get; set; }

    }
}

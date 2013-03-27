using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using HighriseApi.Utilities;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace HighriseApi.Models
{
    [SerializeAs(Name = "kase")]
    public class Case : BaseModel
    {
        [SerializeAs(Name = "author-id")]
        public int AuthorId { get; set; }

        [SerializeAs(Name = "group-id")]
        public int? GroupId { get; set; }

        [SerializeAs(Name = "owner-id")]
        public int? OwnerId { get; set; }

        [SerializeAs(Name = "name")]
        public string Name { get; set; }

        [SerializeAs(Name = "background")]
        public string Background { get; set; }

        [SerializeAs(Name = "visible-to")]
        public string VisibleTo { get; set; }

        [SerializeAs(Name = "created-at")]
        public DateTime CreatedAt { get; set; }

        [SerializeAs(Name = "updated-at")]
        public DateTime UpdatedAt { get; set; }

        [SerializeAs(Name = "closed-at")]
        public DateTime? ClosedAt { get; set; }

        [XmlIgnore]
        public Parties Parties { get; private set; }

        protected internal void LoadParties(string xml)
        {
            Parties = PartyConverter.Convert(XDocument.Parse(xml).Descendants("parties").FirstOrDefault());
        }
    }
}

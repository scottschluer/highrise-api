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
    [SerializeAs(Name = "deal")]
    public class Deal : BaseModel
    {
        [SerializeAs(Name = "account-id")]
        public int AccountId { get; set; }

        [SerializeAs(Name = "author-id")]
        public int AuthorId { get; set; }

        [SerializeAs(Name = "background")]
        public string Background { get; set; }

        [SerializeAs(Name = "category-id")]
        public int? CategoryId { get; set; }

        [SerializeAs(Name = "created-at")]
        public DateTime CreatedAt { get; set; }

        [SerializeAs(Name = "currency")]
        public string Currency { get; set; }

        [SerializeAs(Name = "duration")]
        public int Duration { get; set; }

        [SerializeAs(Name = "group-id")]
        public int? GroupId { get; set; }

        [SerializeAs(Name = "name")]
        public string Name { get; set; }

        [SerializeAs(Name = "owner-id")]
        public int? OwnerId { get; set; }

        [SerializeAs(Name = "party-id")]
        public int? PartyId { get; set; }

        [SerializeAs(Name = "price")]
        public int Price { get; set; }

        [SerializeAs(Name = "price-type")]
        public string PriceType { get; set; }

        [SerializeAs(Name = "responsible-party-id")]
        public int? ResponsiblePartyId { get; set; }

        [SerializeAs(Name = "status")]
        public string Status { get; set; }

        [SerializeAs(Name = "status-changed-on")]
        public DateTime? StatusChangedOn { get; set; }

        [SerializeAs(Name = "updated-at")]
        public DateTime UpdatedAt { get; set; }

        [SerializeAs(Name = "visible-to")]
        public string VisibleTo { get; set; }

        [XmlIgnore]
        public object Party { get; set; }

        [XmlIgnore]
        public Parties Parties { get; private set; }

        protected internal void LoadParties(string xml)
        {
            Party = PartyConverter.ConvertSingle(XDocument.Parse(xml).Descendants("party").FirstOrDefault());
            Parties = PartyConverter.Convert(XDocument.Parse(xml).Descendants("parties").FirstOrDefault());
        }
    }
}

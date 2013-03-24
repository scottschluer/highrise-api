using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
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
        public List<Person> People { get; private set; }

        [XmlIgnore]
        public List<Company> Companies { get; private set; }

        protected internal void LoadParties(string xml)
        {
            var doc = XDocument.Parse(xml);
            XmlDeserializer s = new XmlDeserializer();

            var kase = doc.Descendants("kase").Where(x => x.Element("id") != null && x.Element("id").Value == this.Id.ToString());

            foreach (var party in kase.Descendants("party"))
            {
                var xElement = party.Element("type");
                if (xElement == null) continue;

                switch (xElement.Value.ToLower())
                {
                    case "person":
                        var person = s.Deserialize<Person>(new RestResponse { Content = party.ToString() });

                        if (person != null)
                            this.People.Add(person);

                        break;
                    case "company":
                        var company = s.Deserialize<Company>(new RestResponse { Content = party.ToString() });

                        if (company != null)
                            this.Companies.Add(company);

                        break;
                }
            }
        }
    }
}

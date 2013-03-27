using System;
using System.Linq;
using System.Xml.Linq;
using HighriseApi.Models;
using RestSharp;
using RestSharp.Deserializers;

namespace HighriseApi.Utilities
{
    public static class PartyConverter
    {
        public static Parties Convert(string xml)
        {
            return Convert(XDocument.Parse(xml).Descendants("parties").FirstOrDefault());
        }

        public static Parties Convert(XElement xml)
        {
            if (xml == null) return null;

            var s = new XmlDeserializer();
            var parties = new Parties();

            foreach (var party in xml.Descendants("party"))
            {
                string partyType = String.Empty;
                
                var element = party.Element("type");
                if (element != null)
                    partyType = element.Value;
                
                if (String.IsNullOrEmpty(partyType))
                {
                    var attribute = party.Attribute("type");
                    if (attribute != null) partyType = attribute.Value;
                }

                if (String.IsNullOrEmpty(partyType)) continue;

                switch (partyType.ToLower())
                {
                    case "person":
                        var person = s.Deserialize<Person>(new RestResponse { Content = party.ToString() });

                        if (person != null)
                            parties.People.Add(person);

                        break;
                    case "company":
                        var company = s.Deserialize<Company>(new RestResponse { Content = party.ToString() });

                        if (company != null)
                            parties.Companies.Add(company);

                        break;
                }
            }

            return parties;
        }
    }
}

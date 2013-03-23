using System.Collections.Generic;
using RestSharp.Serializers;

namespace HighriseApi
{
    public class ContactData
    {
        [SerializeAs(Name = "addresses")]
        public List<Address> Addresses { get; set; }

        [SerializeAs(Name = "email-addresses")]
        public List<EmailAddress> EmailAddresses { get; set; }

        [SerializeAs(Name = "instant-messengers")]
        public List<InstantMessenger> InstantMessengers { get; set; }

        [SerializeAs(Name = "phone-numbers")]
        public List<PhoneNumber> PhoneNumbers { get; set; }

        [SerializeAs(Name = "twitter-accounts")]
        public List<TwitterAccount> TwitterAccounts { get; set; }

        [SerializeAs(Name = "web-addresses")]
        public List<WebAddress> WebAddresses { get; set; }
    }
}

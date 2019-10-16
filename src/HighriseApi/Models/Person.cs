using System;
using System.Collections.Generic;
using HighriseApi.Models;
using RestSharp.Serializers;

namespace HighriseApi
{
    [Serializable, SerializeAs(Name = "person")]
    public class Person : BaseModel
    {
        [SerializeAs(Name = "author-id")]
        public int AuthorId { get; set; }

        [SerializeAs(Name = "group-id")]
        public int? GroupId { get; set; }

        [SerializeAs(Name = "owner-id")]
        public int? OwnerId { get; set; }

        [SerializeAs(Name = "first-name")]
        public string FirstName { get; set; }

        [SerializeAs(Name = "last-name")]
        public string LastName { get; set; }

        [SerializeAs(Name = "title")]
        public string Title { get; set; }

        [SerializeAs(Name = "background")]
        public string Background { get; set; }

        [SerializeAs(Name = "linkedin-url")]
        public string LinkedInUrl { get; set; }

        [SerializeAs(Name = "avatar-url")]
        public string AvatarUrl { get; set; }

        [SerializeAs(Name = "company-id")]
        public int? CompanyId { get; set; }

        [SerializeAs(Name = "company-name")]
        public string CompanyName { get; set; }

        [SerializeAs(Name = "created-at")]
        public DateTime CreatedAt { get; set; }

        [SerializeAs(Name = "updated-at")]
        public DateTime UpdatedAt { get; set; }

        [SerializeAs(Name = "visible-to")]
        public string VisibleTo { get; set; }

        [SerializeAs(Name = "contact-data")]
        public ContactData ContactData { get; set; }

        [SerializeAs(Name = "subject_datas")]
        public List<SubjectData> SubjectDatas { get; set; }

        [SerializeAs(Name = "tags")]
        public List<Tag> Tags { get; set; }

    }
}

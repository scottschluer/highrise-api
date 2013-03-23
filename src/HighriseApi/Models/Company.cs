using System;
using System.Collections.Generic;
using RestSharp.Serializers;

namespace HighriseApi.Models
{
    [SerializeAs(Name = "company")]
    public class Company : BaseModel
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

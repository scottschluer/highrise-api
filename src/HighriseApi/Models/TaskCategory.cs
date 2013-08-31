using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp.Serializers;

namespace HighriseApi.Models
{
    [SerializeAs(Name = "task-category")]
    public class TaskCategory : BaseModel
    {
        [SerializeAs(Name = "name")]
        public string Name { get; set; }
        [SerializeAs(Name = "color")]
        public string Color { get; set; }
        [SerializeAs(Name = "account-id")]
        public int AccountId { get; set; }
        [SerializeAs(Name = "created-at")]
        public DateTime CreatedAt { get; set; }
        [SerializeAs(Name = "updated-at")]
        public DateTime UpdatedAt { get; set; }
        [SerializeAs(Name = "elements-count")]
        public int ElementsCount { get; set; }        
    }
}

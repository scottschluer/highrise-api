using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighriseApi.Models.Enums;
using RestSharp.Serializers;

namespace HighriseApi.Models
{
    [SerializeAs(Name = "task")]
    public class Task : BaseModel
    {
        public Task()
        {
            SubjectType = "Party";
        }

        [SerializeAs(Name = "body")]
        public string Body { get; set; }

        [SerializeAs(Name = "frame")]
        public Frame Frame { get; set; }

        [SerializeAs(Name = "due-at")]
        public DateTime? DueAt { get; set; }

        [SerializeAs(Name = "alert-at")]
        public DateTime? AlertAt { get; set; }

        [SerializeAs(Name = "done-at")]
        public DateTime? DoneAt { get; set; }

        [SerializeAs(Name = "created-at")]
        public DateTime CreatedAt { get; set; }

        [SerializeAs(Name = "updated-at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Default value is 'Party'
        /// </summary>
        [SerializeAs(Name = "subject-type")]
        public string SubjectType { get; set; }

        [SerializeAs(Name = "subject-id")]
        public int? SubjectId { get; set; }

        [SerializeAs(Name = "subject-name")]
        public string SubjectName { get; set; }

        [SerializeAs(Name = "recording-id")]
        public int? RecordingId { get; set; }

        [SerializeAs(Name = "category-id")]
        public int? CategoryId { get; set; }

        [SerializeAs(Name = "owner-id")]
        public int? OwnerId { get; set; }

        [SerializeAs(Name = "public")]
        public bool? Public { get; set; }

        [SerializeAs(Name = "notify")]
        public bool? Notify { get; set; }
    }
}

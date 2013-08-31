using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighriseApi.Models
{
    [SerializeAs(Name = "subject-field")]
    public class SubjectField : BaseModel
    {
        [SerializeAs(Name = "label")]
        public string Label { get; set; }        
    }
}

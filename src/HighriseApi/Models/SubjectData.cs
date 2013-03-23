using HighriseApi.Models;
using RestSharp.Serializers;

namespace HighriseApi
{
    [SerializeAs(Name = "subject_data")]
    public class SubjectData : BaseModel
    {
        [SerializeAs(Name = "subject_field_id")]
        public int SubjectFieldId { get; set; }

        [SerializeAs(Name = "subject_field_label")]
        public string SubjectFieldLabel { get; set; }

        [SerializeAs(Name = "value")]
        public string Value { get; set; }
    }
}

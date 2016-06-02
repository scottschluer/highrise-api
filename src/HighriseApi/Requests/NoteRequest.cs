using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using HighriseApi.Interfaces;
using HighriseApi.Models;
using HighriseApi.Models.Enums;
using HighriseApi.Serializers;
using RestSharp;
using RestSharp.Serializers;

namespace HighriseApi.Requests
{
    public class NoteRequest : RequestBase, INoteRequest
    {
        public NoteRequest(IRestClient client) : base(client) { }

        public Note Create(SubjectType subjectType, int subjectId, Note note)
        {
            var request = new RestRequest(String.Format("{0}/{1}/notes.xml",
                subjectType.ToString().ToLower(), subjectId), Method.POST)
            { XmlSerializer = new XmlSerializer() };
            request.AddBody(note);

            var response = _client.Execute<Note>(request);
            return response.Data;
        }

        public bool Delete(int id)
        {
            var response = _client.Execute<Note>(new RestRequest(String.Format("notes/{0}.xml", id), Method.DELETE));
            return response.StatusCode == HttpStatusCode.OK;
        }

        public Note Get(int id)
        {
            var response = _client.Execute<Note>(new RestRequest(String.Format("/notes/{0}.xml", id), Method.GET));
            var note = response.Data;
            return note;
        }

        public IEnumerable<Note> Get(SubjectType subjectType, int subjectId, int? offset = null)
        {
            var url = offset.HasValue
                         ? String.Format("/{0}/{1}/notes.xml?n={2}", subjectType.ToString().ToLower(), subjectId, offset.Value)
                         : String.Format("/{0}/{1}/notes.xml", subjectType.ToString().ToLower(), subjectId);

            var response = _client.Execute<List<Note>>(new RestRequest(url, Method.GET));
            var results = response.Data;
            return results;
        }

        public IEnumerable<Note> Get(SubjectType subjectType, int subjectId, DateTime since, int? offset = null)
        {
            var url = offset.HasValue
                         ? String.Format("/{0}/{1}/notes.xml?since={2}&n={3}", subjectType.ToString().ToLower(), subjectId, since, offset.Value)
                         : String.Format("/{0}/{1}/notes.xml?since={2}", subjectType.ToString().ToLower(), subjectId, since);

            var response = _client.Execute<List<Note>>(new RestRequest(url, Method.GET));
            var results = response.Data;
            return results;
        }

        public IEnumerable<Comment> GetComments(int id)
        {
            var response = _client.Execute<List<Comment>>(new RestRequest(String.Format("/notes/{0}/comments.xml", id), Method.GET));
            var commentsForNote = response.Data;
            return commentsForNote;
        }

        public bool Update(Note note)
        {
            var request = new RestRequest(String.Format("notes/{0}.xml", note.Id), Method.PUT) { XmlSerializer = new XmlIgnoreSerializer() };
            request.AddBody(note);

            var response = _client.Execute<Note>(request);
            return response.StatusCode == HttpStatusCode.OK;
        }
    }
}

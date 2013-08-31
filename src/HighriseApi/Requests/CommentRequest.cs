using HighriseApi.Interfaces;
using HighriseApi.Models;
using HighriseApi.Models.Enums;
using HighriseApi.Serializers;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;


namespace HighriseApi.Requests
{
    public class CommentRequest : RequestBase, ICommentRequest
    {
        public CommentRequest(IRestClient client) : base(client) { }

        public Comment Get(int id)
        {
            var response = _client.Execute<Comment>(new RestRequest(String.Format("comments/{0}.xml", id), Method.GET));
            var comment = response.Data;
            return comment;
        }

        public IEnumerable<Comment> Get(int id, CommentType commentType)
        {
            var response = _client.Execute<List<Comment>>(new RestRequest(String.Format("{0}/{1}/comments.xml", commentType.ToString().ToLower(), id), Method.GET));
            var comments = response.Data;
            return comments;
        }
        
        public Comment Create(Comment comment)
        {
            var request = new RestRequest("comments.xml", Method.POST) { XmlSerializer = new XmlIgnoreSerializer() };
            request.AddBody(comment);

            var response = _client.Execute<Comment>(request);
            return response.Data;
        }
        
        public bool Update(Comment comment)
        {
            var request = new RestRequest("comments/{id}.xml", Method.PUT) { XmlSerializer = new XmlIgnoreSerializer() };
            request.AddParameter("id", comment.Id, ParameterType.UrlSegment);
            request.AddBody(comment);

            var response = _client.Execute<Case>(request);
            return response.StatusCode == HttpStatusCode.OK;
        }

        public bool Delete(int id)
        {
            var response = _client.Execute<Case>(new RestRequest(String.Format("comments/{0}.xml", id), Method.DELETE));
            return response.StatusCode == HttpStatusCode.OK;
        }
    }
}

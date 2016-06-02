using HighriseApi.Models;
using HighriseApi.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighriseApi.Interfaces
{
    public interface IEmailRequest
    {

        /// <summary>
        /// Gets an email by email id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A single email.</returns>
        Email Get(int id);

        /// <summary>
        /// Get comments for a given email
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IEnumerable<Comment> GetComments(int id);

        /// <summary>
        /// Collection of emails that are visible to the authenticated user
        /// </summary>
        /// <param name="ParentId">id of specific person, company, case or deal.</param>
        /// <param name="subjectId"></param>
        /// <returns></returns>
        IEnumerable<Email> Get(SubjectType subjectType, int subjectId, int? offset = null);

        /// <summary>
        /// emails collection ordered from oldest to newest starting from given date
        /// </summary>
        /// <param name="ParentId"></param>
        /// <param name="subjectId"></param>
        /// <param name="since">this  parameter is expressed as yyyymmddhhmmss in the UTC timezone.</param>
        /// <returns>Only the emails that have been updated since the time in the query parameter</returns>
        IEnumerable<Email> Get(SubjectType subjectType, int subjectId, DateTime since, int? offset = null);

        /// <summary>
        /// Creates an email
        /// </summary>
        /// <param name="subjectType"></param>
        /// <param name="subjectId"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        Email Create(SubjectType subjectType, int subjectId, Email email);


        /// <summary>
        /// Updates an email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        bool Update(Email email);

        /// <summary>
        /// Deletes an email
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
    }
}

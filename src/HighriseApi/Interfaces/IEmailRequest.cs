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
        /// Gets a Note by note id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A single note.</returns>
        Email Get(int id);

        /// <summary>
        /// Get comments for a given note
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IEnumerable<Comment> GetComments(int id);

        /// <summary>
        /// Collection of notes that are visible to the authenticated user
        /// </summary>
        /// <param name="ParentId">id of specific person, company, case or deal.</param>
        /// <param name="subjectId"></param>
        /// <returns></returns>
        IEnumerable<Email> Get(SubjectType subjectType, int subjectId, int? offset = null);

        /// <summary>
        /// Notes collection ordered from oldest to newest starting from given date
        /// </summary>
        /// <param name="ParentId"></param>
        /// <param name="subjectId"></param>
        /// <param name="since">this  parameter is expressed as yyyymmddhhmmss in the UTC timezone.</param>
        /// <returns>Only the notes that have been updated since the time in the query parameter</returns>
        IEnumerable<Email> Get(SubjectType subjectType, int subjectId, DateTime since, int? offset = null);

        /// <summary>
        /// Creates a Note
        /// </summary>
        /// <param name="subjectType"></param>
        /// <param name="subjectId"></param>
        /// <param name="note"></param>
        /// <returns></returns>
        Email Create(SubjectType subjectType, int subjectId, Email email);


        /// <summary>
        /// Updates a note
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        bool Update(Email email);

        /// <summary>
        /// Deletes a note
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
    }
}

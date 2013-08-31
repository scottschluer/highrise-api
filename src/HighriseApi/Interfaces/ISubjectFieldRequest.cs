using HighriseApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighriseApi.Interfaces
{
    public interface ISubjectFieldRequest
    {

        /// <summary>
        /// Gets an IEnumerable collection of <see cref="SubjectField"/> objects.
        /// </summary>
        /// <returns>An IEnumerable collection of <see cref="SubjectField"/> objects</returns>.
        IEnumerable<SubjectField> Get();

        /// <summary>
        /// Creates a new subject field
        /// </summary>
        /// <param name="subjectField">A <see cref="SubjectField"/> object</param>
        /// <returns>A <see cref="SubjectField"/> object, populated with new Highrise ID</returns>
        SubjectField Create(SubjectField subjectfield);

        /// <summary>
        /// Updates a subject field
        /// </summary>
        /// <param name="subjectField">A <see cref="SubjectField"/> object</param>
        /// <returns>True if successfully updated, otherwise false</returns>
        bool Update(SubjectField subjectField);

        /// <summary>
        /// Deletes a subject field
        /// </summary>
        /// <param name="id">The ID of the case to delete</param>
        /// <returns>True if successfully deleted, otherwise false</returns>
        bool Delete(int id);
    }
}

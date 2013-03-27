using System.Collections.Generic;
using HighriseApi.Models;
using HighriseApi.Models.Enums;

namespace HighriseApi.Interfaces
{
    public interface ITagRequest
    {
        /// <summary>
        /// Gets an IEnumerable collection of all tags used in the account
        /// </summary>
        /// <returns>An IEnumerable collection <see cref="Tag"/> objects</returns>
        IEnumerable<Tag> Get();

        /// <summary>
        /// Gets an IEnumerable collection of all tags for the corresponding subject
        /// </summary>
        /// <param name="subjectType">A <see cref="SubjectType"/> value</param>
        /// <param name="subjectId">The subjectId of the tag</param>
        /// <returns>An IEnumerable collection <see cref="Tag"/> objects</returns>
        IEnumerable<Tag> Get(SubjectType subjectType, int subjectId);

        /// <summary>
        /// Gets a list of <see cref="Person"/> objects and <see cref="Company"/> objects associated with a tag
        /// </summary>
        /// <param name="tagId">The tag id</param>
        /// <returns>An <see cref="Parties"/> object</returns>
        Parties Parties(int tagId);

        /// <summary>
        /// Creates a new tag
        /// </summary>
        /// <param name="subjectType">A <see cref="SubjectType"/> value</param>
        /// <param name="subjectId">The subjectId of the tag</param>
        /// <param name="tag">The <see cref="Tag"/> object to create</param>
        /// <returns>An updated <see cref="Tag"/> object, populated with new Highrise ID and CreatedAt/UpdatedAt values</returns>
        Tag Create(SubjectType subjectType, int subjectId, Tag tag);

        /// <summary>
        /// Deletes a tag
        /// </summary>
        /// <param name="subjectType">A <see cref="SubjectType"/> value</param>
        /// <param name="subjectId">The subjectId of the tag</param>
        /// <param name="tagId">The tag id</param>
        /// <returns>True if successfully deleted, otherwise false</returns>
        bool Delete(SubjectType subjectType, int subjectId, int tagId);
    }
}

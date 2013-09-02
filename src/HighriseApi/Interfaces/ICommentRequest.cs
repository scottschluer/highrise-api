using HighriseApi.Models;
using HighriseApi.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighriseApi.Interfaces
{
    public interface ICommentRequest
    {
        /// <summary>
        /// Gets a comment by comment ID.
        /// </summary>
        /// <returns>An instance of a <see cref="Comment"/> object</returns>
        Comment Get(int id);

        /// <summary>
        /// Gets an IEnumerable collection of <see cref="Comment"/> objects by Note/Email Id and <see cref="CommentType"/>.
        /// </summary>
        /// <param name="id">A note or email id the comment is associated with</param>
        /// <param name="CommentType">A <see cref="CommentType"/> enum value</param>
        /// <returns>An IEnumerable collection of <see cref="Comment"/> objects</returns>.
        IEnumerable<Comment> Get(int id,CommentType commentType);

        /// <summary>
        /// Creates a new comment
        /// </summary>
        /// <param name="comment">A <see cref="Comment"/> object</param>
        /// <returns>A <see cref="Comment"/> object, populated with new Highrise ID and CreatedAt/UpdatedAt values</returns>
        Comment Create(Comment comment);

        /// <summary>
        /// Updates a comment
        /// </summary>
        /// <param name="comment">A <see cref="Comment"/> object</param>
        /// <returns>True if successfully updated, otherwise false</returns>
        bool Update(Comment comment);

        /// <summary>
        /// Deletes a comment
        /// </summary>
        /// <param name="id">The ID of the comment to delete</param>
        /// <returns>True if successfully deleted, otherwise false</returns>
        bool Delete(int id);
    }
}

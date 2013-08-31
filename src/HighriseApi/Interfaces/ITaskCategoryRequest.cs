using HighriseApi.Models;
using HighriseApi.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighriseApi.Interfaces
{
    public interface ITaskCategoryRequest
    {
        /// <summary>
        /// Gets a task category by category ID.
        /// </summary>
        /// <returns>An instance of a <see cref="TaskCategory"/> object</returns>
        TaskCategory Get(int id);

        /// <summary>
        /// Gets an IEnumerable collection of <see cref="TaskCategory"/> objects.
        /// </summary>
        /// <returns>An IEnumerable collection of <see cref="TaskCategory"/> objects</returns>.
        IEnumerable<TaskCategory> Get();

        /// <summary>
        /// Creates a new task category
        /// </summary>
        /// <param name="category">A <see cref="TaskCategory"/> object</param>
        /// <returns>A <see cref="TaskCategory"/> object, populated with new Highrise ID and CreatedAt/UpdatedAt values</returns>
        TaskCategory Create(TaskCategory category);

        /// <summary>
        /// Updates a task category
        /// </summary>
        /// <param name="category">A <see cref="TaskCategory"/> object</param>
        /// <returns>True if successfully updated, otherwise false</returns>
        bool Update(TaskCategory category);

        /// <summary>
        /// Deletes a task category
        /// </summary>
        /// <param name="id">The ID of the task category to delete</param>
        /// <returns>True if successfully deleted, otherwise false</returns>
        bool Delete(int id);
    }
}
 
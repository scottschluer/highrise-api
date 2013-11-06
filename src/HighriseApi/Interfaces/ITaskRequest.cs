using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighriseApi.Models;
using HighriseApi.Models.Enums;

namespace HighriseApi.Interfaces
{
    public interface ITaskRequest
    {
        /// <summary>
        /// Gets an IEnumerable collection of <see cref="Task"/> objects by <see cref="TaskStatus"/>.
        /// </summary>
        /// <param name="taskStatus">A <see cref="TaskStatus"/> enum value</param>
        /// <returns>An IEnumerable collection of <see cref="Deal"/> objects</returns>.
        IEnumerable<Task> Get(TaskStatus taskStatus);

        /// <summary>
        /// Gets an IEnumerable collection of <see cref="Task"/> objects by <see cref="SubjectType"/>.
        /// </summary>
        /// <param name="subjectType">A <see cref="SubjectType"/> enum value</param>
        /// /// <param name="subjectId">Id of the subject</param>
        /// <returns>An IEnumerable collection of <see cref="Deal"/> objects</returns>.
        IEnumerable<Task> Get(SubjectType subjectType, int subjectId);

        /// <summary>
        /// Gets a task by task ID.
        /// </summary>
        /// <returns>An instance of a <see cref="Task"/> object</returns>
        Task Get(int id);

        /// <summary>
        /// Creates a new task
        /// </summary>
        /// <param name="task">A <see cref="Task"/> object</param>
        /// <returns>A <see cref="Task"/> object, populated with new Highrise ID and CreatedAt/UpdatedAt values</returns>
        Task Create(Task task);

        /// <summary>
        /// Updates a task
        /// </summary>
        /// <param name="task">A <see cref="Task"/> object</param>
        /// <returns>An updated <see cref="Task"/> object</returns>
        Task Update(Task task);

        /// <summary>
        /// Completes a  task
        /// </summary>
        /// <param name="id">Id of the task to complete</param>
        /// <returns>A <see cref="Task"/> object, populated with DoneAt values</returns>
        Task Complete(int id);

        /// <summary>
        /// Deletes a task
        /// </summary>
        /// <param name="id">The ID of the task to delete</param>
        /// <returns>True if successfully deleted, otherwise false</returns>
        bool Delete(int id);
    }
}

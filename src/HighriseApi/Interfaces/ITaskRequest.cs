using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighriseApi.Models;

namespace HighriseApi.Interfaces
{
    public interface ITaskRequest
    {
        /// <summary>
        /// Creates a new task
        /// </summary>
        /// <param name="task">A <see cref="Task"/> object</param>
        /// <returns>A <see cref="Task"/> object, populated with new Highrise ID and CreatedAt/UpdatedAt values</returns>
        Task Create(Task task);
    }
}

using System.Collections.Generic;
using HighriseApi.Models;

namespace HighriseApi.Interfaces
{
    public interface IUserRequest
    {
        /// <summary>
        /// Gets the user information for the current user context.
        /// </summary>
        /// <returns>A <see cref="User"/> object</returns>
        User Me();
        
        /// <summary>
        /// Gets a user by ID
        /// </summary>
        /// <param name="id">The ID of the user to get</param>
        /// <returns>A <see cref="User"/> object</returns>
        User Get(int id);

        /// <summary>
        /// Gets a list of users
        /// </summary>
        /// <returns>An IEnumerable collection of <see cref="User"/> objects</returns>
        IEnumerable<User> Get();
    }
}

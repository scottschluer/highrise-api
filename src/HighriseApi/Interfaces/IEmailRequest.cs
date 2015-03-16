using System;
using System.Collections.Generic;

namespace HighriseApi.Interfaces
{
    public interface IEmailRequest
    {
        #region Get
        /// <summary>
        /// Gets a collection of Emails that are visible to the authenticated user.
        /// </summary>
        /// <returns>An IEnumerable collection of <see cref="Person"/> objects</returns>
        IEnumerable<Email> Get(int? offset = null);

        /// <summary>
        /// Gets a collection of people that have been created or updated since the date passed in.
        /// </summary>
        /// <param name="startDate">The date after which a user must be created in order to be returned</param>
        /// <returns>An IEnumerable collection of <see cref="Person"/> objects</returns>
        IEnumerable<Email> Get(DateTime startDate, int? offset = null);

        #endregion
    }
}

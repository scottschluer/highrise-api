using System;
using System.Collections.Generic;

namespace HighriseApi.Interfaces
{
    public interface IPersonRequest
    {
        #region Get
        /// <summary>
        /// Gets a collection of people that are visible to the authenticated user.
        /// </summary>
        /// <returns>An IEnumerable collection of <see cref="Person"/> objects</returns>
        IEnumerable<Person> Get(int? offset = null);

        /// <summary>
        /// Gets a collection of people that have been created or updated since the date passed in.
        /// </summary>
        /// <param name="startDate">The date after which a user must be created in order to be returned</param>
        /// <returns>An IEnumerable collection of <see cref="Person"/> objects</returns>
        IEnumerable<Person> Get(DateTime startDate);

        /// <summary>
        /// Gets a single person by ID
        /// </summary>
        /// <param name="id">The ID of the person</param>
        /// <returns>A <see cref="Person"/> object</returns>
        Person Get(int id);
        #endregion

        /// <summary>
        /// Creates a new person
        /// </summary>
        /// <param name="person">A <see cref="Person"/> object</param>
        /// <returns>A <see cref="Person"/> object, populated with new Highrise ID and CreatedAt/UpdatedAt values</returns>
        Person Create(Person person);

        /// <summary>
        /// Updates a person
        /// </summary>
        /// <param name="person">A <see cref="Person"/> object</param>
        /// <returns>A <see cref="Person"/> object, populated with updated values</returns>
        Person Update(Person person);

        /// <summary>
        /// Deletes a person
        /// </summary>
        /// <param name="id">The ID of the person to delete</param>
        /// <returns>True if successfully deleted, otherwise false</returns>
        bool Delete(int id);

        /// <summary>
        /// Searches for people by name
        /// </summary>
        /// <param name="name">The name to search for</param>
        /// <param name="offset">Optional, specifies the offset for the returned collection of <see cref="Person"/> objects</param>
        /// <returns>A collection of <see cref="Person"/> objects matching the search term</returns>
        IEnumerable<Person> Search(string name, int? offset = null);

        /// <summary>
        /// Searches for people by field name and value
        /// </summary>
        /// <param name="values">An IDictionary instance where keys contain Highrise field names and values contain the value to search for</param>
        /// <param name="offset">Optional, specifies the offset for the returned collection of <see cref="Person"/> objects</param>
        /// <returns>A collection of <see cref="Person"/> objects matching the search criteria</returns>
        IEnumerable<Person> Search(IDictionary<string, string> values, int? offset = null);
    }
}

using System.Collections.Generic;
using HighriseApi.Models;

namespace HighriseApi.Interfaces
{
    public interface ICompanyRequest
    {
        #region Get
        /// <summary>
        /// Gets a collection of companies that are visible to the authenticated user.
        /// </summary>
        /// <returns>An IEnumerable collection of <see cref="Company"/> objects</returns>
        IEnumerable<Company> Get(int? offset = null);

        /// <summary>
        /// Gets a single company by ID
        /// </summary>
        /// <param name="id">The ID of the company</param>
        /// <returns>A <see cref="Company"/> object</returns>
        Company Get(int id);
        #endregion

        /// <summary>
        /// Creates a new company
        /// </summary>
        /// <param name="company">A <see cref="Company"/> object</param>
        /// <returns>A <see cref="Company"/> object, populated with new Highrise ID and CreatedAt/UpdatedAt values</returns>
        Company Create(Company company);

        /// <summary>
        /// Updates a company
        /// </summary>
        /// <param name="company">A <see cref="Company"/> object</param>
        /// <returns>A <see cref="Company"/> object, populated with updated values</returns>
        Company Update(Company company);

        /// <summary>
        /// Deletes a company
        /// </summary>
        /// <param name="id">The ID of the company to delete</param>
        /// <returns>True if successfully deleted, otherwise false</returns>
        bool Delete(int id);

        /// <summary>
        /// Searches for companies by name
        /// </summary>
        /// <param name="name">The name to search for</param>
        /// <param name="offset">Optional, specifies the offset for the returned collection of <see cref="Company"/> objects</param>
        /// <returns>A collection of <see cref="Company"/> objects matching the search term</returns>
        IEnumerable<Company> Search(string name, int? offset = null);

        /// <summary>
        /// Searches for companies by field name and value
        /// </summary>
        /// <param name="values">An IDictionary instance where keys contain Highrise field names and values contain the value to search for</param>
        /// <param name="offset">Optional, specifies the offset for the returned collection of <see cref="Company"/> objects</param>
        /// <returns>A collection of <see cref="Company"/> objects matching the search criteria</returns>
        IEnumerable<Company> Search(IDictionary<string, string> values, int? offset = null);
    }
}

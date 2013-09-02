using HighriseApi.Models;
using HighriseApi.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighriseApi.Interfaces
{
    public interface IDealCategoryRequest
    {
        /// <summary>
        /// Gets a deal category by category ID.
        /// </summary>
        /// <returns>An instance of a <see cref="DealCategory"/> object</returns>
        DealCategory Get(int id);

        /// <summary>
        /// Gets an IEnumerable collection of <see cref="DealCategory"/> objects.
        /// </summary>
        /// <returns>An IEnumerable collection of <see cref="DealCategory"/> objects</returns>.
        IEnumerable<DealCategory> Get();

        /// <summary>
        /// Creates a new deal category
        /// </summary>
        /// <param name="category">A <see cref="DealCategory"/> object</param>
        /// <returns>A <see cref="DealCategory"/> object, populated with new Highrise ID and CreatedAt/UpdatedAt values</returns>
        DealCategory Create(DealCategory category);

        /// <summary>
        /// Updates a deal category
        /// </summary>
        /// <param name="category">A <see cref="DealCategory"/> object</param>
        /// <returns>True if successfully updated, otherwise false</returns>
        bool Update(DealCategory category);

        /// <summary>
        /// Deletes a deal category
        /// </summary>
        /// <param name="id">The ID of the deal category to delete</param>
        /// <returns>True if successfully deleted, otherwise false</returns>
        bool Delete(int id);
    }
}
 
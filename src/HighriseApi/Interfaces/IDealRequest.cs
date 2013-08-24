﻿using System.Collections.Generic;
using HighriseApi.Models;
using HighriseApi.Models.Enums;

namespace HighriseApi.Interfaces
{
    interface IDealRequest
    {
        /// <summary>
        /// Gets a deal by deal ID.
        /// </summary>
        /// <returns>An instance of a <see cref="Deal"/> object</returns>
        Deal Get(int id);

        /// <summary>
        /// Gets an IEnumerable collection of <see cref="Deal"/> objects by <see cref="DealStatus"/>.
        /// </summary>
        /// <param name="dealStatus">A <see cref="DealStatus"/> enum value</param>
        /// <returns>An IEnumerable collection of <see cref="Deal"/> objects</returns>.
        IEnumerable<Deal> Get(DealStatus dealStatus);

        /// <summary>
        /// Creates a new deal
        /// </summary>
        /// <param name="deal">A <see cref="Deal"/> object</param>
        /// <returns>A <see cref="Deal"/> object, populated with new Highrise ID and CreatedAt/UpdatedAt values</returns>
        Deal Create(Deal deal);

        /// <summary>
        /// Updates a deal
        /// </summary>
        /// <param name="deal">A <see cref="Deal"/> object</param>
        /// <returns>True if successfully updated, otherwise false</returns>
        bool Update(Deal deal);

        /// <summary>
        /// Updates a deal's status 
        /// </summary>
        /// <param name="id">The ID of the deal to update</param>
        /// /// <param name="dealStatus">A <see cref="DealStatus"/> enum value</param>
        /// <returns>True if successfully updated, otherwise false</returns>
        bool UpdateStatus(int id, DealStatus dealStatus);

        /// <summary>
        /// Deletes a deal
        /// </summary>
        /// <param name="id">The ID of the deal to delete</param>
        /// <returns>True if successfully deleted, otherwise false</returns>
        bool Delete(int id);
    }
}

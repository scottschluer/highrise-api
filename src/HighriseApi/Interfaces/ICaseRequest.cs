﻿using System.Collections.Generic;
using HighriseApi.Models;
using HighriseApi.Models.Enums;

namespace HighriseApi.Interfaces
{
    public interface ICaseRequest
    {
        /// <summary>
        /// Gets a case by case ID.
        /// </summary>
        /// <returns>An instance of a <see cref="Case"/> object</returns>
        Kase Get(int id);

        /// <summary>
        /// Gets an IEnumerable collection of <see cref="Case"/> objects by <see cref="CaseStatus"/>.
        /// </summary>
        /// <param name="caseStatus">A <see cref="CaseStatus"/> enum value</param>
        /// <returns>An IEnumerable collection of <see cref="Case"/> objects</returns>.
        IEnumerable<Kase> Get(CaseStatus caseStatus);

        /// <summary>
        /// Creates a new case
        /// </summary>
        /// <param name="kase">A <see cref="Case"/> object</param>
        /// <returns>A <see cref="Case"/> object, populated with new Highrise ID and CreatedAt/UpdatedAt values</returns>
        Kase Create(Kase kase);

        /// <summary>
        /// Updates a case
        /// </summary>
        /// <param name="kase">A <see cref="Case"/> object</param>
        /// <returns>True if successfully updated, otherwise false</returns>
        bool Update(Kase kase);

        /// <summary>
        /// Deletes a case
        /// </summary>
        /// <param name="id">The ID of the case to delete</param>
        /// <returns>True if successfully deleted, otherwise false</returns>
        bool Delete(int id);
    }
}

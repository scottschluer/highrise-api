using HighriseApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighriseApi.Interfaces
{
    public interface IRecordingRequest
    {
        /// <summary>
        /// Gets a collection of recording that are visible to the authenticated user.
        /// </summary>
        /// <returns>An IEnumerable collection of <see cref="Recording"/> objects</returns>
        IEnumerable<Recording> Get();

        /// <summary>
        /// Gets a collection of recordings that have been created or updated since the date passed in.
        /// </summary>
        /// <param name="startDate">The date after which a recording must be created in order to be returned</param>
        /// <returns>An IEnumerable collection of <see cref="Recording"/> objects</returns>
        IEnumerable<Recording> Get(DateTime startDate);
    }
}

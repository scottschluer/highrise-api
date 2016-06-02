using HighriseApi.Models;
using HighriseApi.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighriseApi.Interfaces
{
    public interface IGroupRequest
    {

        /// <summary>
        /// Gets a group by group id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A single group.</returns>
        Group Get(int id);

        /// <summary>
        /// Collection of groups that are visible to the authenticated user
        /// </summary>
        /// <returns></returns>
        IEnumerable<Group> Get();


        /// <summary>
        /// Creates a group
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        Group Create(Group group);


        /// <summary>
        /// Updates a group
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        bool Update(Group group);

        /// <summary>
        /// Deletes a group
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
    }
}

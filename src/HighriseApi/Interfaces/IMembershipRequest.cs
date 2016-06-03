using System.Collections.Generic;

namespace HighriseApi.Interfaces
{
    public interface IMembershipRequest
    {

        /// <summary>
        /// Gets a membership by membership id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A single membership.</returns>
        Membership Get(int id);

        /// <summary>
        /// Collection of memberships that are visible to the authenticated user
        /// </summary>
        /// <returns></returns>
        IEnumerable<Membership> Get();


        /// <summary>
        /// Creates a membership
        /// </summary>
        /// <param name="membership"></param>
        /// <returns></returns>
        Membership Create(Membership membership);


        /// <summary>
        /// Deletes a membership
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
    }
}

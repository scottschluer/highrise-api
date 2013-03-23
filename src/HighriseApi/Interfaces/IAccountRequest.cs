using HighriseApi.Models;

namespace HighriseApi.Interfaces
{
    public interface IAccountRequest
    {
        /// <summary>
        /// Gets the current user's account info
        /// </summary>
        /// <returns>An <see cref="Account"/> object containing the current user's information</returns>
        Account Get();
    }
}

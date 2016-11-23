using System;
using System.Threading.Tasks;

namespace KanjiAlive.Http
{
    /// <summary>
    ///     HTTP logic for consuming the Kanji Alive API.
    /// </summary>
    public interface IConnection
    {
        /// <summary>
        ///     Executes a generic HTTP GET command.
        /// </summary>
        /// <typeparam name="T">
        ///     The type which the JSON response from the API will be deserialized to.
        /// </typeparam>
        /// <param name="uri">
        ///     The URI for the target endpoint.
        /// </param>
        /// <returns>
        ///     The response metadata from the API and the deserialized query results.
        /// </returns>
        Task<IApiResponse<T>> Get<T>(Uri uri);
    }
}
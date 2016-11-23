using System.Net;

namespace KanjiAlive.Http
{
    /// <summary>
    ///     HTTP response metadata.
    /// </summary>
    public interface IResponse
    {
        /// <summary>
        ///     The response body.
        /// </summary>
        object Body { get; }

        /// <summary>
        ///     The HTTP response status code.
        /// </summary>
        HttpStatusCode StatusCode { get; }

        /// <summary>
        ///     The HTTP reason phrase.
        /// </summary>
        string ReasonPhrase { get; }
    }
}
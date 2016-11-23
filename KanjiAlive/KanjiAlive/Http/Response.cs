using System.Net;

namespace KanjiAlive.Http
{
    /// <summary>
    ///     HTTP response metadata.
    /// </summary>
    public class Response : IResponse
    {
        /// <summary>
        ///     The response body.
        /// </summary>
        public object Body { get; internal set; }

        /// <summary>
        ///     The HTTP response status code.
        /// </summary>
        public HttpStatusCode StatusCode { get; internal set; }

        /// <summary>
        ///     The HTTP reason phrase.
        /// </summary>
        public string ReasonPhrase { get; internal set; }
    }
}
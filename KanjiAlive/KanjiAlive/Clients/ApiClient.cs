using KanjiAlive.Http;

namespace KanjiAlive.Clients
{
    /// <summary>
    ///     Abstract client for executing API calls.
    /// </summary>
    public abstract class ApiClient
    {
        /// <summary>
        ///     The connection implementation class contains all of the HTTP request and deserialization logic.
        /// </summary>
        internal readonly IConnection Connection;

        /// <summary>
        ///     Constructor for ApiClient.
        /// </summary>
        /// <param name="apiKey">
        ///     API key provided by Mashape. To obtain a key, navigate to the public API site:
        ///     https://market.mashape.com/kanjialive/learn-to-read-and-write-japanese-kanji.
        /// </param>
        protected ApiClient(string apiKey)
        {
            this.Connection = new Connection(apiKey);
        }
    }
}
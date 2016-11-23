using KanjiAlive.Http;

namespace KanjiAlive.Clients
{
    public abstract class ApiClient
    {
        /// <summary>
        /// The connection implementation class contains all of the HTTP request and deserialization logic.
        /// </summary>
        internal readonly IConnection _Connection;

        /// <summary>
        /// Constructor for ApiClient.
        /// </summary>
        /// <param name="ApiKey">
        /// API key provided by Mashape. To obtain a key, navigate to the public API site: https://market.mashape.com/kanjialive/learn-to-read-and-write-japanese-kanji.
        /// </param>
        public ApiClient(string ApiKey)
        {
            _Connection = new Connection(ApiKey);
        }
    }
}
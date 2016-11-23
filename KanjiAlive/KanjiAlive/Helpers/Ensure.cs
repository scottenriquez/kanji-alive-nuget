using System.Net;
using KanjiAlive.Exceptions;

namespace KanjiAlive.Helpers
{
    /// <summary>
    ///     A clean way to enforce assertions.
    /// </summary>
    public static class Ensure
    {
        /// <summary>
        ///     Ensure that the API key is not null or empty.
        /// </summary>
        /// <param name="apiKey">
        ///     API key provided by Mashape. To obtain a key, navigate to the public API site:
        ///     https://market.mashape.com/kanjialive/learn-to-read-and-write-japanese-kanji.
        /// </param>
        public static void ApiKeyNotNullOrEmpty(string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey))
            {
                throw new EmptyApiKeyException();
            }
        }

        /// <summary>
        ///     Ensure that the API key is validated by Mashape.
        /// </summary>
        /// <param name="httpStatusCode">
        ///     API response status code.
        /// </param>
        public static void ApiKeyIsValid(HttpStatusCode httpStatusCode)
        {
            if (httpStatusCode == HttpStatusCode.Forbidden)
            {
                throw new InvalidApiKeyException();
            }
        }

        /// <summary>
        ///     Ensure that an internal error did not occur on the API server.
        /// </summary>
        /// <param name="httpStatusCode">
        ///     API response status code.
        /// </param>
        public static void ResponseIsNotInternalServerError(HttpStatusCode httpStatusCode)
        {
            if (httpStatusCode == HttpStatusCode.InternalServerError)
            {
                throw new ApiInternalServerErrorException();
            }
        }
    }
}
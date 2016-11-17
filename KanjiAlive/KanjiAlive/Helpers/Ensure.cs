using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using KanjiAlive.Exceptions;

namespace KanjiAlive.Helpers
{
    /// <summary>
    /// A cleaner way to enforce assertions.
    /// </summary>
    public static class Ensure
    {
        /// <summary>
        /// Ensure that the API key is not null or empty.
        /// </summary>
        /// <param name="ApiKey">
        /// API key provided by Mashape. To obtain a key, navigate to the public API site: https://market.mashape.com/kanjialive/learn-to-read-and-write-japanese-kanji.
        /// </param>
        public static void ApiKeyNotNullOrEmpty(string ApiKey)
        {
            if (String.IsNullOrEmpty(ApiKey))
            {
                throw new EmptyApiKeyException();
            }
        }

        public static void ApiKeyIsValid(HttpStatusCode HttpStatusCode)
        {
            if (HttpStatusCode == HttpStatusCode.Forbidden)
            {
                throw new InvalidApiKeyException();
            }
        }

        public static void ResponseIsNotInternalServerError(HttpStatusCode HttpStatusCode)
        {
            if (HttpStatusCode == HttpStatusCode.InternalServerError)
            {
                throw new ApiInternalServerErrorException();
            }
        }
    }
}

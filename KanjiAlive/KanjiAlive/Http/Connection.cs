using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using KanjiAlive.Models.Response;

namespace KanjiAlive.Http
{
    public class Connection : IConnection
    {
        /// <summary>
        /// This is the standard .NET HTTP client that executes the requests.
        /// </summary>
        private readonly HttpClient _httpClient;

        /// <summary>
        /// API key provided by Mashape. To obtain a key, navigate to the public API site: https://market.mashape.com/kanjialive/learn-to-read-and-write-japanese-kanji.
        /// </summary>
        private readonly string _ApiKey;

        public Connection(string ApiKey)
        {
            _httpClient = new HttpClient();
            _ApiKey = ApiKey;
        }

        /// <summary>
        /// Executes a generic GET command.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="uri"></param>
        /// <returns></returns>
        public async Task<T> Get<T>(Uri uri)
        {
            HttpResponseMessage responseMessage = await _httpClient.GetAsync(uri);
            return await responseMessage.Content.ReadAsAsync<T>();
        }
    }
}

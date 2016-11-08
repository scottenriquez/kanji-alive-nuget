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

        public Connection()
        {
            _httpClient = new HttpClient();   
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

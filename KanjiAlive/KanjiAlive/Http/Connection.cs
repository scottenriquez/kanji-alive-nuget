using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
        public async Task<IApiResponse<T>> Get<T>(Uri Uri)
        {
            HttpRequestMessage RequestMessage = new HttpRequestMessage()
            {
                RequestUri = Uri,
                Method = HttpMethod.Get
            };
            RequestMessage.Headers.Add("X-Mashape-Key", _ApiKey);
            HttpResponseMessage ResponseMessage = await _httpClient.SendAsync(RequestMessage);
            string JsonResponse = await ResponseMessage.Content.ReadAsStringAsync();
            T DeserializedObject = JsonConvert.DeserializeObject<T>(JsonResponse);
            return new ApiResponse<T>()
            {
                Content = DeserializedObject,
                HttpResponse = new Response()
                {
                    Body = ResponseMessage.Content,
                    StatusCode = ResponseMessage.StatusCode,
                    ReasonPhrase = ResponseMessage.ReasonPhrase
                }
            };
        }
    }
}

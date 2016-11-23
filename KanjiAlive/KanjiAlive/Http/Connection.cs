using System;
using System.Net.Http;
using System.Threading.Tasks;
using KanjiAlive.Helpers;
using Newtonsoft.Json;

namespace KanjiAlive.Http
{
    /// <summary>
    ///     HTTP logic for consuming the Kanji Alive API.
    /// </summary>
    public class Connection : IConnection
    {
        /// <summary>
        ///     API key provided by Mashape. To obtain a key, navigate to the public API site:
        ///     https://market.mashape.com/kanjialive/learn-to-read-and-write-japanese-kanji.
        /// </summary>
        private readonly string _apiKey;

        /// <summary>
        ///     This is the standard .NET HTTP client that executes the requests.
        /// </summary>
        private readonly HttpClient _httpClient;

        /// <summary>
        ///     Constructor for Connection.
        /// </summary>
        /// <param name="apiKey">
        ///     API key provided by Mashape. To obtain a key, navigate to the public API site:
        ///     https://market.mashape.com/kanjialive/learn-to-read-and-write-japanese-kanji.
        /// </param>
        public Connection(string apiKey)
        {
            this._httpClient = new HttpClient();
            this._apiKey = apiKey;
        }

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
        public async Task<IApiResponse<T>> Get<T>(Uri uri)
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                RequestUri = uri,
                Method = HttpMethod.Get
            };
            //pass credentials to API
            requestMessage.Headers.Add("X-Mashape-Key", this._apiKey);
            HttpResponseMessage responseMessage = await this._httpClient.SendAsync(requestMessage);
            //validation
            Ensure.ApiKeyIsValid(responseMessage.StatusCode);
            Ensure.ResponseIsNotInternalServerError(responseMessage.StatusCode);
            //deserialization and formatting response
            T deserializedObject = this.DeserializeJson<T>(await responseMessage.Content.ReadAsStringAsync());
            return new ApiResponse<T>
            {
                Content = deserializedObject,
                HttpResponse = new Response
                {
                    Body = responseMessage.Content,
                    StatusCode = responseMessage.StatusCode,
                    ReasonPhrase = responseMessage.ReasonPhrase
                }
            };
        }

        /// <summary>
        ///     Deserializes a JSON string to an object of type T.
        /// </summary>
        /// <typeparam name="T">
        ///     The type which the JSON will be deserialized to.
        /// </typeparam>
        /// <param name="json">
        ///     The JSON string to be deserialized.
        /// </param>
        /// <returns>
        ///     The deserialized object.
        /// </returns>
        public T DeserializeJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
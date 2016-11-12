using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KanjiAlive.Http;
using KanjiAlive.Models.Response;

namespace KanjiAlive.Clients
{
    public class BasicSearchClient : ApiClient, IBasicSearchClient
    {
        /// <summary>
        /// The base URI for the basic search.
        /// https://kanjialive-api.p.mashape.com/api/public/search/{query}
        /// </summary>
        private static readonly Uri BaseUri = new Uri("https://kanjialive-api.p.mashape.com/api/public/search/");

        /// <summary>
        /// API key provided by Mashape. To obtain a key, navigate to the public API site: https://market.mashape.com/kanjialive/learn-to-read-and-write-japanese-kanji.
        /// </summary>
        private readonly string _ApiKey;

        /// <summary>
        /// Constructor for BasicSearchClient
        /// </summary>
        /// <param name="ApiKey"></param>
        public BasicSearchClient(string ApiKey) : base(ApiKey)
        {
            _ApiKey = ApiKey;
        }

        /// <summary>
        /// Executes the GET verb for the basic search.
        /// </summary>
        /// <param name="kanji"></param>
        /// <returns></returns>
        public async Task<IApiResponse<List<KanjiSimpleResponse>>> Get(string kanji)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, kanji));
        }
    }
}

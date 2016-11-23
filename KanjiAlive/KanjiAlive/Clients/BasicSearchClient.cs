using System;
using System.Collections.Generic;
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
        /// Constructor for BasicSearchClient.
        /// </summary>
        /// <param name="ApiKey">
        /// API key provided by Mashape. To obtain a key, navigate to the public API site: https://market.mashape.com/kanjialive/learn-to-read-and-write-japanese-kanji.
        /// </param>
        public BasicSearchClient(string ApiKey) : base(ApiKey)
        {
            _ApiKey = ApiKey;
        }

        /// <summary>
        /// Search by a kanji character, onyomi reading (katakana), kunyomi reading (hiragana) or a kanji's simplified English meaning.
        /// </summary>
        /// <param name="Query">
        /// A kanji character, onyomi reading (katakana), kunyomi reading (hiragana) or a kanji's simplified English meaning.
        /// </param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        public async Task<IApiResponse<List<KanjiSimpleResponse>>> Search(string Query)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, Query));
        }
    }
}

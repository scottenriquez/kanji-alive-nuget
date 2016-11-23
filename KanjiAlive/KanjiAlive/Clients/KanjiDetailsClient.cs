using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KanjiAlive.Http;
using KanjiAlive.Models.Response;

namespace KanjiAlive.Clients
{
    /// <summary>
    ///     Client for getting kanji details.
    /// </summary>
    public class KanjiDetailsClient : ApiClient, IKanjiDetailsClient
    {
        /// <summary>
        ///     Constant parameter for the all kanji details endpoint: https://kanjialive-api.p.mashape.com/api/public/kanji/all.
        /// </summary>
        private const string ALL = "all";

        /// <summary>
        ///     The base URI for the kanji details search.
        ///     https://kanjialive-api.p.mashape.com/api/public/kanji/{kanji}
        /// </summary>
        private static readonly Uri BaseUri = new Uri("https://kanjialive-api.p.mashape.com/api/public/kanji/");

        /// <summary>
        ///     API key provided by Mashape. To obtain a key, navigate to the public API site:
        ///     https://market.mashape.com/kanjialive/learn-to-read-and-write-japanese-kanji.
        /// </summary>
        private readonly string _apiKey;

        /// <summary>
        ///     Constructor for KanjiDetailsClient.
        /// </summary>
        /// <param name="apiKey">
        ///     API key provided by Mashape. To obtain a key, navigate to the public API site:
        ///     https://market.mashape.com/kanjialive/learn-to-read-and-write-japanese-kanji.
        /// </param>
        public KanjiDetailsClient(string apiKey) : base(apiKey)
        {
            this._apiKey = apiKey;
        }

        /// <summary>
        ///     Search for a single kanji character.
        /// </summary>
        /// <param name="kanji">
        ///     A single kanji character.
        /// </param>
        /// <returns>
        ///     The API response and detailed metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        public async Task<IApiResponse<KanjiDetailedResponse>> GetSingleKanjiDetails(string kanji)
        {
            return await this.Connection.Get<KanjiDetailedResponse>(new Uri(BaseUri, kanji));
        }

        /// <summary>
        ///     Fetch all kanji characters and their respective metadata.
        /// </summary>
        /// <returns>
        ///     The API response and detailed metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        public async Task<IApiResponse<List<KanjiDetailedResponse>>> GetAllKanjiDetails()
        {
            return await this.Connection.Get<List<KanjiDetailedResponse>>(new Uri(BaseUri, ALL));
        }
    }
}
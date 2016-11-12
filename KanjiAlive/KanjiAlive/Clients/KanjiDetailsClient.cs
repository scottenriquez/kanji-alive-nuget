using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KanjiAlive.Http;
using KanjiAlive.Models.Response;

namespace KanjiAlive.Clients
{
    public class KanjiDetailsClient : ApiClient, IKanjiDetailsClient
    {
        /// <summary>
        /// The base URI for the kanji details search.
        /// https://kanjialive-api.p.mashape.com/api/public/kanji/{kanji}
        /// </summary>
        private static readonly Uri BaseUri = new Uri("https://kanjialive-api.p.mashape.com/api/public/kanji/");

        /// <summary>
        /// Constant parameter for the all kanji details endpoint: https://kanjialive-api.p.mashape.com/api/public/kanji/all.
        /// </summary>
        private const string ALL = "all";

        /// <summary>
        /// API key provided by Mashape. To obtain a key, navigate to the public API site: https://market.mashape.com/kanjialive/learn-to-read-and-write-japanese-kanji.
        /// </summary>
        private readonly string _ApiKey;

        /// <summary>
        /// Constructor for KanjiDetailsClient
        /// </summary>
        /// <param name="ApiKey"></param>
        public KanjiDetailsClient(string ApiKey) : base(ApiKey)
        {
            _ApiKey = ApiKey;
        }

        /// <summary>
        /// Executes the GET verb for the kanji details search.
        /// </summary>
        /// <param name="kanji"></param>
        /// <returns></returns>
        public async Task<IApiResponse<KanjiDetailedResponse>> GetSingleKanjiDetails(string kanji)
        {
            return await _Connection.Get<KanjiDetailedResponse>(new Uri(BaseUri, kanji));
        }

        /// <summary>
        /// Executes the GET verb for the kanji details search.
        /// </summary>
        /// <param name="kanji"></param>
        /// <returns></returns>
        public async Task<IApiResponse<List<KanjiDetailedResponse>>> GetAllKanjiDetails()
        {
            return await _Connection.Get<List<KanjiDetailedResponse>>(new Uri(BaseUri, ALL));
        }
    }
}
using System;
using KanjiAlive.Clients;
using KanjiAlive.Helpers;

namespace KanjiAlive
{
    /// <summary>
    ///     Client for the Kanji Alive public API. The documentation is located here:
    ///     https://github.com/scottenriquez/kanji-alive-nuget.
    /// </summary>
    public class KanjiAliveClient : IKanjiAliveClient
    {
        /// <summary>
        ///     The base address for the Kanji Alive API
        /// </summary>
        public static readonly Uri KanjiAliveApiUri = new Uri("https://kanjialive-api.p.mashape.com/api/public/");

        /// <summary>
        ///     Creates a new instance of the Kanji Alive client to hit the public API.
        /// </summary>
        /// <param name="apiKey">
        ///     API key provided by Mashape. To obtain a key, navigate to the public API site:
        ///     https://market.mashape.com/kanjialive/learn-to-read-and-write-japanese-kanji.
        /// </param>
        public KanjiAliveClient(string apiKey)
        {
            Ensure.ApiKeyNotNullOrEmpty(apiKey);
            this.ApiKey = apiKey;
            this.BasicSearchClient = new BasicSearchClient(this.ApiKey);
            this.AdvancedSearchClient = new AdvancedSearchClient(this.ApiKey);
            this.KanjiDetailsClient = new KanjiDetailsClient(this.ApiKey);
        }

        /// <summary>
        ///     API key provided by Mashape. To obtain a key, navigate to the public API site:
        ///     https://market.mashape.com/kanjialive/learn-to-read-and-write-japanese-kanji.
        /// </summary>
        public string ApiKey { get; }

        /// <summary>
        ///     Client for executing basic kanji search.
        /// </summary>
        public BasicSearchClient BasicSearchClient { get; private set; }

        /// <summary>
        ///     Client for executing advanced kanji search.
        /// </summary>
        public AdvancedSearchClient AdvancedSearchClient { get; private set; }

        /// <summary>
        ///     Client for obtaining details about a kanji.
        /// </summary>
        public KanjiDetailsClient KanjiDetailsClient { get; private set; }
    }
}
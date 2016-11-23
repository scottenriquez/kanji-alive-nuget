using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KanjiAlive.Http;
using KanjiAlive.Models.Response;

namespace KanjiAlive.Clients
{
    public class AdvancedSearchClient : ApiClient, IAdvancedSearchClient
    {
        /// <summary>
        /// The base URI for the advanced.
        /// https://kanjialive-api.p.mashape.com/api/public/search/advanced/?{parameter}={query}
        /// </summary>
        private static readonly Uri BaseUri = new Uri("https://kanjialive-api.p.mashape.com/api/public/search/advanced/");

        /// <summary>
        /// The query parameter in the HTTP GET URL for a search by kanji character.
        /// </summary>
        private const string KANJI_URL_PARAMETER = "?kanji=";

        /// <summary>
        /// The query parameter in the HTTP GET URL for a serach by kanji English meaning.
        /// </summary>
        private const string KEM_URL_PARAMETER = "?kem=";

        /// <summary>
        /// The query parameter in the HTTP GET URL for a search by grade level.
        /// </summary>
        private const string GRADE_URL_PARAMETER = "?grade=";

        /// <summary>
        /// The query parameter in the HTTP GET URL for a search by the number of strokes.
        /// </summary>
        private const string STROKES_URL_PARAMETER = "?ks=";

        /// <summary>
        /// The query parameter in the HTTP GET URL for a search by kunyomi.
        /// </summary>
        private const string KUNYOMI_URL_PARAMETER = "?kun=";

        /// <summary>
        /// The query parameter in the HTTP GET URL for a search by onyomi.
        /// </summary>
        private const string ONYOMI_URL_PARAMETER = "?on=";

        /// <summary>
        /// The query parameter in the HTTP GET URL for a search by radical English meaning.
        /// </summary>
        private const string RADICAL_ENGLISH_MEANING_URL_PARAMETER = "?rem=";

        /// <summary>
        /// The query parameter in the HTTP GET URL for a search by radical Japanese meaning.
        /// </summary>
        private const string RADICAL_JAPANESE_NAME_URL_PARAMETER = "?rjn=";

        /// <summary>
        /// The query parameter in the HTTP GET URL for a search by radical position.
        /// </summary>
        private const string RADICAL_POSITION_URL_PARAMETER = "?rpos=";

        /// <summary>
        /// The query parameter in the HTTP GET URL for a search by radical stroke number.
        /// </summary>
        private const string RADICAL_STROKE_NUMBER_URL_PARAMETER = "?rs=";

        /// <summary>
        /// The query parameter in the HTTP GET URL for a search by AP Exam chapter.
        /// </summary>
        private const string AP_EXAM_URL_PARAMETER = "?list=ap:c";

        /// <summary>
        /// The query parameter in the HTTP GET URL for a search by Macquarie chapter number.
        /// </summary>
        private const string MACQUARIE_URL_PARAMETER = "?list=mac:c";

        /// <summary>
        /// API key provided by Mashape. To obtain a key, navigate to the public API site: https://market.mashape.com/kanjialive/learn-to-read-and-write-japanese-kanji.
        /// </summary>
        private readonly string _ApiKey;

        /// <summary>
        /// Constructor for AdvancedSearchClient.
        /// </summary>
        /// <param name="ApiKey">
        /// API key provided by Mashape. To obtain a key, navigate to the public API site: https://market.mashape.com/kanjialive/learn-to-read-and-write-japanese-kanji.
        /// </param>
        public AdvancedSearchClient(string ApiKey) : base(ApiKey)
        {
            _ApiKey = ApiKey;
        }

        /// <summary>
        /// Search by kanji character.
        /// </summary>
        /// <param name="Kanji">
        /// A single kanji character.
        /// </param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        public async Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByKanjiCharacter(string Kanji)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, KANJI_URL_PARAMETER + Kanji));
        }

        /// <summary>
        /// Search for kanji by the English meaning for a kanji character.
        /// </summary>
        /// <param name="KanjiEnglishMeaning">
        /// The English meaning for a kanji character.
        /// </param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        public async Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByKanjiEnglishMeaning(string KanjiEnglishMeaning)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, KEM_URL_PARAMETER + KanjiEnglishMeaning));
        }

        /// <summary>
        /// Search by the grade level for a kanji character.
        /// </summary>
        /// <param name="Grade">
        /// A number for the grade level.
        /// </param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        public async Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByKanjiGradeLevel(int Grade)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, GRADE_URL_PARAMETER + Grade));
        }

        /// <summary>
        /// Search by the number of strokes for a kanji character.
        /// </summary>
        /// <param name="Strokes">
        /// The number of strokes.
        /// </param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        public async Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByKanjiStrokeNumber(int Strokes)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, STROKES_URL_PARAMETER + Strokes));
        }

        /// <summary>
        /// Search by the romaji or hiragana text for the kunyomi of a kanji character.
        /// </summary>
        /// <param name="Kunyomi">
        /// The romaji or hiragana for the kunyomi.
        /// </param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        public async Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByKunyomiReading(string Kunyomi)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, KUNYOMI_URL_PARAMETER + Kunyomi));
        }

        /// <summary>
        /// Search by the romaji or katakana text for the onyomi of a kanji character.
        /// </summary>
        /// <param name="Onyomi">
        /// The romaji or katakana for the onyomi.
        /// </param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        public async Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByOnyomiReading(string Onyomi)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, ONYOMI_URL_PARAMETER + Onyomi));
        }

        /// <summary>
        /// Search by the English meaning for a radical.
        /// </summary>
        /// <param name="RadicalEnglishMeaning">
        /// The English meaning for the radical.
        /// </param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        public async Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByRadicalEnglishMeaning(string RadicalEnglishMeaning)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, RADICAL_ENGLISH_MEANING_URL_PARAMETER + RadicalEnglishMeaning));
        }

        /// <summary>
        /// Search by the Japanese name for a radical.
        /// </summary>
        /// <param name="RadicalJapaneseName">
        /// The romaji or hiragana for a radical's Japanese name.
        /// </param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        public async Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByRadicalJapaneseName(string RadicalJapaneseName)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, RADICAL_JAPANESE_NAME_URL_PARAMETER + RadicalJapaneseName));
        }

        /// <summary>
        /// Search by the radical position for a kanji.
        /// </summary>
        /// <param name="RadicalPosition">
        /// The radical position in hiragana or romaji.
        /// </param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        public async Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByRadicalPosition(string RadicalPosition)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, RADICAL_POSITION_URL_PARAMETER + RadicalPosition));
        }

        /// <summary>
        /// Search for kanji by the number of radical strokes.
        /// </summary>
        /// <param name="RadicalStrokeNumber">
        /// The number of strokes for a radical.
        /// </param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        public async Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByRadicalStrokeNumber(int RadicalStrokeNumber)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, RADICAL_STROKE_NUMBER_URL_PARAMETER + RadicalStrokeNumber));
        }

        /// <summary>
        /// Search for kanji by the AP Exam chapter number.
        /// </summary>
        /// <param name="Chapter">
        /// The AP Exam chapter number.
        /// </param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        public async Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByApExamChapter(int Chapter)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, AP_EXAM_URL_PARAMETER + Chapter));
        }

        /// <summary>
        /// Search for kanji by the Macquarie chapter number.
        /// </summary>
        /// <param name="Chapter">The Macquarie chapter number.</param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        public async Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByMacquarieChapter(int Chapter)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, MACQUARIE_URL_PARAMETER + Chapter));
        }
    }
}
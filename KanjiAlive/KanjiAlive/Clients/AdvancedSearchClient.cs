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

        public const string GET_KANJI_URL_PARAMETER = "?kanji=";
        public const string GET_KEM_URL_PARAMETER = "?kem=";
        public const string GET_GRADE_URL_PARAMETER = "?grade=";
        public const string GET_STROKES_URL_PARAMETER = "?ks=";
        public const string GET_KUNYOMI_URL_PARAMETER = "?kun=";
        public const string GET_ONYOMI_URL_PARAMETER = "?on=";
        public const string GET_RADICAL_ENGLISH_MEANING_URL_PARAMETER = "?rem=";
        public const string GET_RADICAL_JAPANESE_NAME_URL_PARAMETER = "?rjn=";
        public const string GET_RADICAL_POSITION_URL_PARAMETER = "?rpos=";
        public const string GET_RADICAL_STROKE_NUMBER_URL_PARAMETER = "?rs=";
        public const string GET_STUDY_LIST_URL_PARAMETER = "?list=";

        /// <summary>
        /// API key provided by Mashape. To obtain a key, navigate to the public API site: https://market.mashape.com/kanjialive/learn-to-read-and-write-japanese-kanji.
        /// </summary>
        private readonly string _ApiKey;

        /// <summary>
        /// Constructor for AdvancedSearchClient
        /// </summary>
        /// <param name="ApiKey"></param>
        public AdvancedSearchClient(string ApiKey) : base(ApiKey)
        {
            _ApiKey = ApiKey;
        }

        public async Task<IApiResponse<List<KanjiSimpleResponse>>> GetByKanjiCharacter(string Kanji)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, GET_KANJI_URL_PARAMETER + Kanji));
        }

        public async Task<IApiResponse<List<KanjiSimpleResponse>>> GetByKanjiEnglishMeaning(string KanjiEnglishMeaning)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, GET_KEM_URL_PARAMETER + KanjiEnglishMeaning));
        }

        public async Task<IApiResponse<List<KanjiSimpleResponse>>> GetByKanjiGradeLevel(int Grade)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, GET_GRADE_URL_PARAMETER + Grade));
        }

        public async Task<IApiResponse<List<KanjiSimpleResponse>>> GetByKanjiStrokeNumber(int Strokes)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, GET_STROKES_URL_PARAMETER + Strokes));
        }

        public async Task<IApiResponse<List<KanjiSimpleResponse>>> GetByKunyomiReading(string Kunyomi)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, GET_KUNYOMI_URL_PARAMETER + Kunyomi));
        }

        public async Task<IApiResponse<List<KanjiSimpleResponse>>> GetByOnyomiReading(string Onyomi)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, GET_GRADE_URL_PARAMETER + Onyomi));
        }

        public async Task<IApiResponse<List<KanjiSimpleResponse>>> GetByRadicalEnglishMeaning(string RadicalEnglishMeaning)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, GET_RADICAL_ENGLISH_MEANING_URL_PARAMETER + RadicalEnglishMeaning));
        }

        public async Task<IApiResponse<List<KanjiSimpleResponse>>> GetByRadicalJapaneseName(string RadicalJapaneseName)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, GET_RADICAL_JAPANESE_NAME_URL_PARAMETER + RadicalJapaneseName));
        }

        public async Task<IApiResponse<List<KanjiSimpleResponse>>> GetByRadicalPosition(string RadicalPosition)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, GET_RADICAL_POSITION_URL_PARAMETER + RadicalPosition));
        }

        public async Task<IApiResponse<List<KanjiSimpleResponse>>> GetByRadicalStrokeNumber(int RadicalStrokeNumber)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, GET_RADICAL_STROKE_NUMBER_URL_PARAMETER + RadicalStrokeNumber));
        }

        public async Task<IApiResponse<List<KanjiSimpleResponse>>> GetByApExamChapter(int Chapter)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, GET_STUDY_LIST_URL_PARAMETER + Chapter));
        }

        public async Task<IApiResponse<List<KanjiSimpleResponse>>> GetByMacquarieChapter(int Chapter)
        {
            return await _Connection.Get<List<KanjiSimpleResponse>>(new Uri(BaseUri, GET_STUDY_LIST_URL_PARAMETER + Chapter));
        }
    }
}
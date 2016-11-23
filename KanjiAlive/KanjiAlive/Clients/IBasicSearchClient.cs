using System.Collections.Generic;
using System.Threading.Tasks;
using KanjiAlive.Http;
using KanjiAlive.Models.Response;

namespace KanjiAlive.Clients
{
    /// <summary>
    ///     Client for executing basic searches.
    /// </summary>
    public interface IBasicSearchClient
    {
        /// <summary>
        ///     Search by a kanji character, onyomi reading (katakana), kunyomi reading (hiragana) or a kanji's simplified English
        ///     meaning.
        /// </summary>
        /// <param name="query">
        ///     A kanji character, onyomi reading (katakana), kunyomi reading (hiragana) or a kanji's simplified English meaning.
        /// </param>
        /// <returns>
        ///     The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> Search(string query);
    }
}
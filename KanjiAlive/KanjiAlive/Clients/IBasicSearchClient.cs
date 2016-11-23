using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KanjiAlive.Http;
using KanjiAlive.Models.Response;

namespace KanjiAlive.Clients
{
    public interface IBasicSearchClient
    {
        /// <summary>
        /// Search by a kanji character, onyomi reading (katakana), kunyomi reading (hiragana) or a kanji's simplified English meaning.
        /// </summary>
        /// <param name="Query">
        /// A kanji character, onyomi reading (katakana), kunyomi reading (hiragana) or a kanji's simplified English meaning.
        /// </param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> Search(string Query);
    }
}

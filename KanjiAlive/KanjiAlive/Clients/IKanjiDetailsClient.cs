using System.Collections.Generic;
using System.Threading.Tasks;
using KanjiAlive.Http;
using KanjiAlive.Models.Response;

namespace KanjiAlive.Clients
{
    public interface IKanjiDetailsClient
    {
        /// <summary>
        /// Search for a single kanji character.
        /// </summary>
        /// <param name="Kanji">
        /// A single kanji character.
        /// </param>
        /// <returns>
        /// The API response and detailed metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<KanjiDetailedResponse>> GetSingleKanjiDetails(string Kanji);

        /// <summary>
        /// Fetch all kanji characters and their respective metadata.
        /// </summary>
        /// <returns>
        /// The API response and detailed metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiDetailedResponse>>> GetAllKanjiDetails();
    }
}

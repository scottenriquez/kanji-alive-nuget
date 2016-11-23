using System.Collections.Generic;
using System.Threading.Tasks;
using KanjiAlive.Http;
using KanjiAlive.Models.Response;

namespace KanjiAlive.Clients
{
    /// <summary>
    ///     Client for getting kanji details.
    /// </summary>
    public interface IKanjiDetailsClient
    {
        /// <summary>
        ///     Search for a single kanji character.
        /// </summary>
        /// <param name="kanji">
        ///     A single kanji character.
        /// </param>
        /// <returns>
        ///     The API response and detailed metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<KanjiDetailedResponse>> GetSingleKanjiDetails(string kanji);

        /// <summary>
        ///     Fetch all kanji characters and their respective metadata.
        /// </summary>
        /// <returns>
        ///     The API response and detailed metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiDetailedResponse>>> GetAllKanjiDetails();
    }
}
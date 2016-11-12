using System.Collections.Generic;
using System.Threading.Tasks;
using KanjiAlive.Http;
using KanjiAlive.Models.Response;

namespace KanjiAlive.Clients
{
    public interface IKanjiDetailsClient
    {
        Task<IApiResponse<KanjiDetailedResponse>> GetSingleKanjiDetails(string kanji);
        Task<IApiResponse<List<KanjiDetailedResponse>>> GetAllKanjiDetails();
    }
}

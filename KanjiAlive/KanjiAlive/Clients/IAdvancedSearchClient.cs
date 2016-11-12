using System.Collections.Generic;
using System.Threading.Tasks;
using KanjiAlive.Http;
using KanjiAlive.Models.Response;

namespace KanjiAlive.Clients
{
    public interface IAdvancedSearchClient
    {
        Task<IApiResponse<List<KanjiSimpleResponse>>> GetByKanjiCharacter(string Kanji);
        Task<IApiResponse<List<KanjiSimpleResponse>>> GetByKanjiEnglishMeaning(string KanjiEnglishMeaning);
        Task<IApiResponse<List<KanjiSimpleResponse>>> GetByKanjiGradeLevel(int Grade);
        Task<IApiResponse<List<KanjiSimpleResponse>>> GetByKunyomiReading(string Kunyomi);
        Task<IApiResponse<List<KanjiSimpleResponse>>> GetByOnyomiReading(string Onyomi);
        Task<IApiResponse<List<KanjiSimpleResponse>>> GetByRadicalEnglishMeaning(string RadicalEnglishMeaning);
        Task<IApiResponse<List<KanjiSimpleResponse>>> GetByRadicalJapaneseName(string RadicalJapaneseName);
        Task<IApiResponse<List<KanjiSimpleResponse>>> GetByRadicalPosition(string RadicalPosition);
        Task<IApiResponse<List<KanjiSimpleResponse>>> GetByRadicalStrokeNumber(int RadicalStrokeNumber);
        Task<IApiResponse<List<KanjiSimpleResponse>>> GetByApExamChapter(int Chapter);
        Task<IApiResponse<List<KanjiSimpleResponse>>> GetByMacquarieChapter(int Chapter);
    }
}

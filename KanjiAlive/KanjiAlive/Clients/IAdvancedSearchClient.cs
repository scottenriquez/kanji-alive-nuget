using System.Collections.Generic;
using System.Threading.Tasks;
using KanjiAlive.Http;
using KanjiAlive.Models.Response;

namespace KanjiAlive.Clients
{
    public interface IAdvancedSearchClient
    {
        /// <summary>
        /// Search by kanji character.
        /// </summary>
        /// <param name="Kanji">
        /// A single kanji character.
        /// </param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByKanjiCharacter(string Kanji);

        /// <summary>
        /// Search for kanji by the English meaning for a kanji character.
        /// </summary>
        /// <param name="KanjiEnglishMeaning">
        /// The English meaning for a kanji character.
        /// </param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByKanjiEnglishMeaning(string KanjiEnglishMeaning);

        /// <summary>
        /// Search by the grade level for a kanji character.
        /// </summary>
        /// <param name="Grade">
        /// A number for the grade level.
        /// </param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByKanjiGradeLevel(int Grade);

        /// <summary>
        /// Search by the number of strokes for a kanji character.
        /// </summary>
        /// <param name="Strokes">
        /// The number of strokes.
        /// </param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByKanjiStrokeNumber(int Strokes);

        /// <summary>
        /// Search by the romaji or hiragana text for the kunyomi of a kanji character.
        /// </summary>
        /// <param name="Kunyomi">
        /// The romaji or hiragana for the kunyomi.
        /// </param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByKunyomiReading(string Kunyomi);

        /// <summary>
        /// Search by the romaji or katakana text for the onyomi of a kanji character.
        /// </summary>
        /// <param name="Onyomi">
        /// The romaji or katakana for the onyomi.
        /// </param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByOnyomiReading(string Onyomi);

        /// <summary>
        /// Search by the English meaning for a radical.
        /// </summary>
        /// <param name="RadicalEnglishMeaning">
        /// The English meaning for the radical.
        /// </param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByRadicalEnglishMeaning(string RadicalEnglishMeaning);

        /// <summary>
        /// Search by the Japanese name for a radical.
        /// </summary>
        /// <param name="RadicalJapaneseName">
        /// The romaji or hiragana for a radical's Japanese name.
        /// </param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByRadicalJapaneseName(string RadicalJapaneseName);

        /// <summary>
        /// Search by the radical position for a kanji.
        /// </summary>
        /// <param name="RadicalPosition">
        /// The radical position in hiragana or romaji.
        /// </param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByRadicalPosition(string RadicalPosition);

        /// <summary>
        /// Search for kanji by the number of radical strokes.
        /// </summary>
        /// <param name="RadicalStrokeNumber">
        /// The number of strokes for a radical.
        /// </param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByRadicalStrokeNumber(int RadicalStrokeNumber);

        /// <summary>
        /// Search for kanji by the AP Exam chapter number.
        /// </summary>
        /// <param name="Chapter">
        /// The AP Exam chapter number.
        /// </param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByApExamChapter(int Chapter);

        /// <summary>
        /// Search for kanji by the Macquarie chapter number.
        /// </summary>
        /// <param name="Chapter">The Macquarie chapter number.</param>
        /// <returns>
        /// The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByMacquarieChapter(int Chapter);
    }
}

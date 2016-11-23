using System.Collections.Generic;
using System.Threading.Tasks;
using KanjiAlive.Http;
using KanjiAlive.Models.Response;

namespace KanjiAlive.Clients
{
    /// <summary>
    ///     Client for executing advanced searches.
    /// </summary>
    public interface IAdvancedSearchClient
    {
        /// <summary>
        ///     Search by kanji character.
        /// </summary>
        /// <param name="kanji">
        ///     A single kanji character.
        /// </param>
        /// <returns>
        ///     The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByKanjiCharacter(string kanji);

        /// <summary>
        ///     Search for kanji by the English meaning for a kanji character.
        /// </summary>
        /// <param name="kanjiEnglishMeaning">
        ///     The English meaning for a kanji character.
        /// </param>
        /// <returns>
        ///     The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByKanjiEnglishMeaning(string kanjiEnglishMeaning);

        /// <summary>
        ///     Search by the grade level for a kanji character.
        /// </summary>
        /// <param name="grade">
        ///     A number for the grade level.
        /// </param>
        /// <returns>
        ///     The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByKanjiGradeLevel(int grade);

        /// <summary>
        ///     Search by the number of strokes for a kanji character.
        /// </summary>
        /// <param name="strokes">
        ///     The number of strokes.
        /// </param>
        /// <returns>
        ///     The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByKanjiStrokeNumber(int strokes);

        /// <summary>
        ///     Search by the romaji or hiragana text for the kunyomi of a kanji character.
        /// </summary>
        /// <param name="kunyomi">
        ///     The romaji or hiragana for the kunyomi.
        /// </param>
        /// <returns>
        ///     The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByKunyomiReading(string kunyomi);

        /// <summary>
        ///     Search by the romaji or katakana text for the onyomi of a kanji character.
        /// </summary>
        /// <param name="onyomi">
        ///     The romaji or katakana for the onyomi.
        /// </param>
        /// <returns>
        ///     The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByOnyomiReading(string onyomi);

        /// <summary>
        ///     Search by the English meaning for a radical.
        /// </summary>
        /// <param name="radicalEnglishMeaning">
        ///     The English meaning for the radical.
        /// </param>
        /// <returns>
        ///     The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByRadicalEnglishMeaning(string radicalEnglishMeaning);

        /// <summary>
        ///     Search by the Japanese name for a radical.
        /// </summary>
        /// <param name="radicalJapaneseName">
        ///     The romaji or hiragana for a radical's Japanese name.
        /// </param>
        /// <returns>
        ///     The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByRadicalJapaneseName(string radicalJapaneseName);

        /// <summary>
        ///     Search by the radical position for a kanji.
        /// </summary>
        /// <param name="radicalPosition">
        ///     The radical position in hiragana or romaji.
        /// </param>
        /// <returns>
        ///     The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByRadicalPosition(string radicalPosition);

        /// <summary>
        ///     Search for kanji by the number of radical strokes.
        /// </summary>
        /// <param name="radicalStrokeNumber">
        ///     The number of strokes for a radical.
        /// </param>
        /// <returns>
        ///     The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByRadicalStrokeNumber(int radicalStrokeNumber);

        /// <summary>
        ///     Search for kanji by the AP Exam chapter number.
        /// </summary>
        /// <param name="chapter">
        ///     The AP Exam chapter number.
        /// </param>
        /// <returns>
        ///     The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByApExamChapter(int chapter);

        /// <summary>
        ///     Search for kanji by the Macquarie chapter number.
        /// </summary>
        /// <param name="chapter">The Macquarie chapter number.</param>
        /// <returns>
        ///     The API response and basic metadata about the kanji character(s) that match the search criteria.
        /// </returns>
        Task<IApiResponse<List<KanjiSimpleResponse>>> SearchByMacquarieChapter(int chapter);
    }
}
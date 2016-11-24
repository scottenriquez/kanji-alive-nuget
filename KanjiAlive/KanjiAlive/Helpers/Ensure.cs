using System.Net;
using KanjiAlive.Exceptions;

namespace KanjiAlive.Helpers
{
    /// <summary>
    ///     A clean way to enforce assertions.
    /// </summary>
    public static class Ensure
    {
        /// <summary>
        ///     Ensure that the API key is not null or empty.
        /// </summary>
        /// <param name="apiKey">
        ///     API key provided by Mashape. To obtain a key, navigate to the public API site:
        ///     https://market.mashape.com/kanjialive/learn-to-read-and-write-japanese-kanji.
        /// </param>
        public static void ApiKeyNotNullOrEmpty(string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey))
            {
                throw new EmptyApiKeyException();
            }
        }

        /// <summary>
        ///     Ensure that the API key is validated by Mashape.
        /// </summary>
        /// <param name="httpStatusCode">
        ///     API response status code.
        /// </param>
        public static void ApiKeyIsValid(HttpStatusCode httpStatusCode)
        {
            if (httpStatusCode == HttpStatusCode.Forbidden)
            {
                throw new InvalidApiKeyException();
            }
        }

        /// <summary>
        ///     Ensure that an internal error did not occur on the API server.
        /// </summary>
        /// <param name="httpStatusCode">
        ///     API response status code.
        /// </param>
        public static void ResponseIsNotInternalServerError(HttpStatusCode httpStatusCode)
        {
            if (httpStatusCode == HttpStatusCode.InternalServerError)
            {
                throw new ApiInternalServerErrorException();
            }
        }

        /// <summary>
        ///     Ensure that a kanji grade level is between 1 and 6.
        /// </summary>
        /// <param name="kanjiGradeLevel">
        ///     The grade level at which a kanji is learned.
        /// </param>
        public static void KanjiGradeLevelIsValid(int kanjiGradeLevel)
        {
            if (kanjiGradeLevel < 1 || kanjiGradeLevel > 6)
            {
                throw new InvalidKanjiGradeLevelException();
            }
        }

        /// <summary>
        ///     Ensure that an AP Exam chapter is between 1 and 20.
        /// </summary>
        /// <param name="apExamChapter">
        ///     The AP exam chapter when a kanji is learned.
        /// </param>
        public static void ApExamChapterIsValid(int apExamChapter)
        {
            if (apExamChapter < 1 || apExamChapter > 20)
            {
                throw new InvalidApExamChapterException();
            }
        }

        /// <summary>
        ///     Ensure that a Macquarie chapter is between 12 and 22.
        /// </summary>
        /// <param name="macquarieChapter">
        ///     The Macquarie chapter when a kanji is learned.
        /// </param>
        public static void MacquarieChapterIsValid(int macquarieChapter)
        {
            if (macquarieChapter < 12 || macquarieChapter > 22)
            {
                throw new InvalidMacquarieChapterException();
            }
        }
    }
}
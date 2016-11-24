using System;

namespace KanjiAlive.Exceptions
{
    /// <summary>
    ///     Thrown when the kanji grade level provided is not between 1 and 6.
    /// </summary>
    public class InvalidKanjiGradeLevelException : Exception
    {
        /// <summary>
        ///     Constructor for InvalidKanjiGradeLevelException.
        /// </summary>
        public InvalidKanjiGradeLevelException() : base("The valid kanji grade levels are 1-6.")
        {
        }
    }
}
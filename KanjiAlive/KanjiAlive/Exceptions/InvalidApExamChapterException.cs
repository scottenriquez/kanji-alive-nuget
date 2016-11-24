using System;

namespace KanjiAlive.Exceptions
{
    /// <summary>
    ///     Thrown when the AP Exam chapter supplied is not between 1 and 20 inclusive.
    /// </summary>
    public class InvalidApExamChapterException : Exception
    {
        /// <summary>
        ///     Constructor for InvalidApExamChapterException.
        /// </summary>
        public InvalidApExamChapterException() : base("The valid AP Exam chapters are 1-20.")
        {
        }
    }
}
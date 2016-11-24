using System;

namespace KanjiAlive.Exceptions
{
    /// <summary>
    ///     Thrown when the Macquarie chapter supplied is not between 12 and 22 inclusive.
    /// </summary>
    public class InvalidMacquarieChapterException : Exception
    {
        /// <summary>
        ///     Constructor for InvalidMacquarieChapterException.
        /// </summary>
        public InvalidMacquarieChapterException() : base("The valid Macquarie chapters are 12-22.")
        {
        }
    }
}
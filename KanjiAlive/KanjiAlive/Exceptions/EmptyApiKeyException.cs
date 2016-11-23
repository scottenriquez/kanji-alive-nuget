using System;

namespace KanjiAlive.Exceptions
{
    /// <summary>
    ///     Thrown when the API key supplied is null or empty.
    /// </summary>
    public class EmptyApiKeyException : Exception
    {
        /// <summary>
        ///     Constructor for EmptyApiKeyException.
        /// </summary>
        public EmptyApiKeyException() : base("The API key provided is empty or null.")
        {
        }
    }
}
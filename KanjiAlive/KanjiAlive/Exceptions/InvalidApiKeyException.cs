using System;

namespace KanjiAlive.Exceptions
{
    /// <summary>
    /// Thrown when the API key provided is invalid.
    /// </summary>
    public class InvalidApiKeyException : Exception
    {
        /// <summary>
        /// Constructor for InvalidApiKeyException.
        /// </summary>
        public InvalidApiKeyException() : base("The API key provided is invalid.")
        {
            
        }
    }
}

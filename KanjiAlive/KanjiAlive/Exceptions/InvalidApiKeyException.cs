using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiAlive.Exceptions
{
    /// <summary>
    /// Thrown when the API key provided is invalid.
    /// </summary>
    public class InvalidApiKeyException : Exception
    {
        /// <summary>
        /// Constructs an instance of InvalidApiKeyException.
        /// </summary>
        public InvalidApiKeyException() : base("The API key provided is invalid.")
        {
            
        }
    }
}

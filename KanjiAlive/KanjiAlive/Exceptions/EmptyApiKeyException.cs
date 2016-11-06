using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiAlive.Exceptions
{
    /// <summary>
    /// Thrown when the API key supplied is null or empty.
    /// </summary>
    public class EmptyApiKeyException : Exception
    {
        /// <summary>
        /// Constructs an instance of EmptyApiKeyException.
        /// </summary>
        public EmptyApiKeyException() : base("The API key provided is empty or null.")
        {

        }
    }
}

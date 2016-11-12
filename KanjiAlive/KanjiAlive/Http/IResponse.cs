using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KanjiAlive.Http
{
    /// <summary>
    /// Abstraction for an HTTP response.
    /// </summary>
    public interface IResponse
    {
        /// <summary>
        /// Pre-deserialized response body.
        /// </summary>
        object Body { get; }

        /// <summary>
        /// The HTTP response status code.
        /// </summary>
        HttpStatusCode StatusCode { get; }

        /// <summary>
        /// 
        /// </summary>
        string ReasonPhrase { get; }
    }
}

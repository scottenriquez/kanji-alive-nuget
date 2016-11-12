using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KanjiAlive.Http
{
    public class Response : IResponse
    {
        public object Body { get; internal set; }
        public HttpStatusCode StatusCode { get; internal set; }
        public string ReasonPhrase { get; internal set; }
    }
}

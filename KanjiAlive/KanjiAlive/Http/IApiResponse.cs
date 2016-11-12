using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiAlive.Http
{
    public interface IApiResponse<out T>
    {
        T Content { get; }
        IResponse HttpResponse { get; }
    }
}

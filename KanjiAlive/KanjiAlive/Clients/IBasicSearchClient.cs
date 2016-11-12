using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KanjiAlive.Http;
using KanjiAlive.Models.Response;

namespace KanjiAlive.Clients
{
    public interface IBasicSearchClient
    {
        Task<IApiResponse<List<KanjiSimpleResponse>>> Get(string query);
    }
}

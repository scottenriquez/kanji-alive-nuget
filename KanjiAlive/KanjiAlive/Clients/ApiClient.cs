using KanjiAlive.Http;

namespace KanjiAlive.Clients
{
    public abstract class ApiClient
    {
        internal readonly IConnection _Connection;

        public ApiClient(string ApiKey)
        {
            _Connection = new Connection(ApiKey);
        }
    }
}
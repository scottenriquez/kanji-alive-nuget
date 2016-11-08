using KanjiAlive.Http;

namespace KanjiAlive.Clients
{
    public abstract class ApiClient
    {
        private readonly IConnection _connection;

        public ApiClient()
        {
            _connection = new Connection();
        }
    }
}

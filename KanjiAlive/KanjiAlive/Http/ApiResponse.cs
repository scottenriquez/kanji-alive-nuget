namespace KanjiAlive.Http
{
    public class ApiResponse<T> : IApiResponse<T>
    {
        public T Content { get; internal set; }
        public IResponse HttpResponse { get; internal set; }
    }
}

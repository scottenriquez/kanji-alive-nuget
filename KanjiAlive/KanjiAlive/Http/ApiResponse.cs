namespace KanjiAlive.Http
{
    /// <summary>
    ///     The HTTP response metadata and content for an API call.
    /// </summary>
    /// <typeparam name="T">
    ///     The type of the response content.
    /// </typeparam>
    public class ApiResponse<T> : IApiResponse<T>
    {
        /// <summary>
        ///     The deserialized search result content.
        /// </summary>
        public T Content { get; internal set; }

        /// <summary>
        ///     The HTTP request metadata.
        /// </summary>
        public IResponse HttpResponse { get; internal set; }
    }
}
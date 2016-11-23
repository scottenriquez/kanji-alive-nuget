namespace KanjiAlive.Http
{
    /// <summary>
    ///     The HTTP response metadata and content for an API call.
    /// </summary>
    /// <typeparam name="T">
    ///     The type of the response content.
    /// </typeparam>
    public interface IApiResponse<out T>
    {
        /// <summary>
        ///     The deserialized search result content.
        /// </summary>
        T Content { get; }

        /// <summary>
        ///     The HTTP request metadata.
        /// </summary>
        IResponse HttpResponse { get; }
    }
}
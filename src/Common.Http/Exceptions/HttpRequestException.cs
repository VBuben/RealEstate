using System.Net;

namespace Common.Http.Exceptions;

public sealed class HttpRequestException : Exception
{
    #region Constructors

    public HttpRequestException(string? message) : base(message) { }

    public HttpRequestException(string message, HttpStatusCode statusCode, HttpContent content) : base(message)
    {
        HttpStatusCode = statusCode;
        Content = content;
    }

    public HttpRequestException(HttpStatusCode statusCode, HttpContent content)
    {
        HttpStatusCode = statusCode;
        Content = content;
    }

    #endregion

    #region Properties

    public HttpContent? Content { get; }

    public HttpStatusCode? HttpStatusCode { get; }

    #endregion
}
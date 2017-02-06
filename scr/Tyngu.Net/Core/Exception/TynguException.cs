using System;
using System.Net;

namespace Tyngu.Net.Core
{
    public class TynguException: Exception
    {
        public readonly HttpStatusCode StatusCode;
        public readonly ResponseError ResponseError;

        public TynguException(string message, HttpStatusCode statusCode) : base(message)
        {
            StatusCode = statusCode;
        }

        public TynguException(ResponseError responseError, HttpStatusCode statusCode)
            : this(responseError.FullMessage, statusCode)
        {
            ResponseError = responseError;
        }
    }
}

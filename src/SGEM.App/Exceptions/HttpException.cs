using System;
using System.Collections.Generic;
using System.Net;

namespace SGEM.App.Exceptions
{
    public class HttpException : Exception
    {
        public List<string> Errors { get; }
        public HttpStatusCode StatusCode { get; }
        public HttpException(HttpStatusCode statusCode, List<string> errors)
        {
            Errors = errors;
            StatusCode = statusCode;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Core
{
    public class Response<T>
    {
        public T Data { get; set; }

        public Error Error { get; set; }

        public bool IsSuccess => Data != null;

        public Response() { }

        public Response(T data) => Data = data;
    }
    public class Error
    {
        public Exception Exception { get; set; }

        public IDictionary<string, object> Data { get; set; }

        public string Message { get; set; }
    }
}

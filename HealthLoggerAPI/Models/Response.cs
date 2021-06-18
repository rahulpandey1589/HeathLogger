using System.Collections.Generic;

namespace HealthLoggerAPI.Models
{
    public class Response<T>
    {
        public T Data { get; set; }

        public bool IsSuccess { get; set; }

        public int StatusCode { get; set; }

        public string Message { get; set; }

        public IEnumerable<string> Errors { get; set; }
    }
}

using System;
using System.Collections.Generic;
using DotnetCoreWebApi.Shared.Entities.ComplexTypes;
using DotnetCoreWebApi.Shared.Utilities.Results.ComplexTypes;

namespace DotnetCoreWebApi.Shared.Entities.Concrete
{
    public class ApiResult
    {
        public string Href { get; set; }
        public ResultStatus ResultStatus { get; set; }
        public Object Data { get; set; }
        public IEnumerable<ValidationError> ValidationErrors { get; set; }
        public string Message { get; set; }
        public string Detail { get; set; }
        public HttpStatusCode StatusCode { get; set; }

    }
}
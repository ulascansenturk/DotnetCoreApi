using System;
using System.Collections.Generic;
using DotnetCoreWebApi.Shared.Entities.Concrete;
using DotnetCoreWebApi.Shared.Utilities.Results.ComplexTypes;

namespace DotnetCoreWebApi.Shared.Utilities.Results.Abstract
{
    public interface IResult
    {
        
        public ResultStatus ResultStatus { get; } 
        public string Message { get; }
        public Exception Exception { get; }
        public IEnumerable<ValidationError> ValidationErrors { get; }
    }
}
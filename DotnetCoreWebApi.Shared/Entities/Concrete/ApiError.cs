using DotnetCoreWebApi.Shared.Utilities.Results.ComplexTypes;

namespace DotnetCoreWebApi.Shared.Entities.Concrete
{
    public class ApiError
    {
        public string Message { get; set; }
        public string Detail { get; set; }
        public ResultStatus ResultStatus { get; set; }
        
    }
}
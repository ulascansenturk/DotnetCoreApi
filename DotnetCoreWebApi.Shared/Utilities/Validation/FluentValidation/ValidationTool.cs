using System.Collections.Generic;
using DotnetCoreWebApi.Shared.Entities.Concrete;
using DotnetCoreWebApi.Shared.Utilities.Results.Abstract;
using DotnetCoreWebApi.Shared.Utilities.Results.ComplexTypes;
using DotnetCoreWebApi.Shared.Utilities.Results.Concrete;
using FluentValidation;

namespace DotnetCoreWebApi.Shared.Utilities.Validation.FluentValidation
{
    public static class ValidationTool
    {
        public static IResult Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                IList<ValidationError> validationErrors = new List<ValidationError>();
                foreach (var error in result.Errors)
                {
                    validationErrors.Add(new ValidationError
                    {
                        PropertyName = error.PropertyName,
                        Message = error.ErrorMessage
                    });
                }

                return new Result(ResultStatus.Error, $"Bir veya daha fazla validasyon hatasına rastlandı.",
                    validationErrors);
            }

            return new Result(ResultStatus.Success);
        }

    }
}
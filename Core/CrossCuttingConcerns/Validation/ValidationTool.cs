using FluentValidation;
using Microsoft.Extensions.Options;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,object entity)
        {
            var context = new ValidationContext<object>(entity);
            var ressult = validator.Validate(context);
            if (!ressult.IsValid)
            {
                throw new ValidationException(ressult.Errors);
            }
        }
}
}
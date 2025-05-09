using System;
using System.ComponentModel.DataAnnotations;

namespace backend_test_dotnet_API.Dtos;

public static class ValidatorDTO
{
    public static List<ValidationResult> ValidationModel(object model)
    {
        var results = new List<ValidationResult>();
        var context = new ValidationContext(model, null, null);
        Validator.TryValidateObject(model, context, results, true);
        return results;
    }
}

using DataLayer.Models;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Vaildation
{
    public static class TaskValidation
    {
        public static ValidationResult ValidateEndDate(DateTime endDate, ValidationContext context)
        {
            var instance = context.ObjectInstance as Models.Task;
            if (instance != null && instance.StartDate > endDate)
            {
                return new ValidationResult("End date must be after the start date.");
            }
            return ValidationResult.Success;
        }
    }
}

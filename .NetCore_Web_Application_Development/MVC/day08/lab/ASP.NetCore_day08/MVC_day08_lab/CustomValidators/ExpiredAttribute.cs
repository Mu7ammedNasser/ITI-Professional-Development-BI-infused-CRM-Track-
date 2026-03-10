using System.ComponentModel.DataAnnotations;

namespace MVC_day04_lab.CustomValidators
{
    public class ExpiredAttribute : ValidationAttribute
    {
        public ExpiredAttribute()
        {
            ErrorMessage = "The product is expired. Expire date must be today or in the future.";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            DateOnly expireDate = (DateOnly)value;
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);

            if (expireDate < today)
            {
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}

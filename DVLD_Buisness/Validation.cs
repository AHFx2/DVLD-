using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class Validation
    {
        [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
        public class ValidateAgeAttribute : Attribute
        {
            public int minAge {  get; set; }
            public int maxAge { get; set; }
            string ErrorMasage { get; set; }

            public ValidateAgeAttribute(int minAge, int maxAge)
            {
                minAge = minAge;
                maxAge = maxAge;
            }

        }


        [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
        public class ValidateBirthDateAttribute: ValidationAttribute
        {
            private readonly int _minAge;
            private readonly int _maxAge;

            public ValidateBirthDateAttribute(int minAge, int maxAge)
            {
                _minAge = minAge;
                _maxAge = maxAge;
            }

            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                if (value == null) return new ValidationResult($"The object {validationContext.ObjectInstance} has inValid Field {validationContext.DisplayName} must not be {new NullReferenceException()} .");

                if (value is DateTime birthDate)
                {
                    DateTime today = DateTime.Today;
                    var age = today.Year -birthDate.Year;

                    // Adjust for birthdays that haven't occurred yet this year
                    if (birthDate > today.AddYears(-age))
                    {
                        age--;
                    }

                    if (age < _minAge || age > _maxAge)
                    {
                        return new ValidationResult($"The field {validationContext.DisplayName} must correspond to a birth date resulting in an age between {_minAge} and {_maxAge}.");
                    }
                }
                else
                {
                    return new ValidationResult($"The field {validationContext.DisplayName} must be a valid date.");
                }

                return new ValidationResult($"The field {validationContext.DisplayName} must be a valid date.");
            }
        }
    }
}

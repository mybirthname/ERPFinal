using Dtos.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dtos.Filters
{
    public class PlaintTextValidationAttribute:ValidationAttribute
    {


        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //not part of current Page GUI, no check.
            if (value == null)
                return ValidationResult.Success;

            if (string.IsNullOrEmpty(value.ToString()))
                return new ValidationResult("Password could not be empty");

            return ValidationResult.Success;
        }

        public override bool IsValid(object value)
        {
            return base.IsValid(value);
        }
    }
}

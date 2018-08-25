using Dtos.OrderProcess;
using Dtos.User;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dtos.Filters
{
    public class ValidateDateAttribute : ValidationAttribute
    {

        public ValidateDateAttribute()
        {

        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //not part of current Page GUI, no check.
            if (value == null)
                return ValidationResult.Success;

            DateTime field = DateTime.Parse(value.ToString());

            if(field.CompareTo(DateTime.Now) < 0 )
            {
                return new ValidationResult("Date could not be in the past");
            }

            return ValidationResult.Success;
        }

        public override bool IsValid(object value)
        {
            return base.IsValid(value);
        }
    }
}

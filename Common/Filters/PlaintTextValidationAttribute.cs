using Dtos.User;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Common.Filters
{
    public class PlaintTextValidationAttribute:ValidationAttribute
    {


        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            ManageAccountInputModel model = (ManageAccountInputModel)validationContext.ObjectInstance;

            if (string.IsNullOrEmpty(model.NormalPassword))
                return new ValidationResult("_EmptyPlainTextPassword");

            return ValidationResult.Success;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dtos.User
{
    public class ForgotPasswordInputModel
    {
        [Required(ErrorMessage ="_EmailIsRequired")]
        [Display(Name = "_Email")]
        [EmailAddress]
        public string Email { get; set; }

    }
}

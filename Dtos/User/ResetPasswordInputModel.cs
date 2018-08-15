using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dtos.User
{
    public class ResetPasswordInputModel
    {
        [Required(ErrorMessage = "_EmailRequired")]
        [Display(Name ="_Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "_PasswordRequired")]
        [Display(Name="_Password")]
        [StringLength(100, ErrorMessage = "_PasswordErrMsg", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "_ConfirmPassword")]
        [Compare("Password", ErrorMessage = "_NewPasswordErrMsg")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }

    }
}

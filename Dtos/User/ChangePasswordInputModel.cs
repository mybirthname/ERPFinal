using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dtos.User
{
    public class ChangePasswordInputModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "_CurrentPassword")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "_PasswordErrMsg", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "_NewPassword")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "_ConfirmNewPassword")]
        [Compare("NewPassword", ErrorMessage = "_NewPasswordErrMsg")]
        public string ConfirmPassword { get; set; }

    }
}

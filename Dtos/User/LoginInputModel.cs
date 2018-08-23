using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dtos.User
{
    public class LoginInputModel
    {
        [Required(ErrorMessage = "EmailRequired")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage ="NotValidEmail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "PasswordRequired")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "RememberMe")]
        public bool RememberMe { get; set; }

        [Required]
        public string Language { get; set; }

    }
}

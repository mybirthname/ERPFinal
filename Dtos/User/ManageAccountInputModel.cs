using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dtos.User
{
    public class ManageAccountInputModel
    {
        [Required(ErrorMessage ="_EmailRequired")]
        [Display(Name="_Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "_PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Display(Name="_UserName")]
        public string Username { get; set; }

    }
}

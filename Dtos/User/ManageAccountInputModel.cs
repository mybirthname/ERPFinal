using Dtos.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dtos.User
{
    public class ManageAccountInputModel
    {
        public string ID { get; set; }

        [Required(ErrorMessage ="_EmailRequired")]
        [Display(Name="_Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "_PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Display(Name="_UserName")]
        public string Username { get; set; }

        [Required(ErrorMessage ="_FirstNameRequired")]
        [Display(Name ="_FirstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "_LastNameRequired")]
        [Display(Name ="_LastName")]
        public string LastName { get; set; }

        [Display(Name ="_Description")]
        public string Description { get; set; }

        [Display(Name = "_Password")]
        [PlaintTextValidation]
        public string NormalPassword { get; set; }

        [Display(Name = "_Roles")]
        public string Roles { get; set; }
    }
}

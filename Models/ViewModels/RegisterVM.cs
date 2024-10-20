using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Models.ViewModels
{
    public class RegisterVM
    {

        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]

        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        //public string? Role { get; set; }
        //[ValidateNever]
        //public IEnumerable<SelectListItem>? RoleList { get; set; }

        [Required]
        public string Name { get; set; }

        public string? PhoneNumber { get; set; }
        public string? RedirectUrl { get; set; }
        public string? Role { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem>? RoleList { get; set; }
    }
}

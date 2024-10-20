using System.ComponentModel.DataAnnotations;

namespace Models.ViewModels
{
    public class LoginVM
    {
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
        public string? RedirectUrl { get; set; }

    }
}

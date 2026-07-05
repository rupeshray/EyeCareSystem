using System.ComponentModel.DataAnnotations;
namespace EyeCareUI.Models
{
    public class LoginModel
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "User Name can only contain letters and numbers.")]
        [Display(Name = "User Name")]
        public required string UserName { get; set; }

        [Required]
        [Display(Name = "Password")]
        public required string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; } = false;
    }
}



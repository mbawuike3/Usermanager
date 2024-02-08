using System.ComponentModel.DataAnnotations;

namespace UserMangerDemo.Models.Authentication.Login
{
    public class LoginUser
    {
        public string? Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}

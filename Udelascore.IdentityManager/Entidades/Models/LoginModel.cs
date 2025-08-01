using System.ComponentModel.DataAnnotations;

namespace Udelascore.IdentityManager.Entidades.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Nombre de usuario requerido")]
        public required string UserName { get; set; }
        [Required(ErrorMessage = "Contraseña requerida")]
        public required string Password { get; set; }
    }
    public class LoginInputModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public bool RememberLogin { get; set; }
        public string ReturnUrl { get; set; }
    }
    public class LoginViewModel : LoginInputModel
    {
        public bool AllowRememberLogin { get; set; } = true;
        public bool EnableLocalLogin { get; set; } = true;
    }
    public class RegiterModel
    {
        [Required(ErrorMessage = "Nombre del usuario es requerido")]
        [DataType(DataType.Text)]
        public required string FirstName { get; set; }

        [Required(ErrorMessage = "Apellido del usuario es requerido")]
        [DataType(DataType.Text)]
        public required string LastName { get; set; }

        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email es requerido")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Contraseña es requerida")]
        [DataType(DataType.Password)]
        public required string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "La contraseña y la contraseña de confirmación no coinciden")]
        public required string PasswordConfirm { get; set; }
    }
}

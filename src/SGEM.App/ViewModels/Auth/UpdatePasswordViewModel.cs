using System.ComponentModel.DataAnnotations;

namespace SGEM.App.ViewModels.Auth
{
    public class UpdatePasswordViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo {0} está em formato inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo Senha Antiga é obrigatório")]
        public string OldPassword { get; set; }
        [Required(ErrorMessage = "O campo Senha é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo Senha precisa ter entre {2} e {1} caracteres", MinimumLength = 6)]
        [DataType(DataType.Password, ErrorMessage = "Senha inválida")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "As senhas não conferem")]
        public string ConfirmPassword { get; set; }
    }
}

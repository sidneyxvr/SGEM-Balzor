using SGEM.App.Enums;
using SGEM.App.ViewModels.Address;
using SGEM.App.ViewModels.Clinic;
using System;
using System.ComponentModel.DataAnnotations;

namespace SGEM.App.ViewModels.Auth
{
    public class RegisterUserViewModel
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo Nome precisa ter entre {2} e {1} caracteres", MinimumLength = 4)]
        public string Name { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo Nome precisa ter entre {2} e {1} caracteres", MinimumLength = 4)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo {0} está em formato inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo CPF é obrigatório")]
        [RegularExpression("[0-9]{11}", ErrorMessage = "O cpf está em formato inválido")]
        public string Document { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }
        public string WhatsApp { get; set; }
        public DateTime BirthDate { get; set; }
        public string ImagePath { get; set; }
        public SaveClinicViewModel Clinic { get; set; }
        public SaveAddressViewModel Address { get; set; }
        public Perfil Perfil { get; set; }
        public string Crm { get; set; }
        [Required(ErrorMessage = "O campo Senha é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo Senha precisa ter entre {2} e {1} caracteres", MinimumLength = 6)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "As senhas não conferem")]
        public string ConfirmPassword { get; set; }
        
        
    }
}

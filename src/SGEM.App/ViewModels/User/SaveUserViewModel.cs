using SGEM.App.Enums;
using SGEM.App.ViewModels.Address;
using SGEM.App.ViewModels.Clinic;
using System;
using System.ComponentModel.DataAnnotations;

namespace SGEM.App.ViewModels.User
{
    public class SaveUserViewModel : ViewModel
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo Nome deve ter no máximo 50 caracteres")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O campo Sobrenome é obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo Sobrenome deve ter no máximo 50 caracteres")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "O campo CPF é obrigatório")]
        [RegularExpression("[0-9]{11}", ErrorMessage = "O cpf está em formato inválido")]
        public string Document { get; set; }
        [Required(ErrorMessage = "O campo Email é obrigatório")]
        [DataType(DataType.EmailAddress, ErrorMessage = "O email está em formato inválido")]
        [MaxLength(100, ErrorMessage = "O campo Email deve ter no máximo 100 caracteres")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo Sexo é obrigatório")]
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }
        [Required(ErrorMessage = "O campo Telefone é obrigatório")]
        [RegularExpression("[0-9]{11|10}", ErrorMessage = "O telefone está em formato inválido")]
        public string Phone { get; set; }
        [RegularExpression("[0-9]{11}", ErrorMessage = "O whatsapp está em formato inválido")]
        public string WhatsApp { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public string ImagePath { get; set; }
        public SaveClinicViewModel Clinic { get; set; }
        public Guid? AddressId { get; set; }
        public SaveAddressViewModel Address { get; set; }
        [EnumDataType(typeof(Perfil))]
        public Perfil Perfil { get; set; }
        public string Crm { get; set; }
    }
}

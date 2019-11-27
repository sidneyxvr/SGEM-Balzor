using SGEM.App.ViewModels.Address;
using System;
using System.ComponentModel.DataAnnotations;

namespace SGEM.App.ViewModels.Clinic
{
    public class SaveClinicViewModel
    {
        [Required(ErrorMessage = "O campo Nome Fantasia é obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo Nome Fantasia deve ter no máximo 50 caracteres")]
        public string FancyName { get; set; }
        [Required(ErrorMessage = "O campo Razão Social é obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo Razão Social deve ter no máximo 50 caracteres")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "O campo CNPJ é obrigatório")]
        [RegularExpression("[0-9]{14}", ErrorMessage = "O campo CNPJ está em formato inválido")]
        public string Document { get; set; }
        [Required(ErrorMessage = "O campo Telefone é obrigatório")]
        [RegularExpression("[0-9]{11}|[0-9]{10}", ErrorMessage = "O campo Telefone está em formato inválido")]
        public string Phone { get; set; }
        public string ImagePath { get; set; }
        public Guid AddressId { get; set; }
        public SaveAddressViewModel Address { get; set; }
    }
}

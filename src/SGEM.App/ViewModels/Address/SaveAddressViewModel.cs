using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SGEM.App.ViewModels.Address
{
    public class SaveAddressViewModel : ViewModel
    {
        [Required(ErrorMessage = "O campo Logradouro é obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo Logradouro deve ter no máximo 50 caracteres")]
        public string Street { get; set; }
        [MaxLength(6, ErrorMessage = "O campo Logradouro deve ter no máximo 6 caracteres")]
        public string Number { get; set; }
        [Required(ErrorMessage = "O campo Bairro é obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo Bairro deve ter no máximo 50 caracteres")]
        public string District { get; set; }
        [Required(ErrorMessage = "O campo Cidade é obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo Cidade deve ter no máximo 50 caracteres")]
        public string City { get; set; }
        [Required(ErrorMessage = "O campo Estado é obrigatório")]
        [StringLength(2, ErrorMessage = "O campo Logradouro deve ter 2 caracteres", MinimumLength = 2)]
        public string State { get; set; }
        [Required(ErrorMessage = "O campo País é obrigatório")]
        [MaxLength(30, ErrorMessage = "O campo País deve ter no máximo 30 caracteres")]
        public string Country { get; set; }
        [Required(ErrorMessage = "O campo CEP é obrigatório")]
        [StringLength(8, ErrorMessage = "O campo CEP deve ter 8 caracteres", MinimumLength = 8)]
        [RegularExpression("[0-9]{8}", ErrorMessage = "O campo CEP está em formato inválido")]
        public string PostalCode { get; set; }
        [MaxLength(50, ErrorMessage = "O campo Complemento deve ter no máximo 50 caracteres")]
        public string Complement { get; set; }
    }
}

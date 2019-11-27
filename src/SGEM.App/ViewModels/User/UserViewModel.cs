using SGEM.App.Enums;
using SGEM.App.ViewModels.Address;
using SGEM.App.ViewModels.Exam;
using System;
using System.Collections.Generic;

namespace SGEM.App.ViewModels.User
{
    public class UserViewModel : ViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }
        public string WhatsApp { get; set; }
        public DateTime BirthDate { get; set; }
        public string ImagePath { get; set; }
        public Guid? AddressId { get; set; }
        public AddressViewModel Address { get; set; }
        public Perfil Perfil { get; set; }
        public string Crm { get; set; }
        public IEnumerable<ExamViewModel> Exams { get; set; }
    }
}

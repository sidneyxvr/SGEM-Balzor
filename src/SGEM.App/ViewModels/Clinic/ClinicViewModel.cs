using SGEM.App.ViewModels.Address;
using System;

namespace SGEM.App.ViewModels.Clinic
{
    public class ClinicViewModel : ViewModel
    {
        public string FancyName { get; set; }
        public string CompanyName { get; set; }
        public string Document { get; set; }
        public string Phone { get; set; }
        public string ImagePath { get; set; }
        public Guid AddressId { get; set; }
        public AddressViewModel Address { get; set; }
    }
}

using SGEM.App.ViewModels.Clinic;
using SGEM.App.ViewModels.User;
using System;
using System.ComponentModel.DataAnnotations;

namespace SGEM.App.ViewModels.Exam
{
    public class ExamViewModel : ViewModel
    {
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime ExamDate { get; set; }
        public Guid PatientId { get; set; }
        public virtual UserViewModel Patient { get; set; }
        public Guid ClinicId { get; set; }
        public virtual ClinicViewModel Clinic { get; set; }
        public string FilePath { get; set; }
        public string Tags { get; set; }
    }
}

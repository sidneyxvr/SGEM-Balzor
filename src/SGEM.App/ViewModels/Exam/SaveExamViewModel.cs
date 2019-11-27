using System;
using System.ComponentModel.DataAnnotations;

namespace SGEM.App.ViewModels.Exam
{
    public class SaveExamViewModel : ViewModel
    {
        [Required(ErrorMessage = "O campo Descrição é obrigatório")]
        [MaxLength(100, ErrorMessage = "O campo Descrição deve ter no máximo 100 caracteres")]
        public string Description { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "O campo Data do Exame é obrigatório")]
        public DateTime ExamDate { get; set; }
        public Guid PatientId { get; set; }
        public Guid ClinicId { get; set; }
        public string FilePath { get; set; }
    }
}
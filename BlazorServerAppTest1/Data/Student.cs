using System.ComponentModel.DataAnnotations;

namespace BlazorServerAppTest1.Data
{
    public class Student
    {
        [Required(ErrorMessage = "Please Set the student Name")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Please Set the student ID")]
        public int StudentId { get; set; }

        [Range(5, 19, ErrorMessage ="age must between 5 , 19")]
        public int StudentAge { get; set; }

        [StringLength(10, ErrorMessage = "Incorrect Format for phone number")]
        public string? StudentPhone { get; set; }

        public int StudentGrade { get; set; }

        public DateTime birthdate { get; set; } = DateTime.Now;

        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "please enter a valid email")]
        public string? email { get; set; }

        public string? school { get; set; }
    }
}

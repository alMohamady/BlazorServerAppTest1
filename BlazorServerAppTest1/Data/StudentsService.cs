namespace BlazorServerAppTest1.Data
{
    public class StudentsService : IStudentsService
    {
        public List<Student> Students { get ; set ; }
        public DateTime? CreatedAt { get ; set; }


        public StudentsService()
        { 
            Students = new List<Student>();
            Students.Add(new Student { StudentId = 1, StudentAge = 11, StudentGrade = 6, StudentName = "ahmed", StudentPhone = "123456" });
            Students.Add(new Student { StudentId = 2, StudentAge = 12, StudentGrade = 7, StudentName = "mohamed", StudentPhone = "123456" });
            Students.Add(new Student { StudentId = 3, StudentAge = 10, StudentGrade = 5, StudentName = "salah", StudentPhone = "123456" });
            Students.Add(new Student { StudentId = 4, StudentAge = 9, StudentGrade = 4, StudentName = "baymoi", StudentPhone = "123456" });
            Students.Add(new Student { StudentId = 5, StudentAge = 13, StudentGrade = 8, StudentName = "saeed", StudentPhone = "123456" });
            Students.Add(new Student { StudentId = 6, StudentAge = 8, StudentGrade = 3, StudentName = "mahoude", StudentPhone = "123456" });

            CreatedAt = DateTime.Now;
        }

        public Student GetStudent(int id)
        {
            return Students.Where(s => s.StudentId == id).FirstOrDefault();
        }

        public List<Student> GetStudents()
        {
            return Students;
        }




        public string GetSystemVersion()
        {
            return "V: 1.0.0.1";
        }

        public DateTime GetDateTime()
        {
            return CreatedAt.Value;
        }
    }
}

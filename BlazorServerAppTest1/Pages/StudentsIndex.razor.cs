using BlazorServerAppTest1.Data;

namespace BlazorServerAppTest1.Pages
{
    public partial class StudentsIndex
    {
        public List<Student> students { get; set; }

        public Student student { get; set; }

        protected override void OnInitialized()
        {
            student = new Student();
            students = studentsService.GetStudents();
        }

        private void addStudent()
        { 
           studentsService.addStudent(student);
        }
    }
}

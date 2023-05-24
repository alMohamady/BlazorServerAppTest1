using BlazorServerAppTest1.Data;

namespace BlazorServerAppTest1.Pages
{
    public partial class StudentsIndex
    {
        public List<Student> students { get; set; }


        protected override void OnInitialized()
        {
            students = studentsService.GetStudents();
        }


    }
}

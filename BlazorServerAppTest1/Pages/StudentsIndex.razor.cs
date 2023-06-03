using BlazorServerAppTest1.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorServerAppTest1.Pages
{
    public partial class StudentsIndex
    {
        public List<Student> students { get; set; }

        public Student student { get; set; }

        //[Inject]
        //IJSRuntime jS { get; set; }

        protected override void OnInitialized()
        {
            student = new Student();
            students = studentsService.GetStudents();
        }

        private async Task addStudent()
        {
            studentsService.addStudent(student);
           

            await myJs.InvokeVoidAsync("successMessage", student.StudentName, student.StudentGrade);

            student = new Student();
        }
    }
}

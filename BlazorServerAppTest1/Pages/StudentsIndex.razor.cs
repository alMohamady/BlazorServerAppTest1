using BlazorServerAppTest1.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Diagnostics;

namespace BlazorServerAppTest1.Pages
{
    public partial class StudentsIndex
    {
        public List<Student> students { get; set; }

        public Student student { get; set; }

        public string? theMsg;
        public string? myDate;
        public bool visable = false;

        //[Inject]
        //IJSRuntime jS { get; set; }

        ElementReference refStudentName;

        public string[]? schools { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender && schools == null)
            {
                schools = await myJs.InvokeAsync<string[]>("getSchools");

                StateHasChanged();
            }
        }

        protected override void OnInitialized()
        {
            student = new Student();
            students = studentsService.GetStudents();
        }

        private async Task addStudent()
        {
            visable = true;

            studentsService.addStudent(student);
            string StudentName = student.StudentName;
            string StudentGrade = student.StudentAge.ToString();
            student = new Student();

            //await myJs.InvokeVoidAsync("successMessage", StudentName, StudentGrade);
            theMsg = StudentName + " in " + StudentGrade + " has been saved successfully !";

            myDate = student.birthdate.ToShortDateString(); 

            await myJs.InvokeVoidAsync("setFocus", refStudentName);

        }
    }
}

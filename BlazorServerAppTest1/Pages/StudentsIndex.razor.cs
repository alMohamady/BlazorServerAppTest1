using BlazorServerAppTest1.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Diagnostics;

namespace BlazorServerAppTest1.Pages
{
    public partial class StudentsIndex : IDisposable
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

        protected override void OnInitialized()
        {
            student = new Student();
            students = studentsService.GetStudents();
            Console.WriteLine("OnInitialized");
        }

        protected override async Task OnInitializedAsync()
        {
            Console.WriteLine("OnInitializedAsync");
        }

        protected override void OnParametersSet()
        {
            Console.WriteLine("OnParametersSet");
        }

        protected override Task OnParametersSetAsync()
        {
            Console.WriteLine("OnParametersSetAsync");
            return base.OnParametersSetAsync();
        }

        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
            Console.WriteLine("OnAfterRender firstRender = {0}", firstRender);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            Console.WriteLine("OnAfterRenderAsync firstRender = {0}", firstRender);
            if (firstRender && schools == null)
            {
                schools = await myJs.InvokeAsync<string[]>("getSchools");

                StateHasChanged();
            }
            //visable = true;
            //theMsg = "Welcome in the page";
           
        }

        protected override bool ShouldRender()
        {
            Console.WriteLine("ShouldRender");
            return base.ShouldRender(); 
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
         
        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }
    }
}

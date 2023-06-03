﻿using BlazorServerAppTest1.Data;
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
            studentsService.addStudent(student);
            string StudentName = student.StudentName;
            string StudentGrade = student.StudentAge.ToString();
            student = new Student();

            await myJs.InvokeVoidAsync("successMessage", StudentName, StudentGrade);
            await myJs.InvokeVoidAsync("setFocus", refStudentName);

        }
    }
}

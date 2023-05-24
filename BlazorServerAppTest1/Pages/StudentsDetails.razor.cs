using BlazorServerAppTest1.Data;
using Microsoft.AspNetCore.Components;

namespace BlazorServerAppTest1.Pages
{
    public partial class StudentsDetails
    {
        [Parameter]
        public int id { get; set; }

        public Student student { get; set; }

        protected override void OnInitialized()
        {
            student = studentsService.GetStudent(id);
        }

    }
}

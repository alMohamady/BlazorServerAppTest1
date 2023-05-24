namespace BlazorServerAppTest1.Data
{
    public interface IStudentsService
    {
        List<Student> Students { get; set; }

        DateTime? CreatedAt { get; set; }

        List<Student> GetStudents();

        Student GetStudent(int id);

        DateTime GetDateTime();

        string GetSystemVersion();
    }
}

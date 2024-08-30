using OnlineSchool.Models;

namespace OnlineSchool.Services.StudentsServices
{
    public interface IStudentService
    {
        Task<Student>? AddStudent(Student model);

        Task<Student>? GetStudentByName(string firstName, string lastName);
    }
}

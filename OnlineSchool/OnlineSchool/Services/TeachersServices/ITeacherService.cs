using OnlineSchool.Models;

namespace OnlineSchool.Services.TeachersServices
{
    public interface ITeacherService
    {
        Task<Teacher>? AddTeacher(Teacher model);

        Task<Teacher>? GetTeacherByName(string firstName, string lastName);
    }
}

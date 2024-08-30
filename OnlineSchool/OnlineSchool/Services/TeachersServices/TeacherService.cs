using Microsoft.EntityFrameworkCore;
using OnlineSchool.Data;
using OnlineSchool.Models;

namespace OnlineSchool.Services.TeachersServices
{
    public class TeacherService : ITeacherService
    {
        private readonly ApplicationDbContext _context;

        public TeacherService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Teacher>? AddTeacher(Teacher model)
        {
            await _context.Teachers.AddAsync(model);
            return model;
        }

        public async Task<Teacher>? GetTeacherByName(string firstName, string lastName)
        {
            var teacher = await _context.Teachers.FirstOrDefaultAsync(x => x.FirstName == firstName || x.LastName == lastName);

            return teacher;
        }
    }
}

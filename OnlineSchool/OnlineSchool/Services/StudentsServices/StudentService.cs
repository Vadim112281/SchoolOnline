using Microsoft.EntityFrameworkCore;
using OnlineSchool.Data;
using OnlineSchool.Models;

namespace OnlineSchool.Services.StudentsServices
{ 
    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _context;

        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Student>? AddStudent(Student model)
        {
           await _context.Students.AddAsync(model);

            return model;
        }

        public async Task<Student>? GetStudentByName(string firstName, string lastName)
        {
            var student = await _context.Students.FirstOrDefaultAsync(x => x.FirstName == firstName || x.LastName == lastName);

            return student;
        }
    }
}

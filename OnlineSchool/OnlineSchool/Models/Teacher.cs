using OnlineSchool.Enum;

namespace OnlineSchool.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string MediumName { get; set; }
        public string LastName { get; set; }
        
        public AllSubjects? SubjectOfTeacher { get; set; }

        public RoleOfTeachers? RoleOfTeacher { get; set; }
    }
}

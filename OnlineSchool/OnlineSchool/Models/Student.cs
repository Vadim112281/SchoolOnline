using OnlineSchool.Enum;

namespace OnlineSchool.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string MediumName { get; set; }
        public string LastName { get; set; }    

        public AllClasses ClassOfStudent { get; set; }

        // Subjects
        public List<Subject>? Subjects { get; set; } = new List<Subject>(); 


    }
}

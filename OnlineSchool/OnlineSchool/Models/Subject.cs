namespace OnlineSchool.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        //Students
        public List<Student>? Students { get; set; } = new List<Student>();

        //Marks
        public List<Mark>? Marks { get; set; } = new List<Mark>();


    }
}

namespace OnlineSchool.Models
{
    public class Mark
    {
        public int MarkId { get; set; }
        public int ValueOfMark { get; set;}

        //Mark of subject
        public int? SubjectId { get; set; }
        public Subject?  Subject { get; set; } = new Subject();
    }
}

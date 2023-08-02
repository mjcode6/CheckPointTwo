namespace checkpoint.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string? Name { get; set; }

        public List<Enrollment>? Enrollments { get; set; }
    }
}

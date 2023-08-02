namespace checkpoint.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public List<Enrollment>? Enrollments { get; set; }

        // Helper method to calculate the average grade for the student
        public double CalculateAverageGrade()
        {
            if (Enrollments == null || Enrollments.Count == 0)
                return 0;

            double totalGrade = Enrollments.Sum(e => e.Grade);
            return Math.Round(totalGrade / Enrollments.Count, 1);
        }
    }
}

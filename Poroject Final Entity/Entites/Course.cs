using Poroject_Final_Entity.Enums;

namespace Poroject_Final_Entity.Entites
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discreptio { get; set; }
        public int Unit { get; set; }
        public string? IdCoursePischNiaz { get; set; } = null;
        public DateTime StratDate { get; set; }
        public DateTime EndtDate { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public int NumberOfStudents { get; set; }
        public int PischNiaz { get; set; }
        public int IdTeacher { get; set; }

    }
}

namespace Poroject_Final_Entity.Entites
{
    public class Student
    {
        public int Age { get; set; }
        public bool IsMashroot { get; private set; }
        public bool IsMomtaz { get; private set; }
        public int checkvahed { get; set; }
        public List<Course> CourseStudent { get; set; } = new List<Course>();
        public List<Course> finallistofcourses { get; set; } = new List<Course>();
    }
}

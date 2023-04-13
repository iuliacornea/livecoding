namespace CRUD_demo_3.Model
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public List<Course> Courses { get; set; } = new List<Course>();
    }
}

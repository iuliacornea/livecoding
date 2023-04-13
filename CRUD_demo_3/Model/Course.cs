namespace CRUD_demo_3.Model
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public Teacher? Coordinator { get; set; } = null;

        public int CoordinatorId { get; set; }  
    }
}

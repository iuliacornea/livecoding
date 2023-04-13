using CRUD_demo_3.Model;

namespace CRUD_demo_3.Repository
{
    public interface ITeacherRepository
    {
        Teacher create(Teacher teacher);
        List<Teacher> getAll();
        Teacher getOne(int teacherId);
        Teacher update(Teacher teacher);
        int delete(int teacherId);

    }
}

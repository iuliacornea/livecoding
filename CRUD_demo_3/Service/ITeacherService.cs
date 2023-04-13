using CRUD_demo_3.Model;

namespace CRUD_demo_3.Service
{
    public interface ITeacherService
    {
        Teacher create(Teacher teacher);
        Teacher getOne(int teacherId);
        List<Teacher> getAll();
        Teacher update(Teacher teacher);
        int delete(int teacherId);
    }
}

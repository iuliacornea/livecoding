using CRUD_demo_3.Model;
using CRUD_demo_3.Repository;

namespace CRUD_demo_3.Service
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _repository;

        public TeacherService(ITeacherRepository repository)
        {
            _repository = repository;
        }

        public Teacher create(Teacher teacher)
        {
            return _repository.create(teacher);
        }

        public Teacher getOne(int teacherId)
        {
            if (teacherId == null)
                throw new Exception("Teacher id cannot be null");
            return _repository.getOne(teacherId);
        }

        public List<Teacher> getAll()
        {
            return _repository.getAll();
        }

        public Teacher update(Teacher teacher)
        {
            if (teacher == null)
                throw new Exception("Teacher object cannot be null");
            return _repository.update(teacher);
        }
        public int delete(int teacherId)
        {
            if (teacherId == null)
                throw new Exception("Teacher id cannot be null");
            return _repository.delete(teacherId);
        }
    }
}

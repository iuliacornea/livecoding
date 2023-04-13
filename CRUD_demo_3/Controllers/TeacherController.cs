using CRUD_demo_3.Data;
using CRUD_demo_3.Model;
using CRUD_demo_3.Service;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_demo_3.Controllers
{
    [ApiController]
    [Route("api/teachers")]
    public class TeacherController : Controller
    {

        private readonly ITeacherService _service;


        public TeacherController(ITeacherService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Course>> getCourses(int id)
        {
            // pretend code is here
            return null;
        }

        [HttpPost]
        public ActionResult create([FromBody] Teacher teacher)
        {
            return Ok(_service.create(teacher));
        }

        [HttpGet]
        public ActionResult<List<Teacher>> getAll()
        {
            return Ok(_service.getAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Teacher> get(int id)
        {
            return Ok(_service.getOne(id));
        }

        [HttpPut("{id}")]
        public ActionResult<Teacher> update(int id, [FromBody] Teacher teacher) {
            if (id != teacher.Id)
                return BadRequest("Path id does not match the body id");
            return Ok(_service.update(teacher));
        }

        [HttpDelete]
        public ActionResult<int> delete(int id) {
            return Ok(_service.delete(id));
        }

        
    }
}

using Microsoft.AspNetCore.Mvc;
using Udemy.Cqrs.CQRS.Handlers;
using Udemy.Cqrs.CQRS.Queries;

namespace Udemy.Cqrs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly GetStudentByIdQueryHandler getStudentByIdQueryHandler;
        private readonly GetStudentsQueryHandler getStudentsQueryHandler;

        public StudentsController(GetStudentByIdQueryHandler getStudentByIdQueryHandler, GetStudentsQueryHandler getStudentsQueryHandler)
        {
            this.getStudentByIdQueryHandler = getStudentByIdQueryHandler;
            this.getStudentsQueryHandler = getStudentsQueryHandler;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = this.getStudentsQueryHandler.Handle(new GetStudentsQuery());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var result = this.getStudentByIdQueryHandler.Handle(new GetStudentByIdQuery(id));
            return Ok(result);
        }
    }
}

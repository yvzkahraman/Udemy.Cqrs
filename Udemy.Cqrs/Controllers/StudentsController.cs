using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Udemy.Cqrs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly GetStudentByIdQueryHandler getStudentByIdQueryHandler;

        public StudentsController(GetStudentByIdQueryHandler getStudentByIdQueryHandler)
        {
            this.getStudentByIdQueryHandler = getStudentByIdQueryHandler;
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
           var result =  this.getStudentByIdQueryHandler.Handle(new GetStudentByIdQuery(id));
            return Ok(result);
        }
    }
}

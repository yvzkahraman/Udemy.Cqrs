using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Udemy.Cqrs.CQRS.Commands;
using Udemy.Cqrs.CQRS.Handlers;
using Udemy.Cqrs.CQRS.Queries;

namespace Udemy.Cqrs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //private readonly GetStudentByIdQueryHandler getStudentByIdQueryHandler;
        //private readonly GetStudentsQueryHandler getStudentsQueryHandler;
        //private readonly CreateStudentCommandHandler createStudentCommandHandler;
        //private readonly RemoveStudentCommandHandler removeStudentCommandHandler;
        //private readonly UpdateStudentCommandHandler updateStudentCommandHandler;

        //public StudentsController(GetStudentByIdQueryHandler getStudentByIdQueryHandler, GetStudentsQueryHandler getStudentsQueryHandler, CreateStudentCommandHandler createStudentCommandHandler, RemoveStudentCommandHandler removeStudentCommandHandler, UpdateStudentCommandHandler updateStudentCommandHandler)
        //{
        //    this.getStudentByIdQueryHandler = getStudentByIdQueryHandler;
        //    this.getStudentsQueryHandler = getStudentsQueryHandler;
        //    this.createStudentCommandHandler = createStudentCommandHandler;
        //    this.removeStudentCommandHandler = removeStudentCommandHandler;
        //    this.updateStudentCommandHandler = updateStudentCommandHandler;
        //}

        private readonly IMediator _mediator;
        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    var result = this.getStudentsQueryHandler.Handle(new GetStudentsQuery());
        //    return Ok(result);
        //}

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudent(int id)
        {
            var result = await _mediator.Send(new GetStudentByIdQuery(id));
            return Ok(result);
        }

        //[HttpPost]
        //public IActionResult Create(CreateStudentCommand command)
        //{
        //    this.createStudentCommandHandler.Handle(command);
        //    return Created("",command.Name);
        //}

        //[HttpDelete("{id}")]
        //public IActionResult Remove(int id)
        //{
        //    this.removeStudentCommandHandler.Handle(new RemoveStudentCommand(id));
        //    return NoContent();
        //}

        //[HttpPut]
        //public IActionResult Update(UpdateStudentCommand command)
        //{
        //    this.updateStudentCommandHandler.Handle(command);
        //    return NoContent();
        //}
    }
}

using Udemy.Cqrs.CQRS.Queries;
using Udemy.Cqrs.CQRS.Results;
using Udemy.Cqrs.Data;

namespace Udemy.Cqrs.CQRS.Handlers
{
    public class GetStudentByIdQueryHandler
    {
        private readonly StudentContext _context;

        public GetStudentByIdQueryHandler(StudentContext context)
        {
            _context = context;
        }

        public GetStudentByIdQueryResult Handle(GetStudentByIdQuery query)
        {
            var student = _context.Set<Student>().Find(query.Id);
            return new GetStudentByIdQueryResult
            {
                Age = student.Age,
                Name = student.Name,
                Surname = student.Surname
            };
        }
    }
}

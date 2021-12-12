using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Udemy.Cqrs.Data;

namespace Udemy.Cqrs
{
    public class GetStudentsQueryHandler
    {
        private readonly StudentContext _context;

        public GetStudentsQueryHandler(StudentContext context)
        {
            _context = context;
        }

        public IEnumerable<GetStudentsQueryResult> Handle(GetStudentsQuery query)
        {
            return _context.Students.Select(x => new GetStudentsQueryResult { Name = x.Name, Surname = x.Surname }).AsNoTracking().AsEnumerable();
        }
    }
}

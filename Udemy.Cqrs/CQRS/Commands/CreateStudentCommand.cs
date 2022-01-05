using MediatR;

namespace Udemy.Cqrs.CQRS.Commands
{
    public class CreateStudentCommand : IRequest
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age { get; set; }
    }
}

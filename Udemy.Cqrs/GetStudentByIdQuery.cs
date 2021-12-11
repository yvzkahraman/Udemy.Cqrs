namespace Udemy.Cqrs
{
    public class GetStudentByIdQuery
    {
        public int Id { get; set; }

        public GetStudentByIdQuery(int id)
        {
            Id = id;
        }
    }
}

﻿namespace Udemy.Cqrs.CQRS.Commands
{
    public class CreateStudentCommand
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age { get; set; }
    }
}

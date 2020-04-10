using BootCamp.Chapter.SchoolSubjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Teachers
{
    class UniversityTeacher : ITeacher<Subject>
    {
        string Name { get; }
        private Subject _Teachings;

        public UniversityTeacher(string name, Subject subject)
        {
            Name = name;
            _Teachings = subject;
        }

        public Subject ProduceMaterial()
        {
            Console.WriteLine($"{Name}:");
            _Teachings.ProduceMaterial();
            return _Teachings;
        }
    }
}

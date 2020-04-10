using BootCamp.Chapter.SchoolSubjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Teachers
{
    class HighSchoolTeacher : ITeacher<Subject>
    {
        string Name { get; }
        private Subject _Teachings;

        public HighSchoolTeacher(string name, Subject subject)
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

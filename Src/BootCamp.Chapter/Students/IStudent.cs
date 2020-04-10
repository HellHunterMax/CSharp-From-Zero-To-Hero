using BootCamp.Chapter.SchoolSubjects;
using BootCamp.Chapter.Teachers;
using System.Collections.Generic;

namespace BootCamp.Chapter.Students
{
    interface IStudent
    {
        public long Id { get; set; }
        void LearnFrom(ITeacher<Subject> teacher);
    }
}

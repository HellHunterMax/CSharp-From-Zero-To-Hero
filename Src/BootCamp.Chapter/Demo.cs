using BootCamp.Chapter.Schools;
using BootCamp.Chapter.SchoolSubjects;
using BootCamp.Chapter.Students;
using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Demo
    {
        public void RunDemo()
        {
            List<object> schools = new List<object>();

            ISchool<HighSchoolStudent, HighSchoolTeacher> highSchool1 = new HighSchool();
            ISchool<MiddleSchoolStudent, MiddleSchoolTeacher> middleSchool1 = new MiddleSchool();
            ISchool<UniversityStudent, UniversityTeacher> university1 = new University();

            MiddleSchoolStudent middleSchoolStudent1 = new MiddleSchoolStudent("Bert");
            HighSchoolStudent highSchoolStudent1 = new HighSchoolStudent("Jan");
            UniversityStudent universityStudent1 = new UniversityStudent("Karl");

            Subject art = new Art();
            Subject english = new English();
            Subject maths = new Maths();

            MiddleSchoolTeacher middleSchoolTeacher1 = new MiddleSchoolTeacher("Kristof", art);
            HighSchoolTeacher highSchoolTeacher1 = new HighSchoolTeacher("John", english);
            UniversityTeacher universityTeacher1 = new UniversityTeacher("Geo", maths);

            middleSchool1.AddStudent(middleSchoolStudent1);
            middleSchool1.AddTeacher(middleSchoolTeacher1);
            highSchool1.AddStudent(highSchoolStudent1);
            highSchool1.AddTeacher(highSchoolTeacher1);
            university1.AddStudent(universityStudent1);
            university1.AddTeacher(universityTeacher1);

            schools.Add(highSchool1);
            schools.Add(middleSchool1);
            schools.Add(university1);

            middleSchoolStudent1.LearnFrom(middleSchoolTeacher1);
            highSchoolStudent1.LearnFrom(highSchoolTeacher1);
            universityStudent1.LearnFrom(universityTeacher1);

            middleSchoolStudent1.GetSubjectsLearnt();
            highSchoolStudent1.GetSubjectsLearnt();
            universityStudent1.GetSubjectsLearnt();

            //TODO Try and get a schools list to work.
            foreach (object school in schools)
            {
                ISchool<IStudent, ITeacher<Subject>> s;
                
                if (school.GetType().Name == "MiddleSchool")
                {
                    var middleSchool = (MiddleSchool)school;
                    Console.WriteLine("Found MiddleSchool.");
                }
                if (school.GetType().Name == "University")
                {
                    //s = (University)school;
                    Console.WriteLine("Found University.");
                }
                if (school.GetType().Name == "HighSchool")
                {
                    //s = (HighSchool)school;
                    Console.WriteLine("Found HighSchool.");
                }
                
            }
        }

    }
}

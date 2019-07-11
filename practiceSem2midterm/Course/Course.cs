using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    enum DisplayOption
    {
        All, Code, Name, Prerequsite, Semester
    }

    class Course
    {
        public string Code { get; private set; }
        public string Description { get; private set; }
        public string Name { get; private set; }
        public string Prerequsites { get; private set; }
        public string Semester { get; private set; }
        Course(string code, string name, string description, string semester, string prerequisites)
        {
            Code = code;
            Description = description;
            Name = name;
            Prerequsites = prerequisites;
            Semester = semester;
        }
        public override string ToString()
        {
            return $"";
        }

    }
   static class CourseManager
    {
        static List<Course> courses = new List<Course>();
        public static void Display(DisplayOption option, string toMatch = "")
        {
            if (DisplayOption.Code == )
            {

            }
        }
        public static void LoadCourses(stringfilename)
        {

        }
    }
}

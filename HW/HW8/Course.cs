using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    internal class Course
    {
        public string courseName;
        public int courseDuration;
        IList<Teacher> teacherArr = new List<Teacher>();
        IList<Student> studensArr = new List<Student>();

        public Course(string courseName, Teacher teacher, int courseDuration, IList<Student> studensArr) : this(courseName, teacher, courseDuration)
        {
            this.studensArr = studensArr;
        }

        public Course(string courseName, Teacher teacher, int courseDuration)
        {
            this.courseName = courseName;
            this.courseDuration = courseDuration;
            AddSTeacher(teacher);
        }

        public void AddSTeacher(Teacher teacher)
        {
            teacherArr.Add(teacher);
        }
        public void AddStudent(Student student)
        {
            studensArr.Add(student);
        }
        public void AddStudent(IList<Student> studensArr)
        {
            this.studensArr = studensArr;
        }

        public void PrintCourseInfo()
        {
            Console.WriteLine($"\nCourse info '{this.courseName}':");
            Console.WriteLine($"\tTeacher Name:");
            foreach (Teacher curTeacher in teacherArr)
                Console.WriteLine($"\t\t{curTeacher.firstName} {curTeacher.lastName}");
            Console.WriteLine($"\tCourse Duration:    {this.courseDuration}");
            Console.WriteLine($"\tNumber of Students: {this.studensArr.Count}");
            Console.WriteLine("Students:");

            if (studensArr.Count>0)
            {
                foreach (Student student in studensArr)
                {
                    Console.WriteLine($"\tName: {student.firstName}, Age {student.age}");
                }
            }
            else {
                Console.WriteLine("\tNo students");
            }
        }

        public bool FindStudent (string studentLastName)
        {
            bool studFound = false;
            foreach (Student student in studensArr)
            {
                if (student.lastName.ToLower() == studentLastName.ToLower())
                {
                    studFound = true;
                    break;
                }
            }
            return studFound;
        }

        public bool FindTeacher(string teachertLastName)
        {
            bool studFound = false;
            foreach (Teacher teacher in teacherArr)
            {
                if (teacher.lastName.ToLower() == teachertLastName.ToLower())
                {
                    studFound = true;
                    break;
                }
            }
            return studFound;
        }
    }
}

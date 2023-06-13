using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    internal class Course
    {
        public string courseName;
        public Teacher teacher;
        public int courseDuration;
        List<Student> studensArr = new List<Student>();

        public Course(string courseName, Teacher teacher, int courseDuration, List<Student> studensArr) : this(courseName, teacher, courseDuration)
        {
            this.studensArr = studensArr;
        }

        public Course(string courseName, Teacher teacher, int courseDuration)
        {
            this.courseName = courseName;
            this.teacher = teacher;
            this.courseDuration = courseDuration;
        }

        public void AddStudent(Student student)
        {
            studensArr.Add(student);
        }
        public void AddStudent(List<Student> studensArr)
        {
            this.studensArr = studensArr;
        }

        public void PrintCourseInfo()
        {
            Console.WriteLine($"\nCourse info '{this.courseName}':");
            Console.WriteLine($"\tTeacher Name:       {teacher.firstName} {teacher.lastName}");
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
    }
}

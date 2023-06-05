using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    internal class Course
    {
        public string courseName;
        public string teacherName;
        public int courseDuration;
        public int numberOfStudents;

        public Course(string courseName, string teacherName, int courseDuration, int numberOfStudents) : this(courseName, teacherName, courseDuration)
        {
            this.numberOfStudents = numberOfStudents;
        }

        public Course(string courseName, string teacherName, int courseDuration) : this()
        {
            this.courseName = courseName;
            this.teacherName = teacherName;
            this.courseDuration = courseDuration;
        }
        public Course()
        {
            if (this.courseName == null) this.courseName = "NoCourseName";
            if (this.teacherName == null) this.teacherName = "NoTeacherName";
            if (this.courseDuration > 0) this.courseDuration = 99;
            numberOfStudents = 0;
        }

        public void AddStudent()
        {
            this.numberOfStudents++;
        }
        public void AddStudent(int studCount)
        {
            this.numberOfStudents+=studCount;
        }

        public void PrintCourseInfoCommon()
        {
            Console.WriteLine("\nCourse info:");
            Console.WriteLine($"\tCourse Name:        {this.courseName}");
            Console.WriteLine($"\tTeacher Name:       {this.teacherName}");
            Console.WriteLine($"\tCourse Duration:    {this.courseDuration}");
            Console.WriteLine($"\tNumber of Students: {this.numberOfStudents}");
        }
    }
}

namespace HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student myStud = new Student("FirstName", "SecondName", 20, "Zhytomyr");
            Teacher myTeacher = new Teacher("TeacherName1", "TeacherName2",46,"Rio");

            myTeacher.PrinttInfo();
            Console.WriteLine("\n");

            myStud.PrinttInfo();
            // add cources
            myStud.AddCourse("Course 1", "Course 2", "Course 3");
            myStud.ListCources();
            // delete course
            myStud.DelCourse("Course 2");
            myStud.ListCources();

            Console.WriteLine("\n");

            // play with Course class
            List<Course> courcesArr = new List<Course>();

            courcesArr.Add(new Course("Course 1", "Born", 8));
            courcesArr.Add(new Course("Course 2", "Wick", 2));
            courcesArr.Add(new Course("Course 3", "Rambo", 3));

            foreach (Course curCourse in courcesArr)
            {
                if (curCourse.courseName == "Course 1")
                    curCourse.AddStudent();
                if (curCourse.courseName == "Course 2")
                    curCourse.AddStudent(25);

                curCourse.PrintCourseInfoCommon();
            }
        }
    }
}
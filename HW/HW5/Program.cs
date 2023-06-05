namespace HW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myStud = new Student("FirstName", "SecondName", 20, "Zhytomyr");
            
            myStud.PrintStudentInfoCommon();
            // add cources
            myStud.AddCourse("Course 1", "Course 2", "Course 3");
            myStud.ListCources();
            // delete course
            myStud.DelCourse("Course 2");
            myStud.ListCources();


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
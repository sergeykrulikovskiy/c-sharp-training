namespace HW7
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Якщо не підходить, то пиши :) ну і вийшов ледачий варінт з лістами...
            // зробив з розрахунку що: є Курс (основи С# наприклад) - у курса є викладач Кріс - у курса є студенти
            List<Student> studentsArr = new List<Student>();
            List<Course>  courcesArr  = new List<Course>();
            List<Teacher> teachersArr = new List<Teacher>();

            // ***** create students *****
            Student student1 = new Student("student1", "student1", 21, "Zhytomyr");
            Student student2 = new Student("student2", "student2", 22, "Lviv");
            studentsArr.Add(student1);
            studentsArr.Add(student2);

            // ***** create teachers *****
            Teacher teacherBorn = new Teacher("James", "Born", 31, "Rio");
            Teacher teacherWick = new Teacher("Jhon", "Wick", 32, "Hell");
            Teacher teacherBond = new Teacher("James", "Bond", 32, "Hell");
            teachersArr.Add(teacherBorn);
            teachersArr.Add(teacherWick);
            teachersArr.Add(teacherBond);

            // ***** create cources *****
            // init bornCourse with several Students
            Course bornCourse = new Course("Born Course", teacherBorn, 1, studentsArr);
            Course bondCourse = new Course("Bond Course", teacherBond, 3);

            Course wickCourse = new Course("Wick Course", teacherWick, 2);
            // add single student to the wickCourse
            wickCourse.AddStudent(student2);
            courcesArr.Add(bornCourse);
            courcesArr.Add(wickCourse);
            courcesArr.Add(bondCourse);

            // list full info about each course
            foreach (Course curCourse in courcesArr)
            {
                curCourse.PrintCourseInfo();
            }

            // delete course
            courcesArr.Remove(bondCourse);
            // list full info about each course
            Console.WriteLine("\nCources after removal:");
            foreach (Course curCourse in courcesArr)
            {
                Console.WriteLine($"\t{curCourse.courseName}");
            }
        }
    }
}
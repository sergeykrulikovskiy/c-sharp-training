namespace HW8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentsArr = new List<Student>();
            IList<Course>  courcesArr  = new List<Course>();
            IList<Teacher> teachersArr = new List<Teacher>();

            // ***** create students *****
            Student student1 = new Student("Serg", "Sergov", 21, "Zhytomyr");
            Student student2 = new Student("Name", "Namov", 22, "Lviv");
            Student student3 = new Student("Slav", "Slavov", 25, "Dnipro");
            studentsArr.Add(student1); studentsArr.Add(student2); studentsArr.Add(student3);

            // ***** create teachers *****
            Teacher teacherBorn = new Teacher("James", "Born", 31, "Rio");
            Teacher teacherWick = new Teacher("Jhon", "Wick", 32, "Hell");
            Teacher teacherBond = new Teacher("James", "Bond", 32, "Hell");
            teachersArr.Add(teacherBorn); teachersArr.Add(teacherWick); teachersArr.Add(teacherBond);

            // ***** create cources *****
            Course bornCourse = new Course("Born Course", teacherBorn, 1, studentsArr);
            
            Course bondCourse = new Course("Bond Course", teacherBond, 3);
                   bondCourse.AddStudent(student3);
                   bondCourse.AddSTeacher(teacherWick);

            Course wickCourse = new Course("Wick Course", teacherWick, 2);
                   wickCourse.AddStudent(student1);
                   wickCourse.AddStudent(student2);
            
            courcesArr.Add(bornCourse); courcesArr.Add(wickCourse); courcesArr.Add(bondCourse);

            // list full info about each course
            Console.WriteLine("**************** COURCES ****************");
            foreach (Course curCourse in courcesArr)
                curCourse.PrintCourseInfo();
            
            //а далі 2 тупих копіпаста. Розберусь з делегатами/linq і перероблю для себе...
            // list full info about each student
            Console.WriteLine("**************** STUDENTS ****************");
            foreach (Student curStudent in studentsArr)
            {     
                curStudent.PrinttInfo();
                Console.WriteLine("Cources:");
                foreach (Course curCourse in courcesArr)
                {
                    if (curCourse.FindStudent(curStudent.lastName))
                        Console.WriteLine($"\t{curCourse.courseName}");
                }
            }

            // list full info about each student
            Console.WriteLine("**************** TEACHERS ****************");
            foreach (Teacher curTeacher in teachersArr)
            {
                curTeacher.PrinttInfo();
                Console.WriteLine("Cources:");
                foreach (Course curCourse in courcesArr)
                {
                    if (curCourse.FindTeacher(curTeacher.lastName))
                        Console.WriteLine($"\t{curCourse.courseName}");
                }
            }
        }
    }
}
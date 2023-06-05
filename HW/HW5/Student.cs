using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    internal class Student
    {
        public string firstName { get; }
        public string lastName { get; }
        public int age { get; }
        public string city { get; }
        private List<string> courcesAttended = new List<string>();


        public Student (string firstName, string lastName, int age, string city) : this(firstName, lastName, age)
        {
            this.city = city;
        }

        public Student(string firstName, string lastName, int age):this(firstName, lastName)
        {
            this.age = age;
        }
        public Student(string firstName, string lastName): this()
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Student()
        {
            if (this.firstName == null) this.firstName = "NoFirstName";
            if (this.lastName == null) this.lastName = "NoLastName";
            if (this.age > 0) this.age = 99;
            if (this.city == null) this.city = "Homeless";
        }

        public void PrintStudentInfoCommon()
        {
            Console.WriteLine("Student info:");
            Console.WriteLine($"\tFirst Name: {this.firstName}");
            Console.WriteLine($"\tLast Name:  {this.lastName}");
            Console.WriteLine($"\tAge:        {this.age}");
            Console.WriteLine($"\tCity:       {this.city}");
        }

        public void AddCourse (params string[] courceName)
        {
            foreach (string arg in courceName)
                courcesAttended.Add(arg);
        }
        public void DelCourse(string courceName)
        {
            courcesAttended.Remove(courceName);
        }
        public void ListCources()
        {
            if (courcesAttended != null)
            {
                Console.Write($"Cources attended: {string.Join(",", this.courcesAttended)}");
                Console.WriteLine();
            }
        }
    }
}

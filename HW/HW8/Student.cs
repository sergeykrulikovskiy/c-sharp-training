using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    internal class Student:Monkey
    {
        private List<string> courcesAttended = new List<string>();
        public Student(string firstName, string lastName, int age, string city) : base(firstName, lastName, age, city){}
        public Student(string firstName, string lastName, int age) : base(firstName, lastName, age){}
        public Student(string firstName, string lastName) : base(firstName, lastName){}

        public override void PrinttInfo()
        {
            Console.WriteLine("Student info:");
            Console.WriteLine($"\tFirst Name: {firstName}");
            Console.WriteLine($"\tLast Name:  {lastName}");
            Console.WriteLine($"\tAge:        {age}");
            Console.WriteLine($"\tCity:       {city}");
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

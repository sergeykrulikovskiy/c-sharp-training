using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    internal class Teacher: Monkey
    {
        public Teacher(string firstName, string lastName, int age, string city) : base(firstName, lastName, age, city) { }
        public Teacher(string firstName, string lastName, int age) : base(firstName, lastName, age) { }
        public Teacher(string firstName, string lastName) : base(firstName, lastName) { }

        public override void PrinttInfo()
        {
            Console.WriteLine("Teacher info:");
            Console.WriteLine($"\tFirst Name: {firstName}");
            Console.WriteLine($"\tLast Name:  {lastName}");
            Console.WriteLine($"\tAge:        {age}");
            Console.WriteLine($"\tCity:       {city}");
        }
    }
}

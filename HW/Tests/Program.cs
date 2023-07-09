using System;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Person> people = new List<Person>
            {
                new Person ("Tom",23),
                new Person ("Bob",27),
                new Person ("Sam",29),
                new Person ("Alice",24)
            };

            //var names = people.Select(u => u.Name);
            //foreach (string n in names)
            //    Console.WriteLine(n);

            //IEnumerable<Person> names1 = people.Where(a => a.Age > 25);
            //Console.WriteLine(names1.GetType());
            //foreach (Person nn in names1)
            //    Console.WriteLine(nn.Name);


        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Person() { }
    }
    
   }

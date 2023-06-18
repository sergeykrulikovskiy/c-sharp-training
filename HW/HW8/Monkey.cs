using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    internal abstract class Monkey
    {
        public string firstName { get;}
        public string lastName { get;}
        public int age { get;}
        public string city { get;}

        public Monkey(string firstName, string lastName, int age, string city) : this(firstName, lastName, age)
        {
            this.city = city;
        }

        public Monkey(string firstName, string lastName, int age) : this(firstName, lastName)
        {
            this.age = age;
        }
        public Monkey(string firstName, string lastName) : this()
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public virtual void PrinttInfo()
        {
            Console.WriteLine(">>>> Mokey class <<<<");
        }

        public Monkey()
        {
            if (this.firstName == null) this.firstName = "NoFirstName";
            if (this.lastName == null) this.lastName = "NoLastName";
            if (this.age > 0) this.age = 99;
            if (this.city == null) this.city = "Homeless";
        }
    }
}

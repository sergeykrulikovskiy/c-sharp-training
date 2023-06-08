using System;
namespace Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test tst1 = new Test(2,3);
            Test tst2 = new Test(2,3);
            Test tst3 = new Test();

            tst3 = tst1 * tst2;
            tst3.Print();
            
        }
    }

    public class Test
    {
        private int a;
        private int b;

        public  Test(){}
        public Test(int a, int b) 
        {
            this.a = a;
            this.b = b; 
        }

        public void Print()
        {
            Console.WriteLine($"{this.a}");
            Console.WriteLine($"{this.b}");
        }
        public static Test operator* (Test a, Test b) {
            Test tst = new Test();
            tst.a = a.a * b.a;
            tst.b= a.b * b.b;
            
            return tst;
        }
    }
}

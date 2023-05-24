namespace HW_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************** PART1 ******************");
            int num1 = 10;
            int num2 = 5;
            
            Console.WriteLine("{0}+{1} = {2}", num1, num2,num1 + num2);
            Console.WriteLine("{0}/{1} = {2}", num1, num2, num1 / num2);
            
            Console.WriteLine("****************** PART2 ******************");
            // мені було ліньки створювати купу змінних :)
            Console.WriteLine("-1 + 4 * 6 = {0}", -1 + 4 * 6);
            Console.WriteLine("( 35 + 5 ) % 7 = {0}", (35 + 5) % 7);
            Console.WriteLine("14 + -4 * 6 / 11 = {0:F2}", 14 + -4 * 6 / 11f);
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = {0}", 2 + 15 / 6 * 1 - 7 % 2);

            Console.WriteLine("****************** PART3 ******************");
            string inputFirst, inputSecond;
            // ask user to enter some data
            Console.Write("Input the First Number :");
            inputFirst= Console.ReadLine();
            Console.Write("Input the Second Number :");
            inputSecond = Console.ReadLine();
            
            // swap variables
            (inputFirst, inputSecond) = (inputSecond, inputFirst);
            
            Console.WriteLine("First Number : " + inputFirst);
            Console.WriteLine("Second Number : " + inputSecond);

            Console.WriteLine("****************** PART3 ******************");
            int numberOne, numberTwo, numberThree;
            
            Console.Write("Number 1 :");
            numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2 :");
            numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 3 :");
            numberThree = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} * {1} * {2} = {3}", numberOne, numberTwo, numberThree, numberOne * numberTwo * numberThree);
        }
    }
}
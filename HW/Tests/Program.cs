namespace Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 5;
            int numberTwo = 10;

            if ((numberOne > 0 & numberTwo > 0) || (numberOne < 0 & numberTwo < 0))
                Console.WriteLine("FALSE");
            else
                Console.WriteLine("TRUE");
        }
    }
}
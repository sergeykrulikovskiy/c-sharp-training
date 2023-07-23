namespace ConsoleAppDelegate
{
    public delegate void PrintString(string msg);

    internal class Program
    {
        

        static void Main(string[] args)
        {
            PrintString printString = PrintInGreen;
            printString += PrintInOrange;
            printString("Some text");
        }

        public static void PrintInGreen(string msg)
        {
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine(msg);
        }

        public static void PrintInOrange(string msg)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(msg);
        }
    }
}
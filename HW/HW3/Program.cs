namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program to check two given integers
            // and return true if one is negative and one is positive.
            int numberOne = -5;
            int numberTwo = 10;

            if ((numberOne > 0 & numberTwo > 0) || (numberOne < 0 & numberTwo < 0))
                Console.WriteLine("FALSE - both are negative or positive");
            else
                Console.WriteLine("TRUE - one is negative and one is positive");

            Console.WriteLine();
            // Write a C# program to check the sum of the two given integers
            // and return true if one of the integer is 20 or if their sum is 20.
            int numToCheck = 20;
            int num1       = 10;
            int num2       = 30;
            int sum        = num1 + num2;

            if ( num1 == numToCheck || num2 == numToCheck || sum == numToCheck)
                Console.WriteLine($"TRUE - {numToCheck} found");
            else
                Console.WriteLine($"FALSE - {numToCheck} not found");

            Console.WriteLine();
            // Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
            int minNumber = 1;
            int maxNumber = 99;
            int i;
            string delimiter=",";

            // для зручності читання результату в консолі - вивів все в одному рядку...
            Console.Write($"Odd numbers from {minNumber} to {maxNumber}: ");
            for (i = minNumber; i <= maxNumber; i++)
            {
                if (i % 2 != 0) {
                    if (i == maxNumber) delimiter = "";
                    Console.Write($"{i}{delimiter}");
                }
            }
            
            Console.WriteLine();
            Console.WriteLine();
            // Write a C# program to compute the sum of the first 500 prime numbers (Sum=824693)
            int j;
            int primesFound = 0, primesSum = 0;
            int primesTotal = 500;

            i = 2;

            do
            {
                for (j = 2; j <= (i / j); j++)
                    if ((i % j) == 0) break;
                    if (j > (i / j))
                    {
                        primesFound++;
                        primesSum += i;
                    }
                i++;
            } while (primesFound < primesTotal);
            Console.WriteLine($"Sum of the first {primesTotal} prime numbers = {primesSum}");

            Console.WriteLine();
            // Write a C# program and compute the sum of the digits of an integer.
            // Input a number(integer): 12 (string.Length)
            // Sum of the digits of the said integer: 3
            string inputLine = "12345";
            int result = 0;

            for (i=0; i<inputLine.Length; i++)
            {
                result += Convert.ToInt32(Convert.ToString(inputLine[i])); 
            }
            Console.WriteLine($"Sum of the \"{inputLine}\" digits = {result}");
        }
    }
}
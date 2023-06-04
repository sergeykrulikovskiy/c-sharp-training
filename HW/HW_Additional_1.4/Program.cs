using System.Data.Common;

namespace HW_Additional_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = 12345;
            PrintReverse(inputNumber);

            int[] triangleAngles = { 40, 55, 65 };
            CheckTriangle(triangleAngles);
                        
            int[] myArray = { 2,9,1,4,6 };
            Console.WriteLine("Search in {0}:", string.Join(",", myArray));
            GetSecondLargestMember(myArray);

            // Висота має бути 5+ рядків
            PrintA(15);
        }

        //Write a program in C# Sharp to display a number in reverse order.
        public static void PrintReverse(int inputData)
        {
            
            string inputDataAsStr = Convert.ToString(inputData);

            Console.Write($"Input: {inputData}. Reversed: ");

            for (int i = inputDataAsStr.Length - 1; i >= 0; i--)
            {
                Console.Write(inputDataAsStr[i]);
            }
            Console.WriteLine();
        }

        // Write a C# Sharp program to display an alphabet pattern like A with an asterisk
        public static void PrintA(int heightToPrint)
        {
            int marginCenterInit = 1;
            string fillCenterWith, marginLeft;
            int consoleCenter = Convert.ToInt32((Console.WindowWidth / 2) - heightToPrint); // для виводу літери А по центру консолі

            // перший рядок
            Console.WriteLine("{0}*", new string(' ', heightToPrint - 1 + consoleCenter));
            for (int i = 1; i < heightToPrint; i++)
            {
                // якщо приблизно середина, то заповнюємо *.
                // В інших випадках втсановлюємо кількість пробілів (кожний наступний рядок +2 пробіли) 
                if (i == Convert.ToInt32(heightToPrint / 2) + 1)
                    fillCenterWith = ($" {new string('*', marginCenterInit - 2)} ");
                else
                    fillCenterWith = new string(' ', marginCenterInit);

                marginCenterInit += 2;

                // відступ від лівого краю
                marginLeft = new string(' ', heightToPrint - 1 - i + consoleCenter);

                Console.WriteLine($"{marginLeft}*{fillCenterWith}*");
            }
        }
        // Write a C# Sharp program to find the second largest element in an array.
         public static void GetSecondLargestMember(int[] inputArray)
        {
            int largestNum = inputArray[0];
            int SecondLargestNum=0;

            
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (largestNum < inputArray[i])
                {
                    SecondLargestNum = largestNum;
                    largestNum = inputArray[i];
                }
                else if (SecondLargestNum < inputArray[i])
                {
                    SecondLargestNum = inputArray[i];
                }
            }
            Console.WriteLine($"\tlargestNum       = {largestNum}");
            Console.WriteLine($"\tSecondLargestNum = {SecondLargestNum}");
        }
        // Check whether a triangle can be formed by the given angles value.
        public static void CheckTriangle(int[] inputArray)
        {
            int triangleAnglesSum = 0;

            foreach (int elem in inputArray)
            {
                triangleAnglesSum += elem;
            }
            if (triangleAnglesSum == 180)
                Console.WriteLine($"Triangle can be formed. Angles sum = {triangleAnglesSum}");
            else
                Console.WriteLine($"Triangle can't be formed! Angles sum = {triangleAnglesSum}");
        }
    }
}
namespace HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Largest: {FindLargest(1, 2, 5)}");
            Console.WriteLine($"Lowest: {FindLowet(6, 2, 5)}");
            Console.WriteLine($"Nearest To: {FindNearestTo(12,17,20)}");
            
            int[] myArray = { 4, 5, 3, 1, 2 };
            Console.WriteLine($"SumOfArrayElements: {SumOfArrayElements(myArray)}");
            Console.WriteLine($"Largest value: {GetLargestMember(myArray)}");
            Console.WriteLine($"Largest value (loop): {GetLargestMemberLoop(myArray)}");
            
        }

        // Write a C# method to find the largest value from three integer values.
        public static int FindLargest(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        // Write a C# method to find the lowest value from three integer values.
        public static int FindLowet(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                return a;
            }
            else if (b < c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        
        //Write a C# method to check the nearest value of 20 of two given integers and return 0 if two numbers are same 
        public static int FindNearestTo(int a, int b, int targetValue)
        {
            if (a==b)
            {
                return 0;
            } else if (targetValue-a < targetValue-b)
            {
                return a;
            } else
            {
                return b;
            }
        }

        //Write a C# method to compute the sum of all the elements of an array of integers 
        public static int SumOfArrayElements(int[] inputArray)
        {
            int result=0;
            foreach (int element in inputArray)
            {
                result+= element;
            }
            return result;
        }

        //Write a C# method to get the larger value from array
       public static int GetLargestMember(int[] inputArray)
        {
            Array.Sort(inputArray);
            return inputArray[inputArray.Length-1];
        }
        public static int GetLargestMemberLoop(int[] inputArray)
        {
            int largestNum = inputArray[0];

            for (int i=1; i<inputArray.Length; i++)
            {
                if (largestNum < inputArray[i])
                    largestNum = inputArray[i];
            }
            return largestNum;
        }
    }
}
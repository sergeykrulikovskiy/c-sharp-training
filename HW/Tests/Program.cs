namespace Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Висота має бути 5+ рядків
            PrintA(15);
        }

        public static void PrintA (int heightToPrint)
        {
            int marginCenterInit = 1;
            string fillCenterWith, marginLeft;
            int consoleCenter = Convert.ToInt32((Console.WindowWidth/2)-heightToPrint);

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
    }
}
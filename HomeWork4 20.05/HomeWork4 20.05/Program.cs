using System;

namespace HomeWork4_20._05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1-ci ededi daxil edin: ");
            int numberFirst = Convert.ToInt32(Console.ReadLine());
            Console.Write("2-ci ededi daxil edin: ");
            int numberSecond = Convert.ToInt32(Console.ReadLine());
            int oddNumberSum = 0;
            for (int i = numberFirst; i <= numberSecond; i++)
            {
                if (i % 2 != 0)
                {
                    oddNumberSum = oddNumberSum + i;
                }
            }
            Console.WriteLine($"{numberFirst} ile {numberSecond} ededleri arasindaki tek ededlerin cemi = {oddNumberSum}");

        }
    }
}

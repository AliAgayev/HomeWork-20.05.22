using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1-ci ededi daxil edin: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("2-ci ededi daxil edin: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine($"{firstNumber} ile {secondNumber} ededleri arasindaki ededlerin toplami = {sum}");
        }
    }
}

using System;

namespace HomeWork2_20._05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-ci ededi daxil edin: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2-ci ededi daxil edin: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            int count = 0;
            int avg = 0;
            for (int i = number1; i <= number2; i++)
            {
                total = total + i;
                count++;
            }
            avg = total / count;
            Console.WriteLine($"{number1} ile {number2} ededlerinin ededi ortasi = {avg}");
        }
    }
}

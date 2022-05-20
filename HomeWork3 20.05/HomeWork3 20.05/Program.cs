using System;

namespace HomeWork3_20._05
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isContiniue = true;
            string sorgu = "";
            do
            {
                Console.WriteLine("Yasinizi daxil edin: ");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age >= 18)
                {
                    Console.WriteLine("Texniki Ingilis dili balini daxil edin: ");
                    int engPoint = Convert.ToInt32(Console.ReadLine());
                    if (engPoint > 50)
                    {
                        Console.WriteLine("Tebrikler siz kursa qeydiyyata alindiniz");

                        Console.WriteLine("Basqa telebe varmi? he/yox");
                        sorgu = Console.ReadLine().ToLower();
                        if (sorgu == "he")
                        {
                            isContiniue = true;
                        }
                        else
                        {
                            isContiniue = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sizin texniki ingilis dili baliniz 50-den az olduguna gore qeydiyyata alina bilmediniz");
                        Console.WriteLine("Basqa telebe varmi? he/yox");
                        sorgu = Console.ReadLine().ToLower();
                        if (sorgu == "he")
                        {
                            isContiniue = true;
                        }
                        else
                        {
                            isContiniue = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Yasiniz 18-den az olduguna gore qeydiyyata alina bilmediniz");
                }
            } while (isContiniue);
        }
    }
}

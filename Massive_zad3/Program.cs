using System;

namespace Massive_zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Введите кол-во элементов последовательности:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите последовательность через пробел:");
            var D = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            for (int i = 0; i < n; i++)
            {
                if (i%2!=0)
                {
                    count += D[i];
                }
              
            }
            Console.WriteLine($"Массив D - {string.Join (',', D)}. Сумма его элементов с нечетными индексами - {count}");
        }
    }
}

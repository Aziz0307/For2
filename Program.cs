using System;

namespace For1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int n = 0;
            for (int i = b-1; i > a; i--)
            {
                n++;
                Console.WriteLine(i);
            }
            Console.WriteLine($"Kolishestvo n takikh chislo ravno= {n}");
        }
    }
}
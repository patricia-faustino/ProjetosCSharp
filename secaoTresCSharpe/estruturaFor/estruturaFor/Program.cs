using System;

namespace estruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                Console.Write("Valor #" + i + ": ");
                int dig = int.Parse(Console.ReadLine());
                sum += dig;
            }
            Console.WriteLine("Soma: " + sum);
        }
    }
}

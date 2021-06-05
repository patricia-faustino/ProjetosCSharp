using System;
using System.Globalization;

namespace estruturaWhile
{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero ");
        double n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        while(n > 0)
        {
            double raiz = Math.Sqrt(n);
            Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Digite outro numero ");
            n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }
            Console.WriteLine("Número negativo!");
    }
}
}

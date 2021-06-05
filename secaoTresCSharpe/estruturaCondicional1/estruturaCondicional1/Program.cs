using System;

namespace estruturaCondicional1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um valor do tipo inteiro: ");
            int entrada = int.Parse(Console.ReadLine());

            if(entrada % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Ímpar!");
            }

        }
    }
}

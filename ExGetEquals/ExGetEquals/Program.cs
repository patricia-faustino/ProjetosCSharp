using System;
using ExGetEquals.Entities;

namespace ExGetEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client() { Name = "Maria", Email = "maria@email.com" };
            Client b = new Client() { Name = "Alex", Email = "alex@email.com" };

            //compara conteudo
            Console.WriteLine(a.Equals(b));
            //compara referência do ponteiro do objeto
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());


        }
    }
}

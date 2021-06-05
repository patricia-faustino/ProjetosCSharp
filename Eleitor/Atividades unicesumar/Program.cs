using System;

namespace Atividades_unicesumar
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());
            
            if(idade >=0 && idade < 16)
            {
                Console.WriteLine("Não eleitor");

            }
            else
            {
                if(idade >=18 && idade < 65)
                {
                    Console.WriteLine("Eleitor obrigatório");
                }
                else
                {
                    Console.WriteLine("Eleitor facultativo");
                }
            }

        }
    }
}

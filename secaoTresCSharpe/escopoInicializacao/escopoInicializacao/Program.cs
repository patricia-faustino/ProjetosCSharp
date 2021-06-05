using System;

namespace escopoInicializacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine()); // ao declarar uma variavel deve ser atribuído o valor desta

            if (preco > 100)
            {
                double desconto = preco * 0.1; 
            }

            // Console.WriteLine(desconto); // variavel só é reconhecida no escopo do seu bloco
        }
    }
}

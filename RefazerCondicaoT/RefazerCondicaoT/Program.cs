using System;

namespace RefazerCondicaoT {
    class Program {
        static void Main(string[] args) {
            double preco = 34.5;
            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;
            preco += desconto;
            Console.WriteLine(preco);

        }
    }
}

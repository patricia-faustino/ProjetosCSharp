using System;

namespace ex32 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o código");
            int cod = int.Parse(Console.ReadLine());

            while(cod != 4) {
                if(cod == 1) {
                    Console.WriteLine(" Alcool: 1 ");
                } else if( cod == 2) {
                    Console.WriteLine(" Gasolina: 2 ");
                } else if(cod == 3) {
                    Console.WriteLine("Diesel: 0");
                }
                Console.WriteLine("Digite o código");
                cod=int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Muito Obrigada!");

        }
    }
}

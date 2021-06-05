using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite a senha");

            int senha = int.Parse(Console.ReadLine());

            while( senha != 2002) {

                Console.WriteLine(" Senha Invalida ");

                Console.WriteLine("Digite a senha");

                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" Acesso Permitido ");


        }
    }
}

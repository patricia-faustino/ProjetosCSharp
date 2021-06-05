using System;

namespace ex2ifelse {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com dois números inteiros ");
            int A= int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            if(A % B == 0) {
                Console.WriteLine($"{A} é múltiplo de {B}");
            }else {
                Console.WriteLine("Nao sao Multiplos");

            }


        }
    }
}

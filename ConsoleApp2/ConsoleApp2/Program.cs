using System;

namespace ConsoleApp2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um número");
            int N = int.Parse(Console.ReadLine());
            for(int i =1; i <= N; i++) {
                int quadra = i*i;
                int cub = i * i * i;
                Console.WriteLine($"{i} {quadra} {cub}");

            }

        }
    }
}

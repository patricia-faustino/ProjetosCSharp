using System;

namespace funcoes {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite três números");
            int A= int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());//break point

            double resultado = Maior(A, B, C);
            Console.WriteLine($"Maior = {resultado}");

            static int Maior(int a, int b, int c) {
                int m;
                if (a > b && a > c) {
                    m = a;
                }
                else if (b > c) {
                    m = b;
                }
                else {
                    m = c;
                }
                return m;
            }

        }
    }
}

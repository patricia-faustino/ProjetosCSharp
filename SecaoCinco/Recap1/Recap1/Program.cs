using System;
using System.Globalization;


namespace Recap1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um caractere: ");
            char caractere = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número: ");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Informe um nome, seu sexo por F ou M, sua idade e sua altura. Todos separados por espaço");
            string[] vet = Console.ReadLine().Split(' ');
            string a = vet[0];
            char b= char.Parse(vet[1]);
            int c= int.Parse(vet[2]);
            double d= double.Parse(vet[3],CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d.ToString("F2",CultureInfo.InvariantCulture));


        }

    }
}

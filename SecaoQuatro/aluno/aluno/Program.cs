using System;
using System.Globalization;

namespace aluno {
    class Program {
        static void Main(string[] args) { 
            Aluno a = new Aluno();

            Console.Write("Nome do Aluno: ");
            a.Nome= Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            a.Nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(a);

            if (a.Aprovado()) {
                Console.WriteLine("APROVADO");
            } else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "+ a.QuantoFalta().ToString("F2", CultureInfo.InvariantCulture) +" PONTOS");

            }



        }
    }
}

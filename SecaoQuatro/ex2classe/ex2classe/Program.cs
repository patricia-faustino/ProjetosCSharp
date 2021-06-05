using System;
using System.Globalization;
namespace ex2classe {
    class Program {
        static void Main(string[] args) {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();
;
            Console.WriteLine("Dados do funcionário 1:");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salário = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do funcionário 2:");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salário = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double medsal = (f1.Salário + f2.Salário) / 2.0;
            Console.WriteLine("Salário médio = "+medsal.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}

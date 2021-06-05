using System;
using System.Globalization;

namespace exercicio2clas {
    class Program {
        static void Main(string[] args) {
            Funcionário func = new Funcionário();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func.SalarioBruto =double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(func);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            func.AumentarSalario(porcentagem);

            Console.WriteLine("Dados atualizados: "+func);
            
        }
    }
}

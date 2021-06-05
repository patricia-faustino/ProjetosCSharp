using System;
using System.Globalization;

namespace correcaoexercico {
    class Program {
        static void Main(string[] args) {
            ContaBancaria conta;
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp= char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.Write("Entre um valor para depósito: ");
                double depositoinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoinicial);

            }
            else {
                conta = new ContaBancaria(numero, titular);

            }
            Console.WriteLine();
            Console.Write("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}

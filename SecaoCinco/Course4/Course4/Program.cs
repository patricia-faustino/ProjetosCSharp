using System;
using System.Globalization;

namespace Course4 {
    class Program {
        static void Main(string[] args) {
            ContaBancaria conta;
            Console.WriteLine("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)? ");
            char resp =char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S') {
                Console.WriteLine("Entre com o valor do depósito inicial: ");
                double dpi = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, dpi);

                } else {
                conta = new ContaBancaria(numero, titular);

            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.WriteLine("Entre com  um valor para depósito: ");
            double entsa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(entsa);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.WriteLine("Entre com um valor para saque: ");
            entsa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(entsa);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            }
            
        }
    }


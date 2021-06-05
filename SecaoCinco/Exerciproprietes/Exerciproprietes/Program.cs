using System;
using System.Globalization;
namespace Exerciproprietes {
    class Program {
        static void Main(string[] args) {
            Conta contato;
            
            Console.WriteLine("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)? ");
            char dfo = char.Parse(Console.ReadLine()); 
            if (dfo =='s'||dfo =='S') {
               contato = new Conta(conta, titular, dfo);

            }
            else {
                 contato = new Conta(conta, titular); 

            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(contato);


            Console.WriteLine("Entre o valor de depósito inicial: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contato.Deposito(quantia);
            Console.WriteLine(contato);

            Console.WriteLine("Entre um valor para depósito: ");
            quantia= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contato.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados ");
            Console.WriteLine(contato);
            


        }
    }
}

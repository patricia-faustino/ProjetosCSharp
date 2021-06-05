using System;
using ExFixInteracao.Entities;
using ExFixInteracao.Services;
using System.Globalization;

namespace ExFixInteracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contracNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double contractTotalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract mycontract = new Contract(contracNumber, contractDate, contractTotalValue);
            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(mycontract, months);
            Console.WriteLine("Installments: ");

            foreach (Installment installment in mycontract.Installments)
            {
                Console.WriteLine(installment);
            }


        }
    }
}

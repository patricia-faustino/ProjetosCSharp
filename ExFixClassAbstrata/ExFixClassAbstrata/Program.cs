using System;
using System.Globalization;
using System.Collections.Generic;
using ExFixClassAbstrata.Entities;

namespace ExFixClassAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for(int i=1; i<= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anuallCome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if(ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anuallCome, healthExpenditures));
                    
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anuallCome, numberOfEmployees));
                }

            }
            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach(TaxPayer tx in list)
            {
                double tax = tx.Tax();
                Console.WriteLine(tx.Name
                    +": $"
                    +tax.ToString("F2",CultureInfo.InvariantCulture));
                sum += tax;
            }
            Console.WriteLine("TOTAL TAXES: $"+sum.ToString("F2",CultureInfo.InvariantCulture));
           
        }
    }
}

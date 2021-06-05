using System;
using Course.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.00, 0.1));
            list.Add(new BusinessAccount(1002, "Bob", 500.00, 40.0));
            list.Add(new SavingsAccount(1003, "Maria", 400.00, 0.1));
            list.Add(new BusinessAccount(1004, "Ana", 500.00, 500.00));

            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }
            Console.WriteLine("Total Balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));
            foreach (Account acc in list)
            {
                acc.Withdraw(10);
            }
            foreach(Account acc in list)
            {
                Console.WriteLine("Update balance for account " +
                    acc.Number 
                    +acc.Balance.ToString("F2",CultureInfo.InvariantCulture));
            }


        }
    }

       
}


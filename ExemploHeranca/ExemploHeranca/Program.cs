using System;
using ExemploHeranca.Entities;

namespace ExemploHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //bacc.Balance = 500.00; Nao pode ser alterado, pois esta com o protected

            Account acc = new Account(1001, "Bob", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.00);

            // UpCasting
            // Isso ocorre de forma que o programa aceita pq uma superclasse faz parte da subclasse

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Alex", 0.0, 200.00);
            Account acc3 = new SavingsAccount(1004, "Joana", 0.0, 0.1);

            // DownCasting
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(1000.0);
            //acc3.Loan(100.0); Primeiro tem que ser feito o DownCasting

           // BusinessAccount acc5 = (BusinessAccount)acc3; Erro so ira aparecer no tempo de execucao, eh necessario fazer teste com if

            if(acc3 is BusinessAccount)
            {
                // BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; // outra forma de fazer Casting
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            if(acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                    Console.WriteLine("Update!");
            }


        }
    }
}

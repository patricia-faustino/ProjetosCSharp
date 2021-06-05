using System;
using System.Collections.Generic;
using ExFixPrevisaoErros.Entities.Exceptions;

 namespace ExFixPrevisaoErros.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }
        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }
        public void Deposit(double amount)
        {

            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }
            if(amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            Balance -= amount;
        }
    }
}

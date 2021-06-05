namespace HerancaSobre.Entities
{
    class SavingsAccount : Account
    {

        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance() // Atualizar o saldo conforme a taxa de juros
        {
            Balance += Balance * InterestRate;
        }
        public sealed override void WithDraw(double amount)
        {
            // Balance -= amount; fazer saque sem tirar nada
            base.WithDraw(amount); // reaproveitar operacao da superclasse
            Balance -= 2.0;
        }

    }
}


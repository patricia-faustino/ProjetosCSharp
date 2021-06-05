namespace ExemploHeranca.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimite { get; set; }

        public BusinessAccount()
        {

        }

        public BusinessAccount(int number, string holder, double balance, double loanLimite)
            : base(number, holder, balance)
        {
            LoanLimite = loanLimite;
        }
       
        public void Loan(double amount)
        {
            if(amount == LoanLimite)
                // testar se tem a quantia não ultrapassa o limite que a empresa tem
            {
                Balance += amount;
            }
            
        }
    }
}

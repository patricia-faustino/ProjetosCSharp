namespace ExFixClassAbstrata.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anuallCome, int numberOfEmployees)
            : base(name, anuallCome)
        {
            NumberOfEmployees = numberOfEmployees;
        }
        public override double Tax()
        {
            if(NumberOfEmployees > 10)
            {
                return AnuallCome * 0.14;
            }
            else
            {
                return AnuallCome * 0.16;
            }
        }
    }
}

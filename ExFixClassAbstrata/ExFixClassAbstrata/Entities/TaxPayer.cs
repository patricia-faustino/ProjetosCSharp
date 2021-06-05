namespace ExFixClassAbstrata.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnuallCome { get; set; }

       

        public TaxPayer(string name, double anuallCome)
        {
            Name = name;
            AnuallCome = anuallCome;
        }
        
        public abstract double Tax();
        

    }
}

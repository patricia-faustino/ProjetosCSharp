namespace ExFixClassAbstrata.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }
        public Individual(string name, double anuallCome, double healthExpenditures) 
            : base(name, anuallCome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if(AnuallCome < 20000 && HealthExpenditures > 0)
            {
                return  AnuallCome * 0.15 - HealthExpenditures*0.50;
            }
            else 
            {
                return  AnuallCome * 0.25 - HealthExpenditures * 0.50;
            }
        }
           
        
            
        }
    }


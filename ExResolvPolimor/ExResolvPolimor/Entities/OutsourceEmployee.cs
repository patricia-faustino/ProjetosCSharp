namespace ExResolvPolimor.Entities
{
    class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourceEmployee()
        {

        }
        public OutsourceEmployee(string name, int hours, double valuePerHour, double additionalCharge) 
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }
        public override double Payment()
        {
            return base.Payment() + 1.1* AdditionalCharge;
        }
    }
}

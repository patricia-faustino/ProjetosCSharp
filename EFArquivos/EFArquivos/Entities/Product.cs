using System;


namespace EFArquivos.Entities
{
    class Product
    {
        public string Name { get; private set; }
        public double UnitaryPrice { get; private set; }
        public int Quantity { get; set; }

        public Product(string name, double unitaryPrice, int quantity)
        {
            Name = name;
            UnitaryPrice = unitaryPrice;
            Quantity = quantity;
        }
        public double Total()
        {
            return UnitaryPrice * Quantity;
        }
    
    }
}

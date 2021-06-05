using System;
using System.Globalization;
using System.Text;

namespace ExLinq2.Entities
{
    class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Category.Name;
        }
    }

}

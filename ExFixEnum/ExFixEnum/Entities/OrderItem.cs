using ExFixEnum.Entities;

namespace ExFixEnum.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Products { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price, Product products)
        {
            Quantity = quantity;
            Price = price;
            Products = products;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
        public override string ToString()
        {
            return Products.Name +
                ","+ Price+ ", Quantity: " + Quantity+
                ", Subtotal: "+SubTotal();
        }


    }
}

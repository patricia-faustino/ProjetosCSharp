using System;
using System.Globalization;
using ExFixEnum.Entities.Enums;
using ExFixEnum.Entities;

namespace ExFixEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            DateTime moment = DateTime.Now;
            Clients clients = new Clients(name, email, birthDate);
            Order order = new Order(moment, orderStatus, clients);
           

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{1} item data: ");
                Console.Write("Product name: ");
                string pname = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product products = new Product(pname,price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

               
                OrderItem item = new OrderItem(quantity, price,products);
                order.AddItem(item);
            }
            Console.WriteLine(order);

        }
    }
}

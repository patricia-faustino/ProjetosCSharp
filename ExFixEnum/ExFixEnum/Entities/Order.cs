using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using ExFixEnum.Entities.Enums;

namespace ExFixEnum.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>(); 
        public Clients Clients { get; set; }

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Clients clients)
        {
            Moment = moment;
            Status = status;
            Clients = clients;
        }
        public void AddItem(OrderItem item)
        {
            OrderItem.Add(item);
           

        }
        public void RemoveItem(OrderItem item)
        {
            OrderItem.Add(item);
        }
        public double Total()
        {
            double sum = 0; 
            foreach(OrderItem orderItems in OrderItem)
            {
                sum += orderItems.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Clients);
            sb.AppendLine("Order items: ");
            foreach(OrderItem item in OrderItem)
            {
                sb.AppendLine(item.ToString());
            }
            sb.Append("Total price: $");
            sb.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();

        }
    }
}

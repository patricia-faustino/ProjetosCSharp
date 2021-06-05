using Exemplo1Enumeracao.Entities;
using Exemplo1Enumeracao.Entities.Enums;
using System;

namespace Exemplo1Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order()
            {
                ID = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment

            };
            Console.WriteLine(order);

            //Conversao Enumeracao para String

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //Conversao String para Enumeracao 

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // tipo enum sendo convertido <tipo que deve ser 
            //convertido>("texto igual ao que foi declaro na enum")
            Console.WriteLine(os);

        }
    }
}

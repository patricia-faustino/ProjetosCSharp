using System;
using Exemplo1Enumeracao.Entities.Enums;

namespace Exemplo1Enumeracao.Entities
{
    class Order
    {
        public int ID { get; set; }
        public DateTime Moment  { get; set; }
        public OrderStatus Status  { get; set; }

        public override string ToString()
        {
            return ID+
                ", "+ Moment+
                ", "+ Status;
        }
    }
}

using System;
using System.Globalization;

namespace CotacaoDolar {
    class Program {
        static void Main(string[] args) {
            Console.Write("Qual é a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double compra=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double conversa = ConversorDeMoeda.conv(compra, dolar);
            Console.Write("Valor a ser pago em reais = "+ conversa.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}

using System;

namespace Iso8601 {
    class Program {
        static void Main(string[] args) {

            DateTime d1 = DateTime.Parse("2020-07-29 17:05:49");
            DateTime d2 = DateTime.Parse("2020-07-29T17:05:49Z");// cria local DateTime

            Console.WriteLine("d1: "+ d1);
            Console.WriteLine("Kind: "+ d1.Kind);
            Console.WriteLine("To Local: "+ d1.ToLocalTime());
            Console.WriteLine("To Utc: "+ d1.ToUniversalTime());

            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("Kind: " + d2.Kind);
            Console.WriteLine("To Local: " + d2.ToLocalTime());
            Console.WriteLine("To Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); //cuidado para que não esteja em local
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")); // nao tem erro

        }
    }
}

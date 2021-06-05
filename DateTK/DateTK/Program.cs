using System;

namespace DateTK {
    class Program {
        static void Main(string[] args) {
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine(d1);
            Console.WriteLine(d2); //considera o digitado e não há conversao
            Console.WriteLine(d3); //considera o digitado e não há conversao
            Console.WriteLine("d1: "+d1);
            Console.WriteLine("d1 kind: "+ d1.Kind);
            Console.WriteLine("d1 to Local: "+ d1.ToLocalTime());
            Console.WriteLine("d1 to UTC"+ d1.ToUniversalTime());

            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to UTC" + d2.ToUniversalTime());

            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 kind: " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to UTC" + d3.ToUniversalTime());
        }
    }
}

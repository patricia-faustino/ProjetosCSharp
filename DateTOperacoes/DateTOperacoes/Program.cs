using System;

namespace DateTOperacoes {
    class Program {
        static void Main(string[] args) {
            DateTime d = new DateTime(2020, 07, 26, 15, 04, 39, 500);
            DateTime d2 = d.AddHours(2);
            DateTime d3 = d.AddMinutes(3);
            DateTime d4 = d.AddDays(7);

            //DIFERENCA ENTRE DATAS
            DateTime d5 = new DateTime(2020, 07, 29, 15, 04, 39, 500);
            TimeSpan t = d5.Subtract(d);


            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(t);

            
        }
    }
}

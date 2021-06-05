using System;

namespace TimeS {
    class Program {
        static void Main(string[] args) {
            TimeSpan t1 = new TimeSpan(2, 11, 20);

            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(900000000L); //L: para indicar que é do tipo longo
            TimeSpan t4 = new TimeSpan(1, 2, 11, 20); // dia, hora, minuto, segundo
            TimeSpan t5 = new TimeSpan(1, 2, 11, 20, 550);// dia, hora, minuto, segundo, milisegundo

            // Método From
            TimeSpan t6 = TimeSpan.FromDays(1.5); //permite conversar na unidade desejada, por exemplo em dia
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t11 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t1); // hora, minuto, segundo


            Console.WriteLine();
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);
        }
    }
}

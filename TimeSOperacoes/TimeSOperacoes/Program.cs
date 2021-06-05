using System;

namespace TimeSOperacoes {
    class Program {
        static void Main(string[] args) {
            //Propriedades
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue; // pode ter TimeSpan negativo
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            // Operacoes

            TimeSpan t4 = new TimeSpan(2, 5, 15, 25, 500);
            Console.WriteLine(t4);
            
            // Retorna Inteiro

            Console.WriteLine("Days: " + t4.Days);
            Console.WriteLine("HoUrs: "+ t4.Hours);
            Console.WriteLine("Minutes: "+ t4.Minutes);
            Console.WriteLine("Seconds: "+ t4.Seconds);
            Console.WriteLine("MilliSeconds: "+ t4.Milliseconds);
            Console.WriteLine("Ticks: "+ t4.Ticks);

            // Retorna Quebrado

            Console.WriteLine("Total Days: "+ t4.TotalDays);
            Console.WriteLine("Total Hours: "+ t4.TotalHours);
            Console.WriteLine("Total Minutes: "+ t4.TotalMinutes);
            Console.WriteLine("Total Seconds: "+ t4.TotalSeconds);
            Console.WriteLine("Total MilliSeconds: "+ t4.TotalMilliseconds);
        }
    }
}

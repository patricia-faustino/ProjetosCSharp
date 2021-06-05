using System;

namespace DateTT {
    class Program {
        static void Main(string[] args) {

            DateTime d1 = new DateTime(2001, 08, 15, 12, 55, 42, 500);
            Console.WriteLine(d1);
            Console.WriteLine("1) Date d1: "+ d1.Date); // considera apenas a data
            Console.WriteLine("2) Day d1: "+d1.Day);
            Console.WriteLine("3) Day of Week: "+ d1.DayOfWeek);
            Console.WriteLine("4) Day of Year: "+ d1.DayOfYear);
            Console.WriteLine("5) Hour: "+ d1.Hour);
            Console.WriteLine("6) Kind: "+d1.Kind); // tipo
            Console.WriteLine("7) Milisecond: "+d1.Millisecond);
            Console.WriteLine("8) Minute: "+ d1.Minute);
            Console.WriteLine("9) Month: "+ d1.Month);
            Console.WriteLine("10) Year: "+ d1.Year);
            Console.WriteLine("11) Seconds: "+d1.Second);
            Console.WriteLine("12) Ticks:  "+ d1.Ticks);
            Console.WriteLine("13) Time of Day: "+ d1.TimeOfDay); // duracao. TimeSpan
        }
    }
}

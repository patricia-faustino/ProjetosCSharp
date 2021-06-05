using System;

namespace Memoria6 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Point p;
             p.X = 10;
             p.Y = 20;
            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);
        }
    }
}

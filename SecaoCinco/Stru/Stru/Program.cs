using System;

namespace Stru {
    class Program {
        static void Main(string[] args) {
            Point p;// não precisa fazer Point p = new Point() pq é um tipo strcut é um tipo valor;
            p.X = 10.0;
            p.Y = 20.0;
            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);
        }
    }
}

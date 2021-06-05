using System;

namespace OperadorOpcional2 {
    class Program {
        static void Main(string[] args) {
            double? x = null;
            double?y = 10;

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}

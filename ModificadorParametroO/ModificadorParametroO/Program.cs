using System;

namespace ModificadorParametroO {
    class Program {
        static void Main(string[] args) {
            int a = 10;
            int triple;
            Calcu.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}

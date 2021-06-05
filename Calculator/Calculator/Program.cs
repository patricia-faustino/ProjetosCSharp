using System;

namespace Calculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            int s1 = Calc.Sum(2, 3 ); //forma compacta de informar valores e instanciar
            Console.WriteLine(s1);
            int s2 = Calc.Sum(2, 3, 4 );
            Console.WriteLine(s2);
        }
    }
}

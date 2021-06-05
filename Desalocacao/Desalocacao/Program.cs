using System;

namespace Desalocacao {
    class Program {
        static void Main(string[] args) {
            void method1() {
                Product p = method2();
                Console.WriteLine(p.Name);
            }
            Product method2() {
                Product prod = new Product("TV", 900.0, 0);
                return prod;
            }
        }
    }
}

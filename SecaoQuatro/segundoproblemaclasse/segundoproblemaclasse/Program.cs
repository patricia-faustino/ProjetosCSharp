using System;
using System.Globalization;

namespace segundoproblemaclasse {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("TV", 500.00, 10);
            Console.WriteLine(p.GetNome());
            p.SetNome ("TV 4K");

            Console.WriteLine(p.GetNome());
        }
    }
}

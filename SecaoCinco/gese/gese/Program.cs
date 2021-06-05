using System;

namespace gese {
    class Program {
        static void Main(string[] args) {
            Produto p = new Produto();

            p.Nome= "TV";
            Console.WriteLine(p.Nome);
            /*p.SetNome("TV");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());*/
        }
    }
}

using System;
using System.Globalization;

namespace ConsoleApp3 {
    class Program {
        static void Main(string[] args) {
            Product p;
           
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
            p = new Product(nome, preco, quantidade);
          
            Console.WriteLine(p);
            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.Adicionar(qtd);
            Console.WriteLine(p);
            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.Remover(qtd);
            Console.WriteLine("Dados atualizados: "+p);



        }
    }
}

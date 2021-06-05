using System;

namespace exclasse1 {
    class Program {
        static void Main(string[] args) {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa ");
            Console.WriteLine("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa ");
            Console.WriteLine("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());
            
            if(p2.Idade > p1.Idade) {

                Console.WriteLine($"Pessoa mais velha: {p2.Nome}");

            }else {

                Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            }


        }
    }
}

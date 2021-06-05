using System;

namespace RepetindoExercicioVetoresf {
    class Program {
        static void Main(string[] args) {
         
            Estudante[] vector = new Estudante[10];
            Console.WriteLine("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i < n; i ++) {
                int j = i + 1;
                Console.WriteLine("Aluguel #: "+ j);
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int bedroom = int.Parse(Console.ReadLine());
                vector[bedroom] = new Estudante(name,email);

            }
            
            for(int i=0; i<10; i++) {
                if(vector[i] != null) {
                    Console.WriteLine(i +": "+ vector[i]);
                }
            }

        }
    }
}

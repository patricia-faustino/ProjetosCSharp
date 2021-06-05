using System;

namespace ExercicioVetor {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Aluguel[] vect = new Aluguel[10];

            
                for(int i = 0; i <n; i++) {


                int j = i + 1;
                    Console.WriteLine("Aluguel #"+ j);

                    Console.Write("Nome: ");
                    string name = Console.ReadLine();

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Console.Write("Quarto: ");
                    int bedroom = int.Parse(Console.ReadLine());
                    vect[bedroom] = new Aluguel(name, email);

                }
                Console.WriteLine();
                Console.WriteLine("Quartos ocupados: ");
                for(int i=0; i < 10; i++) {
                    if(vect[i] != null) {
                        Console.WriteLine(i+": "+vect[i]);
                    }
                }

                
            }



        }
    }

